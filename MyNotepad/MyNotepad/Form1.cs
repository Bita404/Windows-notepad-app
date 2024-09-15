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
    public partial class Form_Notepad : Form
    {
        string fileName = null;
        Boolean isChanged;

        public Form_Notepad()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();


        }

        private void Set_BG_Color(object sender, EventArgs e)
        {
            TextBox.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem x in backColorToolStripMenuItem.DropDownItems)
                if (x.Text==((ToolStripMenuItem)sender).Text)
                    x.Checked = true;
                else
                    x.Checked = false;
        }

        private void StatusBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusBar1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();

            TextBox.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = TextBox.Font;
            fontDialog1.ShowDialog();
            TextBox.Font = fontDialog1.Font;
        }

        private void Form_Notepad_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form_Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.File.WriteAllText("layout.txt", TextBox.BackColor.Name);
            newToolStripMenuItem_Click_1(null, null);
        }

        private void Form_Notepad_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("layout.txt") == true)
            {
                string s;
                s = System.IO.File.ReadAllText("layout.txt");
                ToolStripMenuItem temp = new ToolStripMenuItem();
                temp.Text = s;
                //TextBox.BackColor = Color.FromName(s);
                Set_BG_Color(temp, null);
            }
            isChanged = false;
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                saveFileDialogmain.DefaultExt = "txt";
                saveFileDialogmain.ShowDialog();
                if (saveFileDialogmain.ShowDialog() == DialogResult.Cancel)
                    return;

                fileName = saveFileDialogmain.FileName;
                this.Text = fileName;
            }
                System.IO.File.WriteAllText(fileName, TextBox.Text);
                isChanged = false;
                

            
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (isChanged == true)
            {
                DialogResult dr;
               dr = MessageBox.Show("Do you want to Save this file ?", "save...", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
            }
            TextBox.Text = "";
            this.Text = "MyNotepad (by S9919314)";
            fileName = null;
            isChanged = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
            openFileDialogmain.Filter = "text File|*.txt|C# source File|*.cs|All Files|*.*";
            if (openFileDialogmain.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialogmain.FileName;
            TextBox.Text = System.IO.File.ReadAllText(fileName);
            isChanged = false;
            this.Text = fileName;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = null;
            saveToolStripMenuItem_Click(null, null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();

            Clipboard.SetText(TextBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectedText = Clipboard.GetText();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        private void cutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
            TextBox.SelectedText = "";
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findform f = new findform();
            f.Show();
        }
    }
}
