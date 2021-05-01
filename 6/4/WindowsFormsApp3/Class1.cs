using System;
using System.Drawing;
using System.Windows.Forms;

namespace inputBox
{
    public class inputDialog
    {
        public static DialogResult Inputbox(string title, string promptText, ref string value)//func
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.ClientSize = new Size(396, 107);
            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
           return dialogResult;
         }
    }
   
    
}

