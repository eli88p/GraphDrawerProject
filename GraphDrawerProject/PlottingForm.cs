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
        private ILArray<double> XYZ;
        ILPlotCube pc;
        ILScene scene = new ILScene();
        
        public Plotting_Form(string filename)
        {
            comp = new ComputationCorrelationSpectra(filename);
            
            InitializeComponent();
        }
        
        
        private void Plotting_Form_Load(object sender, EventArgs e)
        {
            double[,] mat = comp.syncSpectrun();
           
            int rows = mat.Length / 3;

            ILArray<double>[] points = new ILArray<double>[rows];

            for (int i = 0; i < rows; i++)
            {
                points[i] = new double[3] { mat[i, 0], mat[i, 1], mat[i, 2]+0.00045 };

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
            XYZ = ILMath.zeros<double>(2, rows / 2, 3);
            XYZ[":;:;0"] = ZMat;
            XYZ[":;:;1"] = XMat; // X pointinates for every grid point
            XYZ[":;:;2"] = YMat; // Y pointinates for every grid point


            ILColormap cm = new ILColormap(Colormaps.Bone);
            ILArray<float> data = cm.Data;
            // replace green keypoint with white
            data["2;1:3"] = 1;
            // write back to colormap
            cm.Data = data;


            ILSurface sureface = new ILSurface(XYZ)
            {
                Colormap = new ILColormap(data),
                Wireframe = { Visible = false },
                Children = {
		            // add colorbar to surface
		            new ILColorbar() {

                        Location = new PointF(0.99f,0.01f),
                        Height=1
                    }
                    }
            };

            pc = new ILPlotCube(twoDMode: false)
            {
                sureface
            };

            //sureface.MouseEnter += (_s, _a) => {
            //    if (!_a.DirectionUp)
            //        Text = "On Plot - Target: " + _a.Target.ToString();
            //};
            //sureface.MouseLeave += (_s, _a) => {
            //    if (!_a.DirectionUp)
            //        Text = "Off Plot - Target: " + _a.Target.ToString();
            //};

            sureface.MouseMove += (_s, _a) => {
                label1.Text=_a.Location.ToString();
            };

            // create plot cube

            scene.Add(pc);

            //var sf = pc.Add(new ILSurface(XYZ), cm);

            ilPanel1.Scene = scene;
            ilPanel1.Scene.First<ILPlotCube>().Rotation = Matrix4.Rotation(new Vector3(1f, 0.23f, 1f), 0.7f);

           


        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_globMax_Click(object sender, EventArgs e)
        {
            ILArray<float> PosOfMax = Graph.getGlobalMax(XYZ);
            pc.Add(new ILPoints()
            {
                Positions = PosOfMax,
                Size = 10,
            });
            
            ilPanel1.Update();
            ilPanel1.Refresh();
        }

        private void btn_globMin_Click(object sender, EventArgs e)
        {
            ILArray<float> PosOfMin = Graph.getGlobalMin(XYZ);
            pc.Add(new ILPoints()
            {
                Color = Color.Blue,
                Positions = PosOfMin,
                Size = 10,
               
            });

            ilPanel1.Update();
            ilPanel1.Refresh();
        }
    }
}
