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
        undoRedo notepadundoredo = new undoRedo();
        Boolean redoOrundoIsClicked = false;

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
            if (redoOrundoIsClicked == false)
                notepadundoredo.setText(TextBox.Text);
            redoOrundoIsClicked = false;
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
            findform f = new findform(this);
            f.Show(this);
        }
        public Boolean findFunction(string s, StringComparison sc, Boolean searchDown)
        {
            int i;
            if(searchDown ==true)

                i = TextBox.Text.IndexOf(s, TextBox.SelectionStart + TextBox.SelectionLength, sc);
            else
                i = TextBox.Text.LastIndexOf(s, TextBox.SelectionStart + TextBox.SelectionLength, sc);
            if (i== -1)

            {
                MessageBox.Show("cannot find \"" + s + "\"","myNotepad");
                return false;
            }
            else
            {
                TextBox.SelectionStart = i;
                TextBox.SelectionLength = s.Length;
                TextBox.Focus();
                return true;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Text = notepadundoredo.myUndo();
            redoOrundoIsClicked = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Text = notepadundoredo.myRedo();
            redoOrundoIsClicked = true;
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceForm r = new ReplaceForm(this);
            r.Show(this);
        }
        /// <summary>
        /// this function will replace the string with the selected text
        /// </summary>
        /// <param name="str">string will be replace</param>
        public void replaceFunction(string str)
        {
            if (TextBox.SelectionLength > 0)
                TextBox.SelectedText = str;
        }
        /// <summary>
        /// this function will replace all the selected text with the string
        /// </summary>
        /// <param name="str1">the selected text</param>
        /// <param name="str2">the text you want to replace</param>
        /// <param name="sc">big or no</param>
        /// <param name="searchDown">where to search</param>
        public void replaceAllFunction(string str1, string str2, StringComparison sc, Boolean searchDown)
        {
            while (findFunction(str1, sc, searchDown))
                replaceFunction(str2);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete z = new FormDelete(this);
            z.Show(this);
        }
        /// <summary>
        /// this function will removes the selected text
        /// </summary>
        /// <param name="strd"></param>
        public void DeleteFunction(string strd)
        {
            if (TextBox.SelectionLength > 0)
                TextBox.SelectedText = "";
        }
        /// <summary>
        /// this function will delete all the selected texts !!!!!!!!!!!!
        /// </summary>
        /// <param name="strd1">selected text</param>
        /// <param name="sc">big or ...</param>
        /// <param name="searchDown">searching for more same text </param>
        public void DeleteAllFUNction(string strd1 ,StringComparison sc, Boolean searchDown)
        {
            while (findFunction(strd1, sc, searchDown))
                DeleteFunction(strd1);
                

        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoTo f = new FormGoTo(this);
            f.ShowDialog();
        }
        /// <summary>
        /// line num function
        /// </summary>
        /// <returns></returns>
        public int GetLines()
        {
            return TextBox.Lines.Count();
        }
        public void GoToFunction(int x)
        {
            TextBox.SelectionStart = TextBox.GetFirstCharIndexFromLine(x);
        }
        /// <summary>
        /// for enabling items when no need
        /// </summary>
        public void SetEnabled()
        {
            copyToolStripMenuItem.Enabled = Convert.ToBoolean(TextBox.SelectionLength);
            cutToolStripMenuItem.Enabled = TextBox.SelectionLength > 0;
            deleteToolStripMenuItem.Enabled = TextBox.SelectionLength > 0;
            pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
            findToolStripMenuItem.Enabled = TextBox.Text.Length > 0;
            goToToolStripMenuItem.Enabled = TextBox.Text.Length > 0;
            


        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            SetEnabled();
        }
    }
}
