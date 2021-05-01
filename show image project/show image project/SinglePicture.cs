using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbdoGamal
{
    class SinglePicture 
    {
        //  Here everything About shows one picture, 
        //and i show this picture in picturBox




        public void  singlePicturefunc( ListBox listOfNameOfPicture,List<string> listOfPathToPicture,PictureBox pictureBox1,bool flag)
        {

            try
            {
               



                if (listOfNameOfPicture.SelectedItems.Count >= 1)
                {
                  
                    pictureBox1.Image = Image.FromFile(listOfPathToPicture[listOfNameOfPicture.SelectedIndex]);
                }
                else
                {
                    if(listOfNameOfPicture.Visible==true&&flag==true)
                    MessageBox.Show("Start to selected any picture to show it (:....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }
    
    }

}
