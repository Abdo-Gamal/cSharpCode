using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbdoGamal
{

    //Here, I have added more than one picture in panl
    //and I also specify their place in the panl
    //and everything related to displaying more than one picture here

    class MulitiPicture 
    {

        public void multiPicturefunc(Panel mypanel, ListBox listOfNameOfPicture,List<string> listOfPathToPicture,int formWidth,bool flag)
        {

            int x = 20, y = 10, curruntmaxhight = -1;

            mypanel.AutoScroll = false;
            mypanel.HorizontalScroll.Enabled = false;
            mypanel.HorizontalScroll.Visible = false;
            mypanel.HorizontalScroll.Maximum = 0;
            mypanel.AutoScroll = true;



            try
            {
                mypanel.Controls.Clear();
           

                if (listOfNameOfPicture.SelectedItems.Count > 0)
                {

                    for (int i = 0; i < listOfNameOfPicture.SelectedItems.Count; i++)
                    {
                        PictureBox curuntPictureAdded = new PictureBox();
                        int idx = listOfNameOfPicture.SelectedIndices[i];
;                        curuntPictureAdded.Image = Image.FromFile(listOfPathToPicture[idx]);
                        curuntPictureAdded.SizeMode = PictureBoxSizeMode.StretchImage;
                        curuntPictureAdded.Location = new Point(x, y);
                        x += curuntPictureAdded.Width + 10;

                       curruntmaxhight = Math.Max(curruntmaxhight, curuntPictureAdded.Height);
                        if (x > mypanel.Width -100)
                        {
                            x = 20;
                            y += curruntmaxhight + 10;
                        }


                        mypanel.Controls.Add(curuntPictureAdded);
                    }

                 

                }
                else
                {
                    if(listOfNameOfPicture.Visible==true&&flag==true)
                    MessageBox.Show("Start to chooce pictur to show it (:.... ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
        }
    }

}
