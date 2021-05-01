using System;
using System.Windows.Forms;
namespace inputBox
{
    public partial class FractionCal : Form
    {
        public FractionCal()
        {
            InitializeComponent();
        }

        private void rd_CheckedChanged(object sender, EventArgs e)
        {
            string[] f1 = txtInput.Lines[0].Split(',');
            string[] f2 = txtInput.Lines[1].Split(',');
            Fraction firstFrac = new Fraction(int.Parse(f1[0]), int.Parse(f1[1]));
            Fraction secondFrac = new Fraction(int.Parse(f2[0]), int.Parse(f2[1]));

           
            if (rdAdd.Checked)
            {
               
                Fraction thirdFrac = firstFrac.Add(secondFrac);
                MessageBox.Show(string.Format($"{thirdFrac.Numerator},{thirdFrac.Denominator}"));
            }
           else if (rdMuns.Checked)
            {
               
                Fraction thirdFrac = firstFrac.Munus(secondFrac);
                MessageBox.Show(string.Format($"{thirdFrac.Numerator},{thirdFrac.Denominator}"));
            }
            else if (rdMulti.Checked)
            {
               
                Fraction thirdFrac = firstFrac.Multiplay(secondFrac);
                MessageBox.Show(string.Format($"{thirdFrac.Numerator},{thirdFrac.Denominator}"));
            }
            else if (rdDiv.Checked)
            {
              
                Fraction thirdFrac = firstFrac.Divided(secondFrac);
                MessageBox.Show(string.Format($"{thirdFrac.Numerator},{thirdFrac.Denominator}"));
            }
        }
    }
}