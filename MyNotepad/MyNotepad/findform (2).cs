using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class findform : Form
    {
        Form_Notepad mainForm;
        public findform()
        {
            InitializeComponent();
            
        }

        public findform(Form_Notepad mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void findform_Load(object sender, EventArgs e)
        {

        }

        private void buttonFindNext_Click(object sender, EventArgs e)
        {
            StringComparison sc = StringComparison.OrdinalIgnoreCase;
            if (checkBoxMatchcase.Checked == true)
                sc = StringComparison.Ordinal;
            mainForm.findFunction(textBoxFind.Text,sc,radioButtonDown.Checked);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
