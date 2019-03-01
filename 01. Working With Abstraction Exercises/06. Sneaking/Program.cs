using System;
using System.Linq;

namespace P06_Sneaking
{
    class Sneaking
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];

            int[] samPosition = InitializeMatrix(matrix);

            var directions = Console.ReadLine().ToCharArray();

            foreach (var direction in directions)
            {
                UpdateEnemies(matrix);
                CheckEnemies(matrix);
                SamMoves(direction, matrix, samPosition);
                CheckNikoladze(matrix);
            }                                                            
        }

        private static void CheckNikoladze(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if(matrix[row].Contains('N') && matrix[row].Contains('S'))
                {
                    matrix[row][Array.IndexOf(matrix[row], 'N')] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    PrintMatrix(matrix);
                }
            }
        }

        private static void SamMoves(char direction, char[][] matrix, int[] samPosition)
        {
            switch (direction)
            {
                case 'U':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[--samPosition[0]][samPosition[1]] = 'S';
                    break;
                case 'D':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[++samPosition[0]][samPosition[1]] = 'S';
                    break;
                case 'L':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[samPosition[0]][--samPosition[1]] = 'S';
                    break;
                case 'R':
                    matrix[samPosition[0]][samPosition[1]] = '.';
                    matrix[samPosition[0]][++samPosition[1]] = 'S';
                    break;
                default:
                    break;
            }
        }

        private static void CheckEnemies(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                if(matrix[row].Contains('b') && matrix[row].Contains('S'))
                {
                    if(Array.IndexOf(matrix[row],'b') < Array.IndexOf(matrix[row],'S'))
                    {
                        matrix[row][Array.IndexOf(matrix[row], 'S')] = 'X';
                        Console.WriteLine($"Sam died at {row}, {Array.IndexOf(matrix[row], 'X')}");
                        PrintMatrix(matrix);
                    }
                }
                else if(matrix[row].Contains('d') && matrix[row].Contains('S'))
                {
                    if(Array.IndexOf(matrix[row],'d') > Array.IndexOf(matrix[row],'S'))
                    {
                        matrix[row][Array.IndexOf(matrix[row], 'S')] = 'X';
                        Console.WriteLine($"Sam died at {row}, {Array.IndexOf(matrix[row], 'X')}");
                        PrintMatrix(matrix);
                    }
                }
            }
        }

        private static void PrintMatrix(char[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("",item));
            }

            Environment.Exit(0);
        }

        private static void UpdateEnemies(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'b')
                    {
                        if (row >= 0 && row < matrix.Length && col + 1 >= 0 && col + 1 < matrix[row].Length)
                        {
                            matrix[row][col] = '.';
                            matrix[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            matrix[row][col] = 'd';
                        }
                    }
                    else if (matrix[row][col] == 'd')
                    {
                        if (row >= 0 && row < matrix.Length && col - 1 >= 0 && col - 1 < matrix[row].Length)
                        {
                            matrix[row][col] = '.';
                            matrix[row][col - 1] = 'd';
                        }
                        else
                        {
                            matrix[row][col] = 'b';
                        }
                    }
                }
            }
        }

        private static int[] InitializeMatrix(char[][] matrix)
        {
            int[] coordinates = new int[2];

            for (int row = 0; row < matrix.Length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                matrix[row] = input;

                if (matrix[row].Contains('S'))
                {
                    coordinates = new int[] { row, Array.IndexOf(matrix[row], 'S') };
                }
            }

            return coordinates;
        }
    }       
}
