using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class GameGrid
    {
        // Игровая сетка будет 10*20 (10 строки, 20 столбцы). Сделаем на 2 строки больше, там будет зарождаться блок
        private readonly int[,] grid; // сетка игры представляет собой двумерный массив из строк и столбцов
        public int Rows { get; } // определяем свойство для количество строк

        public int Columns { get; } // для столбцов

        public int this[int r, int c] // индексатор для быстрого доступа к массиву
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameGrid(int rows, int columns) // можем создавать сетку для игры с любыми значениями строк и столбцов
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
        }

        public bool IsInside(int r, int c) // метод проверяет находится ли заданная строка или столбец в игровой сетке
        {
            return r >= 0 && r < Rows && c >= 0 && c < Columns;

        }

        public bool IsEmpty(int r, int c) // проверяет пуста ли данная ячейка или нет
        {
            return IsInside(r,c) && grid[r,c] == 0; // ячейка должна быть в сетке и равна нулю
        }

        public bool IsRowFull(int r) // метод проверяет заполнена ли вся строка
        {
            for(int c = 0; c < Columns; c++)
            {
                if (grid[r, c] == 0)
                    return false;
            }
            return true;
        }

        public bool IsRowEmpty(int r) // проверяет пуста ли строка
        {
            for(int c =0; c < Columns; c++)
            {
                if (grid[r, c] != 0)
                    return false;
            }
            return true;
        }

        private void ClearRow(int r) // метод, который очищает строку, когда она полностью заполнена
        {
            for(int c = 0; c < Columns;c++)
            {
                grid[r, c] = 0;
            }
        }

        private void MoveRowDown(int r, int numRows) // метод, который перемещает строки вниз на определенное количество строк
        {
            for(int c = 0; c < Columns; c++)
            {
                grid[r + numRows, c] = grid[r, c];
                grid[r, c] = 0;
            }
        }
        public int ClearFullRows() // метод очистки полных строк
        {
            int cleared = 0; // количество очищенных строк
            for(int r = Rows - 1; r >= 0; r--) // начинаем с нижней строки
            {
                if(IsRowFull(r))
                {
                    ClearRow(r);
                    cleared++;
                }
                else if(cleared > 0)
                {
                    MoveRowDown(r,cleared);
                }
            }
            return cleared;
        }

    }    
}
