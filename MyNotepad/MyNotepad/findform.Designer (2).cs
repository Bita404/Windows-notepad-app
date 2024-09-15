namespace MyNotepad
{
    partial class findform
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
            this.label_Find = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxMatchcase = new System.Windows.Forms.CheckBox();
            this.checkBoxWraparound = new System.Windows.Forms.CheckBox();
            this.groupBoxDirection = new System.Windows.Forms.GroupBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.groupBoxDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Find
            // 
            this.label_Find.AutoSize = true;
            this.label_Find.Location = new System.Drawing.Point(12, 21);
            this.label_Find.Name = "label_Find";
            this.label_Find.Size = new System.Drawing.Size(59, 13);
            this.label_Find.TabIndex = 0;
            this.label_Find.Text = "Find what :";
            this.label_Find.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(77, 18);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(189, 20);
            this.textBoxFind.TabIndex = 1;
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.BackColor = System.Drawing.Color.Pink;
            this.buttonFindNext.Location = new System.Drawing.Point(298, 13);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(79, 37);
            this.buttonFindNext.TabIndex = 2;
            this.buttonFindNext.Text = "&find next";
            this.buttonFindNext.UseVisualStyleBackColor = false;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCancel.Location = new System.Drawing.Point(298, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 33);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxMatchcase
            // 
            this.checkBoxMatchcase.AutoSize = true;
            this.checkBoxMatchcase.Location = new System.Drawing.Point(12, 56);
            this.checkBoxMatchcase.Name = "checkBoxMatchcase";
            this.checkBoxMatchcase.Size = new System.Drawing.Size(82, 17);
            this.checkBoxMatchcase.TabIndex = 4;
            this.checkBoxMatchcase.Text = "Match case";
            this.checkBoxMatchcase.UseVisualStyleBackColor = true;
            // 
            // checkBoxWraparound
            // 
            this.checkBoxWraparound.AutoSize = true;
            this.checkBoxWraparound.Location = new System.Drawing.Point(12, 79);
            this.checkBoxWraparound.Name = "checkBoxWraparound";
            this.checkBoxWraparound.Size = new System.Drawing.Size(88, 17);
            this.checkBoxWraparound.TabIndex = 5;
            this.checkBoxWraparound.Text = "Wrap around";
            this.checkBoxWraparound.UseVisualStyleBackColor = true;
            // 
            // groupBoxDirection
            // 
            this.groupBoxDirection.Controls.Add(this.radioButtonDown);
            this.groupBoxDirection.Controls.Add(this.radioButtonUp);
            this.groupBoxDirection.Location = new System.Drawing.Point(126, 47);
            this.groupBoxDirection.Name = "groupBoxDirection";
            this.groupBoxDirection.Size = new System.Drawing.Size(116, 64);
            this.groupBoxDirection.TabIndex = 6;
            this.groupBoxDirection.TabStop = false;
            this.groupBoxDirection.Text = "Direction";
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Checked = true;
            this.radioButtonDown.Location = new System.Drawing.Point(51, 30);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDown.TabIndex = 1;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "Down";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(6, 30);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(39, 17);
            this.radioButtonUp.TabIndex = 0;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Up";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // findform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(390, 114);
            this.Controls.Add(this.groupBoxDirection);
            this.Controls.Add(this.checkBoxWraparound);
            this.Controls.Add(this.checkBoxMatchcase);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFindNext);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label_Find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "findform";
            this.Text = "Find";
            this.Load += new System.EventHandler(this.findform_Load);
            this.groupBoxDirection.ResumeLayout(false);
            this.groupBoxDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFindNext;
        protected System.Windows.Forms.Button buttonCancel;
        protected System.Windows.Forms.CheckBox checkBoxMatchcase;
        protected System.Windows.Forms.CheckBox checkBoxWraparound;
        protected System.Windows.Forms.GroupBox groupBoxDirection;
        protected System.Windows.Forms.TextBox textBoxFind;
        protected System.Windows.Forms.RadioButton radioButtonDown;
        protected System.Windows.Forms.RadioButton radioButtonUp;
        protected System.Windows.Forms.Label label_Find;
    }
}