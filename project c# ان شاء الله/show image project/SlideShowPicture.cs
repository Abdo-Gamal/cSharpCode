using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbdoGamal
{
    //Here is everything related to the third display system.
    //I tried to apply the things to her studies at the oop and SW


    class ShowSlidePicture 
    {



        public void ShowSlidePictureFun(int i, ListBox listOfNameOfPicture, PictureBox pictureBox1,List<string> listOfPathToPicture,out string statBarShowNameOfPicture)
        {
            try
            {
                

                if (listOfPathToPicture.Count > 0&&i< listOfPathToPicture.Count)
                {

                 
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                  pictureBox1.Image = Image.FromFile(listOfPathToPicture[i]);

                    
                    
                }
                else if( listOfPathToPicture.Count==0)
                {
                    if(listOfNameOfPicture.Visible==true)
                    MessageBox.Show("you do not add any picture ):...");

                }
                else
                {
                    MessageBox.Show("Errors ):...");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            statBarShowNameOfPicture = Path.GetFileName(listOfPathToPicture[i]);

        }



    }
}
