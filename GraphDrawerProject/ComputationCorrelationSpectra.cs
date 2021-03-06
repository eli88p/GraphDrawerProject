﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

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

        public double[,] syncSpectrum()
        {
            double[,] res = new double[numOfRows * (numOfRows - 1), 3];
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int i = 0;
            using (StreamWriter txtWriter = File.AppendText(m_exePath + "\\" + "output.txt"))
            {
                txtWriter.Write("************  Sync Spectrum calc at: " + DateTime.Now.ToString() + "****************" + Environment.NewLine);
            }
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
                        
                        try
                        {
                            using (StreamWriter txtWriter = File.AppendText(m_exePath + "\\" + "output.txt"))
                            {
                                txtWriter.Write(res[i-1, 0].ToString() + "\t" + res[i-1, 1].ToString() + "\t" + res[i-1, 2].ToString() + Environment.NewLine);
                            }
                        }
                        catch (Exception ex)
                        {
                            LogWriter log = new LogWriter("Error in write to file - output, Exception: " + ex.ToString());
                        }
                    }
                }
            }
            using (StreamWriter txtWriter = File.AppendText(m_exePath + "\\" + "output.txt"))
            {
                txtWriter.Write("***********************************************************" + Environment.NewLine);
            }

            return res;
        }

        public double[,] asyncSpectrum()
        {
            double[,] res = new double[numOfRows * (numOfRows - 1), 3];
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int i = 0;
            using (StreamWriter txtWriter = File.AppendText(m_exePath + "\\" + "output.txt"))
            {
                txtWriter.Write("************  Async Spectrum calc at: " + DateTime.Now.ToString()+"****************" + Environment.NewLine);
            }
            for (int x = 0; x < numOfRows; x++)
            {
                for (int y = 0; y < numOfRows; y++)
                {
                    if (x != y)
                    {
                        double sum = 0;
                        double temp = 0;
                        for (int k = 1; k < numOfCols; k++)
                        {
                            temp = 0;
                            for (int z = 1; z < numOfCols; z++)
                            {
                                if (k != z)
                                {
                                    temp += ((1 * mat[y, z]) / (Math.PI * (z - k)));
                                }
                            }
                            temp = temp * mat[x,k];
                            sum += temp;    
                        }
                        sum = sum / (numOfCols - 1);
                        res[i, 0] = mat[x, 0];
                        res[i, 1] = mat[y, 0];
                        res[i, 2] = sum;
                        i++;

                        try
                        {
                            using (StreamWriter txtWriter = File.AppendText(m_exePath + "\\" + "output.txt"))
                            {
                                txtWriter.Write(res[i - 1, 0].ToString() + "\t" + res[i - 1, 1].ToString() + "\t" + res[i - 1, 2].ToString() + Environment.NewLine);
                            }
                        }
                        catch (Exception ex)
                        {
                            LogWriter log = new LogWriter("Error in write to file - output, Exception: " + ex.ToString());
                        }
                    }
                }
            }
            using (StreamWriter txtWriter = File.AppendText(m_exePath + "\\" + "output.txt"))
            {
                txtWriter.Write("***********************************************************" + Environment.NewLine);
            }

            return res;
        }
    }
}
