using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Microsoft.VisualBasic;

namespace inputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     


  
        private void btnVb_Click(object sender, EventArgs e)
        {
            //string ib = Microsoft.VisualBasic.Interaction.InputBox("Who are you?", "Title", "HarpyWar", this.Left, this.Top);
            //if (ib.Trim().Length > 0)
            //{
            //    MessageBox.Show(ib);
            //}
            //else
            //{
            //    MessageBox.Show("nothing is entered or Cancel is clicked");
            //}
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            InputBox dialog = new InputBox("Caption Here", "Label Text Here", "Default Textbox String");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.ResultText);
            }
            else
            {
                MessageBox.Show("user cancelled out, do something...");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = "Document 1";
            if (inputDialog.Inputbox("New document", "New document name:", ref value) == DialogResult.OK)
            {
                MessageBox.Show(value);
            }

        }
    }

   
    

}
