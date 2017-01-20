using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }
        private void uxOpen_Click(object sender, EventArgs e)
        {
            //when the file option "Open" is clicked it will execute this method of code that will open the OpenDialoge box.

            //if the user tries to access a file it will display a message box saying that file can not be accessed
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Can not open file: " + uxOpenDialog.FileName);
            }

        }

        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            //when the Save As button is clicked on the menu strip it will display the save as dialog box 
          

            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Sorry Can not write to file: " + uxSaveDialog.FileName);
            } 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when the file option "Open" is clicked it will execute this method of code that will open the OpenDialoge box.

            //if the user tries to access a file it will display a message box saying that file can not be accessed
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Can not open file: " + uxOpenDialog.FileName);
            }
        }

        private void uxSaveAs1_Click(object sender, EventArgs e)
        {
            //when the Save As button is clicked on the menu strip it will display the save as dialog box 


            if (uxSaveDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Sorry Can not write to file: " + uxSaveDialog.FileName);
            }
        }
    }
}
