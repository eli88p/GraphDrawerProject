using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDrawerProject
{
    public static class FileReader
    {
        
        public static string readFileToString(string path)
        {
            try
            {
                return System.IO.File.ReadAllText(path);
            }
            catch(Exception e)
            {
                LogWriter log = new LogWriter("Error in open file, Exception: "+e.ToString());
            }
            return null;
        }

        public static int getRowsInMatrix(string matrix)
        {
            return matrix.Split('\n').Length;
        }

        public static int getColsInMatrix(string matrix)
        {
            string line = matrix.Split('\n')[0];
            string[] word = line.Split('\t');
            return word.Length;
        }

        public static double[,] stringToArray(string matrix)
        {
            double[,] mat = new double[FileReader.getRowsInMatrix(matrix), FileReader.getColsInMatrix(matrix)];
            string[] line = matrix.Split('\n');
            for (int i = 0; i < FileReader.getRowsInMatrix(matrix); i++)
            {
                string[] word = line[i].Split('\t');
                for (int j = 0; j < word.Length; j++)
                {
                    try
                    {
                        mat[i, j] = Convert.ToDouble(word[j]);
                        
                    }
                    catch(Exception e)
                    {
                        LogWriter log = new LogWriter("Error in cast from file to array with index:["+i.ToString()+"," + j.ToString()+"] " + "Exception: " + e.ToString());
                    }                    
                }
            }
            return mat;
        }
    }
}