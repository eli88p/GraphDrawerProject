using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDrawerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComputationCorrelationSpectra comp = new ComputationCorrelationSpectra("D:/DATA.DPT");
            double[,] mat= comp.syncSpectrun();
            
            Form plot = new Plotting_Form1(comp);
            plot.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
