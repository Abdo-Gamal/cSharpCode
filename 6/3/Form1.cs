using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
      
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3
{

    public partial class Form1 : Form
    {
        int[] A;
        int[] B;
        public Form1()
        {
            InitializeComponent();
        }
        private void RabAdd_CheckedChanged(object sender, EventArgs e)
        {
            A = poly.String2Int(txtNum1.Lines);
            B = poly.String2Int(txtNum2.Lines);
            if (RabAdd.Checked)
            {
                txtRes.Text = poly.printPoly(poly.add(A, B));
            }

        }
        private void RabSub_CheckedChanged(object sender, EventArgs e)
        {
            A = poly.String2Int(txtNum1.Lines);
            B = poly.String2Int(txtNum2.Lines);

            if (RabSub.Checked)
            {
                txtRes.Text = poly.printPoly(poly.sub(A, B));
            }
        }

        private void RabMult_CheckedChanged(object sender, EventArgs e)
        {
            A = poly.String2Int(txtNum1.Lines);
            B = poly.String2Int(txtNum2.Lines);
            if (RabMult.Checked)
            {
                txtRes.Text = poly.printPoly(poly.multiply(A, B));
            }
        }

        private void RabEval_CheckedChanged(object sender, EventArgs e)
        {
            A = poly.String2Int(txtNum1.Lines);
            int x = 5;
            if (RabEval.Checked)
            {
                txtRes.Text = poly.Eval(A, x).ToString();
            }
        
        }

         private void Form1_Load(object sender, EventArgs e)
         {

         }


    }
 }

