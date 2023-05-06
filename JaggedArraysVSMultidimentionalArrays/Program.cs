using System.Xml.Linq;

namespace JaggedArraysVSMultidimentionalArrays
{

    /*
    multidimensional array -> each array has the same length. 
    jagged array (array of arrays) -> each array can be of a different length.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a traditional array
            string[] arrayOfString = {"1", "3"}; // new string[2] OR new string[] {"1", "3"}


            // 1. Jagged Array -> arrays of arrays where each array can have different lenghts
            int[][] jaggedArray = new int[10][]; // initialize a jegged array that can contain 10 arrays

            // initialize the first array within our jagged array
            // jaggedArray[0] get first array, while new int[20] initializes it with a fixed length of 20 elements
            jaggedArray[0] = new int[20];
            jaggedArray[1] = new int[10];
            // jagged array can act as a table-like structure -> elements within the jagged array may not be uniformed

            // 2. Multidimensional array (MATRIX)
            // create a matrix of 10x10 -> jagged array with ten spots and each spot can contain 10 numbers
            // elements in a matrix can be uniformed
            int[,] matrixTable = new int[10, 10];

            // IMPORTANT:
            // with MULTIDIMESIONAL ARRAY we canno't do the same thing we do with JAGGED ARRAYS,
            // but with JAGGED ARRAYS we can do the same thing we do with MULTIDIMENSIONAL ARRAY
            
            // when to use a jugged array and when a matrix (jugged array with table-like structure)?
            // performance -> jagged array: accessing elements is a lot faster (WHY?)
            // readability -> matrix
        }
    }
}