namespace GraphDrawerProject
{
    partial class MainForm
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
            this.btn_gen = new System.Windows.Forms.Button();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_look = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(271, 129);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(100, 23);
            this.btn_gen.TabIndex = 1;
            this.btn_gen.Text = "Generate Graph";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Visible = false;
            this.btn_gen.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_location
            // 
            this.txt_location.Enabled = false;
            this.txt_location.Location = new System.Drawing.Point(12, 59);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(278, 20);
            this.txt_location.TabIndex = 2;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(296, 59);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 3;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_look
            // 
            this.btn_look.Location = new System.Drawing.Point(190, 129);
            this.btn_look.Name = "btn_look";
            this.btn_look.Size = new System.Drawing.Size(75, 23);
            this.btn_look.TabIndex = 4;
            this.btn_look.Text = "Look on file";
            this.btn_look.UseVisualStyleBackColor = true;
            this.btn_look.Visible = false;
            this.btn_look.Click += new System.EventHandler(this.btn_look_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(296, 189);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 224);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_look);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.btn_gen);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_look;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.Button btn_close;
    }
}

