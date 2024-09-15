namespace MyNotepad
{
    partial class FormGoTo
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
            this.buttonGoTo = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLineNum = new System.Windows.Forms.Label();
            this.textBoxGoto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonGoTo.Location = new System.Drawing.Point(71, 101);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.Size = new System.Drawing.Size(96, 43);
            this.buttonGoTo.TabIndex = 1;
            this.buttonGoTo.Text = "&GoTo";
            this.buttonGoTo.UseVisualStyleBackColor = false;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonCancel.Location = new System.Drawing.Point(211, 101);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 43);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // labelLineNum
            // 
            this.labelLineNum.AutoSize = true;
            this.labelLineNum.Location = new System.Drawing.Point(12, 21);
            this.labelLineNum.Name = "labelLineNum";
            this.labelLineNum.Size = new System.Drawing.Size(73, 13);
            this.labelLineNum.TabIndex = 2;
            this.labelLineNum.Text = "Line Number :";
            // 
            // textBoxGoto
            // 
            this.textBoxGoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxGoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGoto.Location = new System.Drawing.Point(71, 51);
            this.textBoxGoto.Name = "textBoxGoto";
            this.textBoxGoto.Size = new System.Drawing.Size(236, 31);
            this.textBoxGoto.TabIndex = 0;
            // 
            // FormGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(376, 168);
            this.Controls.Add(this.textBoxGoto);
            this.Controls.Add(this.labelLineNum);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonGoTo);
            this.Name = "FormGoTo";
            this.Text = "GoTo";
            this.Load += new System.EventHandler(this.FormGoTo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoTo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLineNum;
        private System.Windows.Forms.TextBox textBoxGoto;
    }
}