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
    public partial class FormGoTo : Form
    {
        Form_Notepad mainform;

        public FormGoTo()
        {

            InitializeComponent();
        }
        public FormGoTo(Form_Notepad mainform)
        {

            InitializeComponent();
            this.mainform = mainform;
        }

        private void FormGoTo_Load(object sender, EventArgs e)
        {
            textBoxGoto.Text = mainform.GetLines().ToString();
            textBoxGoto.SelectAll();
        }

        private void buttonGoTo_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt16(textBoxGoto.Text) - 1;
            if ( n > mainform.GetLines())
            {
                MessageBox.Show("Out of range");
                textBoxGoto.SelectAll();
                textBoxGoto.Focus();
            }
            else
            {
                mainform.GoToFunction(n);
                this.Close();
            }
        }

    }
}
