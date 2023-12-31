﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    public class Board
    {
        public int[,] board = new int[MainMenuForm.Rows, MainMenuForm.Cols];
        public int currentPlayerTurn = 1;
        public int moves = 0;
        public int rows = MainMenuForm.Rows;
        public int columns = MainMenuForm.Cols;

        public int NUM_COL
        {
            get => columns;
        }

        public int NUM_ROW
        {
            get => rows;
        }

        public Board() { }

        public Board(Board b)
        {
            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < NUM_COL; j++) board[i, j] = b.board[i, j];
            }

            currentPlayerTurn = b.currentPlayerTurn;
            moves = b.moves;
        }

        public Board(int[,] board, int currentPlayerTurn, int moves, int rows, int cols)
        {
            this.rows = rows;
            this.columns = cols;
            this.board = board;
            this.currentPlayerTurn = currentPlayerTurn;
            this.moves = moves;
        }

        public bool IsFull() => moves == rows * columns;


        //Returns the board as a 2d array
        public List<List<int>> GetBoard()
        {
            List<List<int>> boardList = new List<List<int>>();
            for (int i = 0; i < NUM_ROW; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < NUM_COL; j++) row.Add(board[i, j]);
                boardList.Add(row);
            }
            return boardList;
        }

        public ulong GetHash()
        {
            ulong hash = 0;
            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < NUM_COL; j++)
                {
                    hash = hash * 3 + (ulong)board[i, j];
                }
            }
            return hash;
        }

        public bool MakeMove(int column, int player)
        {
            if (column < 1 || column > NUM_COL) return false;
            if (board[0, column - 1] != 0) return false;

            for (int i = NUM_ROW-1; i >= 0; i--)
            {
                if (board[i, column - 1] == 0)
                {
                    board[i, column - 1] = player;
                    break;
                }
            }

            moves++;
            currentPlayerTurn = (currentPlayerTurn == 1) ? 2 : 1;
            return true;
        }

        public bool MakeMove(int column) => MakeMove(column, currentPlayerTurn);

        //Checks if a move is valid
        public bool ValidMove(int column) => board[0, column - 1] == 0;

        //Find the next winning move and returns the column, if no winning move is found, returns 0. If it is a draw, returns -1
        public int WinningMove(Board board)
        {
            //Check Horizontal
            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < (int)NUM_COL - 3; j++)
                {
                    if (board.board[i, j] != 0 &&
                        board.board[i, j] == board.board[i, j + 1] &&
                        board.board[i, j] == board.board[i, j + 2] &&
                        board.board[i, j] == board.board[i, j + 3])
                        return board.board[i, j];
                }
            }

            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < (int)NUM_COL - 3; j++)
                {
                    if (board.board[i, j] != 0 &&
                        board.board[i, j] == board.board[i, j + 1] &&
                        board.board[i, j] == board.board[i, j + 2] &&
                        board.board[i, j] == board.board[i, j + 3])
                        return board.board[i, j];
                }
            }

            //Check Vertical
            for (int i = 0; i < NUM_ROW - 3; i++)
            {
                for (int j = 0; j < NUM_COL; j++)
                {
                    if (board.board[i, j] != 0 &&
                        board.board[i, j] == board.board[i + 1, j] &&
                        board.board[i, j] == board.board[i + 2, j] &&
                        board.board[i, j] == board.board[i + 3, j])
                        return board.board[i, j];
                }
            }

            //Check Diagonal (top left to bottom right)
            for (int i = 0; i < NUM_ROW - 3; i++)
            {
                for (int j = 0; j < NUM_COL - 3; j++)
                {
                    if (board.board[i, j] != 0 &&
                        board.board[i, j] == board.board[i + 1, j + 1] &&
                        board.board[i, j] == board.board[i + 2, j + 2] &&
                        board.board[i, j] == board.board[i + 3, j + 3])
                        return board.board[i, j];
                }
            }

            //Check Diagonal (top right to bottom left)
            for (int i = 0; i < NUM_ROW - 3; i++)
            {
                for (int j = 3; j < NUM_COL; j++)
                {
                    if (board.board[i, j] != 0 &&
                        board.board[i, j] == board.board[i + 1, j - 1] &&
                        board.board[i, j] == board.board[i + 2, j - 2] &&
                        board.board[i, j] == board.board[i + 3, j - 3])
                        return board.board[i, j];
                }
            }

            if (board.IsFull()) return 3;
            return 0;
        }

        public int NextWinningMove(Board board)
        {
            int returnValue = -1;
            int targetPlayer = board.currentPlayerTurn;

            //if the target can win in the next move, return that move
            //else if the opponent can win in the next move, block that move

            Parallel.For(1, NUM_COL, (i, state) =>
            {
                //Loop over both players
                for (int j = 1; j <= 2; j++)
                {
                    Board tempBoard = new Board(board);
                    if (tempBoard.MakeMove(i, j))
                    {
                        if (WinningMove(tempBoard) == j)
                        {
                            returnValue = i;
                            state.Stop();
                        }
                    }
                }
            });

            return returnValue;
        }

        public int OpenFourInARowLines()
        {
            int returnValue = 0;

            //Check Horizontal
            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < NUM_COL - 3; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i, j + 1] == 0 &&
                        board[i, j + 2] == 0 &&
                        board[i, j + 3] == 0)
                        returnValue++;
                }
            }

            //Check Vertical
            for (int i = 0; i < NUM_ROW - 3; i++)
            {
                for (int j = 0; j < NUM_COL; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i + 1, j] == 0 &&
                        board[i + 2, j] == 0 &&
                        board[i + 3, j] == 0)
                        returnValue++;
                }
            }

            //Check Diagonal (top left to bottom right)
            for (int i = 0; i < NUM_ROW - 3; i++)
            {
                for (int j = 0; j < (int)NUM_COL - 3; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i + 1, j + 1] == 0 &&
                        board[i + 2, j + 2] == 0 &&
                        board[i + 3, j + 3] == 0)
                        returnValue++;
                }
            }

            //Check Diagonal (top right to bottom left)
            for (int i = 0; i < NUM_ROW - 3; i++)
            {
                for (int j = 3; j < NUM_COL; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i + 1, j - 1] == 0 &&
                        board[i + 2, j - 2] == 0 &&
                        board[i + 3, j - 3] == 0)
                        returnValue++;
                }
            }

            return returnValue;
        }

        public int OpenThreeInARowLines()
        {
            int returnValue = 0;

            //Check Horizontal
            for (int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < NUM_COL-2; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i, j + 1] == 0 &&
                        board[i, j + 2] == 0)
                        returnValue++;
                }
            }

            //Check Vertical
            for (int i = 0; i < (int) NUM_ROW - 2; i++)
            {
                for (int j = 0; j < NUM_COL; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i + 1, j] == 0 &&
                        board[i + 2, j] == 0)
                        returnValue++;
                }
            }

            //Check Diagonal (top left to bottom right)
            for (int i = 0; i < (int)NUM_ROW - 2; i++)
            {
                for (int j = 0; j < NUM_COL-2; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i + 1, j + 1] == 0 &&
                        board[i + 2, j + 2] == 0)
                        returnValue++;
                }
            }

            //Check Diagonal (top right to bottom left)
            for (int i = 0; i < (int)NUM_ROW - 2; i++)
            {
                for (int j = 2; j < NUM_COL; j++)
                {
                    if (board[i, j] == 0 &&
                        board[i + 1, j - 1] == 0 &&
                        board[i + 2, j - 2] == 0)
                        returnValue++;
                }
            }

            return returnValue;
        }
    }
}
