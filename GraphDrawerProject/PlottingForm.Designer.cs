namespace GraphDrawerProject
{
    partial class Plotting_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plotting_Form));
            this.ilPanel1 = new ILNumerics.Drawing.ILPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_globMax = new System.Windows.Forms.Button();
            this.btn_globMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ilPanel1
            // 
            this.ilPanel1.Driver = ILNumerics.Drawing.RendererTypes.OpenGL;
            this.ilPanel1.Editor = null;
            this.ilPanel1.Location = new System.Drawing.Point(11, 11);
            this.ilPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ilPanel1.Name = "ilPanel1";
            this.ilPanel1.Rectangle = ((System.Drawing.RectangleF)(resources.GetObject("ilPanel1.Rectangle")));
            this.ilPanel1.ShowUIControls = false;
            this.ilPanel1.Size = new System.Drawing.Size(646, 536);
            this.ilPanel1.TabIndex = 0;
            this.ilPanel1.Timeout = ((uint)(0u));
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(675, 561);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_globMax
            // 
            this.btn_globMax.Location = new System.Drawing.Point(662, 12);
            this.btn_globMax.Name = "btn_globMax";
            this.btn_globMax.Size = new System.Drawing.Size(102, 23);
            this.btn_globMax.TabIndex = 2;
            this.btn_globMax.Text = "Mark Global Max";
            this.btn_globMax.UseVisualStyleBackColor = true;
            this.btn_globMax.Click += new System.EventHandler(this.btn_globMax_Click);
            // 
            // btn_globMin
            // 
            this.btn_globMin.Location = new System.Drawing.Point(662, 41);
            this.btn_globMin.Name = "btn_globMin";
            this.btn_globMin.Size = new System.Drawing.Size(102, 23);
            this.btn_globMin.TabIndex = 3;
            this.btn_globMin.Text = "Mark Global Min";
            this.btn_globMin.UseVisualStyleBackColor = true;
            this.btn_globMin.Click += new System.EventHandler(this.btn_globMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Plotting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_globMin);
            this.Controls.Add(this.btn_globMax);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.ilPanel1);
            this.Name = "Plotting_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plot Graph";
            this.Load += new System.EventHandler(this.Plotting_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ILNumerics.Drawing.ILPanel ilPanel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_globMax;
        private System.Windows.Forms.Button btn_globMin;
        private System.Windows.Forms.Label label1;
    }
}

