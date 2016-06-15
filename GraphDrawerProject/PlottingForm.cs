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
    public partial class Plotting_Form : Form
    {
        private ComputationCorrelationSpectra comp;
        public Plotting_Form(string filename)
        {
            comp = new ComputationCorrelationSpectra(filename);
            
            InitializeComponent();
        }
        
        
        private void Plotting_Form_Load(object sender, EventArgs e)
        {
            double[,] mat = comp.syncSpectrun();
            ILPlotCube pc = new ILPlotCube(twoDMode: false);
            ILScene scene = new ILScene();
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

          

            ILColormap cm = new ILColormap(Colormaps.Jet);
            ILArray<float> data = cm.Data;
            // replace green keypoint with white
            data["2;1:3"] = 1;
            // write back to colormap
            cm.Data = data;



            // create plot cube  
            scene.Add(new ILPlotCube(twoDMode: false) {
                new ILSurface(XYZ) {

                Wireframe = { Visible = false },
                Children = {
		            // add colorbar to surface
		            new ILColorbar() {
                        Location = new PointF(0.99f,0.01f),
                        Height=1
                    }
                    }
                }
            });

            //var sf = pc.Add(new ILSurface(XYZ), cm);

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
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
