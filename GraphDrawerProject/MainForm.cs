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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      
        private void btn_browse_Click(object sender, EventArgs e)
        {
            openDialog.InitialDirectory = "c:\\";
            openDialog.Filter = "Text Files|*.txt|DPT Files|*.dpt|All Files|*.*";
            openDialog.FilterIndex = 2;
            openDialog.Multiselect = false;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                txt_location.Text = openDialog.FileName;
                btn_gen.Visible = true;
                btn_look.Visible = true;
                cb_syncType.Visible = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_look_Click(object sender, EventArgs e)
        {
            Form showFile = new ShowFileForm(txt_location.Text);
            showFile.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            if (cb_syncType.Text != "")
            {
                Form plotForm = new Plotting_Form(txt_location.Text, cb_syncType.Text.ToString());
                plotForm.Show();

            }
            else
                MessageBox.Show("Please selcet Async/Sync!");
        }
    }
}
