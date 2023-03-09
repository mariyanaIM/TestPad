using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPad
{
    public partial class Form1 : Form
    {
        private object richTextBoxStreamType;

        public Form1()
        {
            InitializeComponent();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tekstovi fajlove|*.txt|Word files|*.dox,*docx|All files|*.*";
            openFileDialog1.ShowDialog();
            richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.RichText);

            //richTextBox1.LoadFile("C:\\Разработка на софтуер-11дМ\\proba.txt");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Tekstovi fajlove|*.txt|Word files|*.docx|All files|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile("C:\\Разработка на софтуер-11дМ\\proba.txt");
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont= fontDialog1.Font;
            richTextBox1.SelectionColor= fontDialog1.Color;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
    }
}
