namespace Lab7
{
    partial class Lab7
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
            this.distTxtBox = new System.Windows.Forms.TextBox();
            this.subBttn = new System.Windows.Forms.Button();
            this.distLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // distTxtBox
            // 
            this.distTxtBox.Location = new System.Drawing.Point(85, 116);
            this.distTxtBox.Name = "distTxtBox";
            this.distTxtBox.Size = new System.Drawing.Size(100, 20);
            this.distTxtBox.TabIndex = 0;
            // 
            // subBttn
            // 
            this.subBttn.Location = new System.Drawing.Point(99, 156);
            this.subBttn.Name = "subBttn";
            this.subBttn.Size = new System.Drawing.Size(75, 23);
            this.subBttn.TabIndex = 1;
            this.subBttn.Text = "Submit";
            this.subBttn.UseVisualStyleBackColor = true;
            this.subBttn.Click += new System.EventHandler(this.subBttn_Click);
            // 
            // distLbl
            // 
            this.distLbl.Location = new System.Drawing.Point(43, 81);
            this.distLbl.Name = "distLbl";
            this.distLbl.Size = new System.Drawing.Size(186, 32);
            this.distLbl.TabIndex = 2;
            this.distLbl.Text = "Enter the distance you wish to travel (whole miles)";
            this.distLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.distLbl);
            this.Controls.Add(this.subBttn);
            this.Controls.Add(this.distTxtBox);
            this.Name = "Lab7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox distTxtBox;
        private System.Windows.Forms.Button subBttn;
        private System.Windows.Forms.Label distLbl;
    }
}

