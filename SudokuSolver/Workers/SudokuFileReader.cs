using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    // THIS CLASS WILL HELP US READ THE FILE
    /*
    1. create 9x9 matrix
    2. read file
    3. get the row and column using indexes
    4. for each row of the file, get the line
    5. for each line, get the number
    6. use row and col indexes to place numbers within the grid
    */
    internal class SudokuFileReader
    {
        // class that takes in a txt file and returns a multidimensional array of integers
        public int[,] ReadFile(string filename)
        {
            int[,] sudokuBoard = new int[9,9]; // this is initializing a 9x9 array board

            try
            {

                var sudokuBoardLines = File.ReadAllLines(filename);

                int row = 0;
                // FIRST ITERATION: for each line of the board, we need to split the elements
                foreach(var line in sudokuBoardLines)
                {
                    // in each line we need to break each line down, so that we can get the elements
                    string[] sudokuBoardLinesNumbers = line.Split("|").Skip(1).Take(9).ToArray();

                    int col = 0;

                    // SECOND ITERATION: insert the numbers in the rigth row and column -> convert the string to numbers
                    foreach(string num in sudokuBoardLinesNumbers)
                    {
                        sudokuBoard[row, col] = sudokuBoardLinesNumbers.Equals(" ") ? 0 : Convert.ToInt16(num); 
                        col++;
                    }

                    row++;
                }

            } catch (Exception ex)
            {
                throw new Exception($"Something went wrong while reading the file: {ex.Message}");
            }

            return sudokuBoard;
        }
    }
}
