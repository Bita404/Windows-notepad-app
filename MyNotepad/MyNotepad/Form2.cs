using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad
{
    //  FORM 2 is actually the REPLACE FORM but i forgot to change the name //
    public partial class ReplaceForm : MyNotepad.findform
    {
        Form_Notepad mainForm;
        public ReplaceForm()
        {
            InitializeComponent();
        }
        public ReplaceForm(Form_Notepad mainForm):base(mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //    calling my Functions  //
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            mainForm.replaceFunction(textBoxReplace.Text);
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            StringComparison sc =  StringComparison.OrdinalIgnoreCase;
            if (checkBoxMatchcase.Checked == true)
                sc = StringComparison.Ordinal;
            mainForm.replaceAllFunction(textBoxFind.Text, textBoxReplace.Text, sc, radioButtonDown.Checked);
        }
    }
}
