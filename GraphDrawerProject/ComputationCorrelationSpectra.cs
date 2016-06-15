using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDrawerProject
{
    public class ComputationCorrelationSpectra
    {
        private double[,] mat;
        private int numOfRows;
        private int numOfCols;

        public int getNumOfRows() { return numOfRows; }
        public int getNumOfCols() { return numOfCols; }

        public ComputationCorrelationSpectra(string path)
        {
            string matStr = FileReader.readFileToString(path);
            mat = FileReader.stringToArray(matStr);
            numOfRows = FileReader.getRowsInMatrix(matStr);
            numOfCols = FileReader.getColsInMatrix(matStr);
        }

        public double[,] syncSpectrun()
        {
            double[,] res = new double[numOfRows * (numOfRows - 1), 3];

            int i = 0;
            for (int x = 0; x < numOfRows; x++)
            {
                for (int y = 0; y < numOfRows; y++)
                {
                    if (x != y)
                    {
                        double sum = 0;
                        for (int k = 1; k < numOfCols; k++)
                        {
                            sum += mat[x, k] * mat[y, k];
                        }
                        sum = sum / (numOfCols - 1);
                        res[i, 0] = mat[x, 0];
                        res[i, 1] = mat[y, 0];
                        res[i, 2] = sum;
                        i++;

                    }
                }
            }

            return res;
        }


    }
}
