using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //   OddEven   عشان تستخدامة لازم تخلى اسم النايم سبيس نفسو او تعمل  اد رفرنس
        private void Form1_Load(object sender, EventArgs e)
        {
            //rd1.CheckedChanged += new System.EventHandler(RdCheckedChanged);
            //rd2.CheckedChanged += new System.EventHandler(RdCheckedChanged);
            //rd3.CheckedChanged += new System.EventHandler(RdCheckedChanged);
            //rd4.CheckedChanged += new System.EventHandler(RdCheckedChanged);
            //rd5.CheckedChanged += new System.EventHandler(RdCheckedChanged);
        }


        private void RdCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            string R;
            if (rd.Checked)
            {
                switch (rd.Name)
                {
                    case "rd1":
                        int x = int.Parse(textInput.Text);
                        OddEven.mod(x, out R);
                        txtRest.Text = string.Format($"The number {x} is {R}");
                        break;
                    case "rd2":
                        x = int.Parse(textInput.Text);
                        OddEven.BitWise(x, out R);
                        txtRest.Text = string.Format($"The number {x} is {R}");
                        break;
                    case "rd3":
                        x = int.Parse(textInput.Text);
                        OddEven.div(x, out R);
                        txtRest.Text = string.Format($"The number {x} is {R}");
                        break;
                    case "rd4":
                        x = int.Parse(textInput.Text);
                        OddEven.shift(x, out R);
                        txtRest.Text = string.Format($"The number {x} is {R}");
                        break;
                    case "rd5":
                        x = int.Parse(textInput.Text);
                        OddEven.LastDigit(x, out R);
                        txtRest.Text = string.Format($"The number {x} is {R}");
                        break;
                }



            }
        }

        private void txtRest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}