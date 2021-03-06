﻿using System;
using System.Collections.Generic;
using System.Text;

namespace minesweeper
{
    public class Board
    {

        public Cell[,] BoardArray { get; set; }

        public int BoardSize { get; set; }

        public int NumberOfMines { get; set; }

        public List<Cell> ListOfMines { get; set; }

        public void PopulateGameBoard()
        {
            BoardArray = new Cell[BoardSize, BoardSize];

            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    BoardArray[x, y] = new Cell() { XCoordinate = x, YCoordinate = y }; ;
                }
            }

            GenerateMines();
        }

        private void GenerateMines()
        {
            Random rand = new Random();
            ListOfMines = new List<Cell>();

            for (int i = 0; i < NumberOfMines; i++)
            {
                int x = rand.Next(0, BoardSize - 1);
                int y = rand.Next(0, BoardSize - 1);

                if (BoardArray[x, y].IsMine == false)
                {
                    BoardArray[x, y].IsMine = true;              
                    ListOfMines.Add(BoardArray[x,y]);
                    IncrementProxCounterForSurroundingCells(this, BoardArray[x, y]);
                }
                else
                {
                    //try again since duplicate
                    i--;
                }
            }


        }

        private void IncrementProxCounterForSurroundingCells(Board board, Cell mine)
        {
            var cellQueue = GetSurroundingCells(this, mine);

            while (cellQueue.Count > 0)
            {
                cellQueue.Dequeue().ProximityCounter++;
            }

        }

        public static Queue<Cell> GetSurroundingCells(Board board, Cell cell)
        {
            var surroundingCellsQueue = new Queue<Cell>();

            for (int x = cell.XCoordinate - 1; x <= cell.XCoordinate + 1; x++)
            {
                for (int y = cell.YCoordinate - 1; y <= cell.YCoordinate + 1; y++)
                {
                    if (x >= 0 && y >= 0 && x < board.BoardSize && y < board.BoardSize && !(x == cell.XCoordinate && y == cell.YCoordinate ))
                    {
                        surroundingCellsQueue.Enqueue(board.BoardArray[x, y]);
                    }
                }
            }

            return surroundingCellsQueue;
        }
    }

}