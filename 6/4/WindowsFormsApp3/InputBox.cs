using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inputBox
{
    public partial class InputBox : Form
    {
       

        public InputBox()
        {
            InitializeComponent();
        }
        string input_text;
        public string ResultText
        {
            get { return input_text; }
            private set { input_text = value; }
        }

        public InputBox(string title, string label_text, string textbox_string)
        {
             InitializeComponent();
            this.Text = title;
            this.lblInputs.Text = label_text;
            this.txtInput.Text = textbox_string;
        }

       
        private void btnOk_Click(object sender, EventArgs e)
        {
            ResultText = txtInput.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

