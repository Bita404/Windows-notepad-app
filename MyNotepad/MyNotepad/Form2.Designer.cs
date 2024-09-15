namespace MyNotepad
{
    partial class ReplaceForm
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
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.labelReplace = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCancel.Location = new System.Drawing.Point(299, 135);
            // 
            // checkBoxMatchcase
            // 
            this.checkBoxMatchcase.Location = new System.Drawing.Point(9, 112);
            // 
            // checkBoxWraparound
            // 
            this.checkBoxWraparound.Location = new System.Drawing.Point(9, 135);
            // 
            // groupBoxDirection
            // 
            this.groupBoxDirection.Location = new System.Drawing.Point(127, 99);
            // 
            // buttonReplace
            // 
            this.buttonReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReplace.Location = new System.Drawing.Point(298, 53);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(79, 35);
            this.buttonReplace.TabIndex = 7;
            this.buttonReplace.Text = "&Replace";
            this.buttonReplace.UseVisualStyleBackColor = false;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonReplaceAll
            // 
            this.buttonReplaceAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonReplaceAll.Location = new System.Drawing.Point(297, 94);
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.Size = new System.Drawing.Size(80, 35);
            this.buttonReplaceAll.TabIndex = 8;
            this.buttonReplaceAll.Text = "Replace &All";
            this.buttonReplaceAll.UseVisualStyleBackColor = false;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(6, 49);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(79, 13);
            this.labelReplace.TabIndex = 9;
            this.labelReplace.Text = "Replace what :";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(97, 46);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(169, 20);
            this.textBoxReplace.TabIndex = 10;
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(390, 175);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.buttonReplaceAll);
            this.Controls.Add(this.buttonReplace);
            this.Name = "ReplaceForm";
            this.Text = "Replace";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.checkBoxMatchcase, 0);
            this.Controls.SetChildIndex(this.checkBoxWraparound, 0);
            this.Controls.SetChildIndex(this.groupBoxDirection, 0);
            this.Controls.SetChildIndex(this.buttonReplace, 0);
            this.Controls.SetChildIndex(this.buttonReplaceAll, 0);
            this.Controls.SetChildIndex(this.labelReplace, 0);
            this.Controls.SetChildIndex(this.textBoxReplace, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonReplaceAll;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.TextBox textBoxReplace;
    }
}
