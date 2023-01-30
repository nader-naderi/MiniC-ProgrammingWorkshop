namespace AmouzegarTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Open your desired file ... ";

            if(openFile.ShowDialog() == DialogResult.OK) 
            {
                newToolStripButton.PerformClick();

                using (StreamReader streamReader = new StreamReader(openFile.FileName))
                {
                    mainRichTextBox.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file as ... ";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter textToWrite = new StreamWriter(saveFile.FileName);
                textToWrite.Write(mainRichTextBox.Text);
                textToWrite.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Redo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem.PerformClick();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem.PerformClick();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.PerformClick();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my first Text Editor");
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();
        }
    }
}