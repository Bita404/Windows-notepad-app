namespace MyNotepad
{
    partial class FormDelete
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.groupBoxDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(298, 136);
            this.buttonCancel.Size = new System.Drawing.Size(81, 38);
            // 
            // checkBoxMatchcase
            // 
            this.checkBoxMatchcase.Location = new System.Drawing.Point(15, 63);
            // 
            // checkBoxWraparound
            // 
            this.checkBoxWraparound.Location = new System.Drawing.Point(15, 86);
            // 
            // groupBoxDirection
            // 
            this.groupBoxDirection.Location = new System.Drawing.Point(131, 63);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonDelete.Location = new System.Drawing.Point(298, 52);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 37);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDeleteAll.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonDeleteAll.Location = new System.Drawing.Point(299, 92);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(80, 38);
            this.buttonDeleteAll.TabIndex = 8;
            this.buttonDeleteAll.Text = "Delete &All";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(390, 176);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonDelete);
            this.Name = "FormDelete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            this.Controls.SetChildIndex(this.label_Find, 0);
            this.Controls.SetChildIndex(this.textBoxFind, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.checkBoxMatchcase, 0);
            this.Controls.SetChildIndex(this.checkBoxWraparound, 0);
            this.Controls.SetChildIndex(this.groupBoxDirection, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.buttonDeleteAll, 0);
            this.groupBoxDirection.ResumeLayout(false);
            this.groupBoxDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDeleteAll;
    }
}
