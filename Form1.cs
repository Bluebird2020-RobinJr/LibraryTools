using System;
using System.Windows.Forms;

namespace LibraryTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            String str = "《" + textBoxBookName.Text + "》" + "_" + 
                         textBoxVersion.Text + "_" + textBoxAuthor.Text + 
                         "_" + textBoxDate.Text + "_" + textBoxResolution.Text + 
                         "_" + textBoxOther.Text;
            textBoxResult.Text = str;
            textBoxResult.Show();
        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }
    }
}
