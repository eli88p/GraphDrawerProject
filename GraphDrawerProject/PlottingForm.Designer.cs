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
            this.lbl_loc = new System.Windows.Forms.Label();
            this.btn_getCutByX = new System.Windows.Forms.Button();
            this.btn_getCutByY = new System.Windows.Forms.Button();
            this.txt_getCutByX = new System.Windows.Forms.TextBox();
            this.txt_getCutByY = new System.Windows.Forms.TextBox();
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
            this.ilPanel1.Size = new System.Drawing.Size(646, 602);
            this.ilPanel1.TabIndex = 0;
            this.ilPanel1.Timeout = ((uint)(0u));
            this.ilPanel1.Load += new System.EventHandler(this.ilPanel1_Load);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(770, 602);
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
            this.btn_globMax.Size = new System.Drawing.Size(192, 23);
            this.btn_globMax.TabIndex = 2;
            this.btn_globMax.Text = "Mark Global Max";
            this.btn_globMax.UseVisualStyleBackColor = true;
            this.btn_globMax.Click += new System.EventHandler(this.btn_globMax_Click);
            // 
            // btn_globMin
            // 
            this.btn_globMin.Location = new System.Drawing.Point(662, 41);
            this.btn_globMin.Name = "btn_globMin";
            this.btn_globMin.Size = new System.Drawing.Size(192, 23);
            this.btn_globMin.TabIndex = 3;
            this.btn_globMin.Text = "Mark Global Min";
            this.btn_globMin.UseVisualStyleBackColor = true;
            this.btn_globMin.Click += new System.EventHandler(this.btn_globMin_Click);
            // 
            // lbl_loc
            // 
            this.lbl_loc.AutoSize = true;
            this.lbl_loc.Location = new System.Drawing.Point(8, 615);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(48, 13);
            this.lbl_loc.TabIndex = 4;
            this.lbl_loc.Text = "Location";
            // 
            // btn_getCutByX
            // 
            this.btn_getCutByX.Location = new System.Drawing.Point(663, 71);
            this.btn_getCutByX.Name = "btn_getCutByX";
            this.btn_getCutByX.Size = new System.Drawing.Size(85, 20);
            this.btn_getCutByX.TabIndex = 5;
            this.btn_getCutByX.Text = "Section By X:";
            this.btn_getCutByX.UseVisualStyleBackColor = true;
            this.btn_getCutByX.Click += new System.EventHandler(this.btn_getCutByX_Click);
            // 
            // btn_getCutByY
            // 
            this.btn_getCutByY.Location = new System.Drawing.Point(663, 97);
            this.btn_getCutByY.Name = "btn_getCutByY";
            this.btn_getCutByY.Size = new System.Drawing.Size(85, 20);
            this.btn_getCutByY.TabIndex = 6;
            this.btn_getCutByY.Text = "Section By Y:";
            this.btn_getCutByY.UseVisualStyleBackColor = true;
            this.btn_getCutByY.Click += new System.EventHandler(this.btn_getCutByY_Click);
            // 
            // txt_getCutByX
            // 
            this.txt_getCutByX.Location = new System.Drawing.Point(754, 71);
            this.txt_getCutByX.Name = "txt_getCutByX";
            this.txt_getCutByX.Size = new System.Drawing.Size(100, 20);
            this.txt_getCutByX.TabIndex = 7;
            // 
            // txt_getCutByY
            // 
            this.txt_getCutByY.Location = new System.Drawing.Point(754, 97);
            this.txt_getCutByY.Name = "txt_getCutByY";
            this.txt_getCutByY.Size = new System.Drawing.Size(100, 20);
            this.txt_getCutByY.TabIndex = 8;
            // 
            // Plotting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 637);
            this.Controls.Add(this.txt_getCutByY);
            this.Controls.Add(this.txt_getCutByX);
            this.Controls.Add(this.btn_getCutByY);
            this.Controls.Add(this.btn_getCutByX);
            this.Controls.Add(this.lbl_loc);
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
        private System.Windows.Forms.Label lbl_loc;
        private System.Windows.Forms.Button btn_getCutByX;
        private System.Windows.Forms.Button btn_getCutByY;
        private System.Windows.Forms.TextBox txt_getCutByX;
        private System.Windows.Forms.TextBox txt_getCutByY;
    }
}

