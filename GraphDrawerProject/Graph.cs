using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ILNumerics;

namespace GraphDrawerProject
{
    public static class Graph
    {
        public static ILArray<float> toFloatArray(ILArray<double> arr)
        {
            if (arr == null) return null;
            int n = arr.Length;
            ILArray<float> ret = new float[n];
            for (int i = 0; i < n; i++)
            {
                ret[i] = (float)arr[i];
            }
            return ret;
        }

        public static double[] getGlobalMax(ILArray<double> arr)
        {
            double[] point = new double[3];
            double maxValue = (double)arr[":;:;0"][0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[":;:;0"][i] > maxValue)
                {   
                    maxValue = (double)(arr[":;:;0"][i]);
                    point[0] = (double)(arr[":;:;1"][i]);
                    point[1] = (double)(arr[":;:;2"][i]);
                    point[2] = maxValue;
                }
            }

            return point;
        }

        public static double[] getGlobalMin(ILArray<double> arr)
        {
            double[] point = new double[3];
            double minValue = (double)arr[":;:;0"][0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[":;:;0"][i] < minValue)
                {
                    minValue = (double)(arr[":;:;0"][i]);
                    point[0] = (double)(arr[":;:;1"][i]);
                    point[1] = (double)(arr[":;:;2"][i]);
                    point[2] = minValue;
                }
            }

            return point;
        }

    }
}
