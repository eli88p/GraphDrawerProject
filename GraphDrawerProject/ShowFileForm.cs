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
    public partial class ShowFileForm : Form
    {
        private string fn;
        public ShowFileForm(string filename)
        {
            InitializeComponent();
            this.fn = filename;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowFileForm_Load(object sender, EventArgs e)
        {
            rtb_showFile.Text = FileReader.readFileToString(this.fn);
        }
    }
}
