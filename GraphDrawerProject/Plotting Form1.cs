using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;

namespace GraphDrawerProject
{
    public partial class Plotting_Form1 : Form
    {
        ComputationCorrelationSpectra comp;
        public Plotting_Form1(ComputationCorrelationSpectra comp)
        {
            this.comp = comp;
            InitializeComponent();
        }

        public Plotting_Form1()
        {
            InitializeComponent();
        }

        // Initial plot setup, modify this as needed
        private void ilPanel1_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Example update function used for dynamic updates to the plot
        /// </summary>
        /// <param name="A">New data, matching the requirements of your plot</param>
        public void Update(ILInArray<double> A)
        {
            using (ILScope.Enter(A))
            {

                // fetch a reference to the plot
                var plot = ilPanel1.Scene.First<ILLinePlot>(tag: "mylineplot");
                if (plot != null)
                {
                    // make sure, to convert elements to float
                    plot.Update(ILMath.tosingle(A));
                    //
                    // ... do more manipulations here ...

                    // finished with updates? -> Call Configure() on the changes 
                    plot.Configure();

                    // cause immediate redraw of the scene
                    ilPanel1.Refresh();
                }

            }
        }

        /// <summary>
        /// Example computing module as private class 
        /// </summary>
        private class Computation : ILMath
        {
            /// <summary>
            /// Create some test data for plotting
            /// </summary>
            /// <param name="ang">end angle for a spiral</param>
            /// <param name="resolution">number of points to plot</param>
            /// <returns>3d data matrix for plotting, points in columns</returns>
            public static ILRetArray<float> CreateData(int ang, int resolution)
            {
                using (ILScope.Enter())
                {
                    ILArray<float> A = linspace<float>(0, ang * pi, resolution);
                    ILArray<float> Pos = zeros<float>(3, A.S[1]);
                    Pos["0;:"] = sin(A);
                    Pos["1;:"] = cos(A);
                    Pos["2;:"] = A;
                    return Pos;
                }
            }

        }

        private void Plotting_Form1_Load(object sender, EventArgs e)
        {
            double[,] mat = comp.syncSpectrun();
            ILPlotCube pc = new ILPlotCube(twoDMode: false);
            ILScene scene = new ILScene { pc };
            int rows = mat.Length / 3;

            ILArray<double>[] points = new ILArray<double>[rows];
            for (int i = 0; i < rows; i++)
            {
                points[i] = new double[3] { mat[i, 0], mat[i, 1], mat[i, 2] };

            }

            //MessageBox.Show(points[0][2].ToString());
            ILArray<double> XMat = ILMath.zeros<double>(2, rows / 2);
            ILArray<double> YMat = ILMath.zeros<double>(2, rows / 2);
            ILArray<double> ZMat = ILMath.zeros<double>(2, rows / 2);
            int x = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < rows / 2; j++)
                {
                    XMat[i, j] = points[x][0];
                    YMat[i, j] = points[x][1];
                    ZMat[i, j] = points[x][2];
                    x++;
                }
            }
            ILArray<double> XYZ = ILMath.zeros<double>(2, rows / 2, 3);
            XYZ[":;:;0"] = ZMat;
            XYZ[":;:;1"] = XMat; // X pointinates for every grid point
            XYZ[":;:;2"] = YMat; // Y pointinates for every grid point

            //// preallocate data array for ILSurface: X by Y by 3
            //// Note the order: 3 matrix slices of X by Y each, for Z,X,Y pointinates of every grid point
            //ILArray<float> XYZ = ILMath.zeros<float>(2, 2, 3);


            //XYZ[":;:;0"] = ZMat;
            //XYZ[":;:;1"] = XMat; // X pointinates for every grid point
            //XYZ[":;:;2"] = YMat; // Y pointinates for every grid point

            ILColormap cm = new ILColormap(Colormaps.Jet);
            ILArray<float> data = cm.Data;
            // replace green keypoint with white
            data["2;1:3"] = 1;
            // write back to colormap
            cm.Data = data;
            // add a new plot cube 



            var sf = pc.Add(new ILSurface(XYZ), cm);

            ilPanel1.Scene = scene;
            ilPanel1.Scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(new Vector3(1f, 0.23f, 1f), 0.7f);

        }

        public ILArray<float> toFloatArray(ILArray<double> arr)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
