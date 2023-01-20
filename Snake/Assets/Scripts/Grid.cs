using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts {
    public class Grid {
        public enum VALUE {
            EMPTY, SNAKE, FOOD
        }

        private VALUE[,] grid;
        private int emptyCellCount;
        public bool IsFull { get { return emptyCellCount == 0; } }
        public int Rows { get { return grid.GetLength(0); } }
        public int Columns { get { return grid.GetLength(1); } }

        public Grid(int rows, int cols) {
            grid = new VALUE[rows, cols];
            for(int i = 0; i < grid.GetLength(0); i++) {
                for(int j = 0; j < grid.GetLength(1); j++) {
                    grid[i, j] = 0;
                }
            }
            this.emptyCellCount = rows * cols;
        }

        public VALUE Get(int row, int col) {
            return grid[row, col];
        }

        public void Set(int row, int col, VALUE val) {
            if(grid[row, col] == 0 && val != 0) {
                emptyCellCount--;
            } else if(grid[row, col] != 0 && val == 0) {
                grid[row, col] = val;
            }
        }

        public Vector2Int GetRandomEmptyCell() {
            Vector2Int[] emptyCells = GetAllCellsMatching(VALUE.EMPTY);
            return emptyCells[Random.Range(0, emptyCells.Length)];
        }

        private Vector2Int[] GetAllCellsMatching(VALUE value) {
            List<Vector2Int> matchingCells = new List<Vector2Int>();
            for(int i = 0; i < grid.GetLength(0); i++) {
                for (int j = 0; j < grid.GetLength(1); j++) {
                    if(this.Get(i,j) == value) {
                        matchingCells.Add(new Vector2Int(i, j));
                    }
                }
            }
            return matchingCells.ToArray();
        }

    }
}