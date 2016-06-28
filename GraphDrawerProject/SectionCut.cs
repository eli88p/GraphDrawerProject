using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ILNumerics;
using ILNumerics.Drawing;
using ILNumerics.Drawing.Plotting;

namespace GraphDrawerProject
{
    public partial class SectionCut : Form
    {
        private ILArray<double> XYZ;
        private string secType = "";
        private int secNum = 0;
       
        private ILScene scene = new ILScene();
        public SectionCut(ILArray<double> XYZ,string secType,int secNum)
        {
            InitializeComponent();
            this.XYZ = XYZ;
            this.secType = secType;
            this.secNum = secNum;
        }

        private void SectionCut_Load(object sender, EventArgs e)
        {
            ILArray<float> XY;
            if (secType == "X")
            {
                XY = Graph.getSectionByX(XYZ, this.secNum);
            }
            else
            {
               XY = Graph.getSectionByY(XYZ, this.secNum);
            }
                scene = new ILScene();

                var plotCube = scene.Add(new ILPlotCube
                {
                    // configure x axis
                    Axes = {
	            // disable grid and ticks
	            XAxis = {
                  
                    //Ticks = { Visible = false },
                    Label = { Text=this.secType+" Axis" }
                },
	              // disable y grid only
	              YAxis = {
                    Label = { Text="Z Axis" }
                    },
              }
                });


                plotCube.Add(new ILLinePlot(XY)).Line.Width = 3;



                ilPanel1.Scene = scene;
                ilPanel1.Update();
                ilPanel1.Refresh();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
