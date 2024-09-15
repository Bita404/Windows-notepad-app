using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNotepad
{
    // This supposed to be DELETE FORM but I forgot to change the name again //
    public partial class FormDelete : MyNotepad.findform
    {
        Form_Notepad mainForm;
        public FormDelete()
        {
            InitializeComponent();
        }
        public FormDelete(Form_Notepad mainForm) : base(mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            mainForm.DeleteFunction(textBoxFind.Text);
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            StringComparison sc = StringComparison.OrdinalIgnoreCase;
            if (checkBoxMatchcase.Checked == true)
                sc = StringComparison.Ordinal;
            mainForm.DeleteAllFUNction(textBoxFind.Text, sc, radioButtonDown.Checked);
        }
    }
}
