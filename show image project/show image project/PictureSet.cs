using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbdoGamal
{
    //

    //Here I can also add the name of the image in listBox  as well as the path in the list<string>
    //and everything related to added picture




    public class PictureSet
    {

       public List<string> _listOfPathToPicture;
       public PictureSet()
        {
            _listOfPathToPicture = new List<string>();
        }

        public List<string> listOfPathToPicture
        {
            get { return _listOfPathToPicture; }
            set { _listOfPathToPicture = value; }
        }

        public void addPictureNameFunc(FileDialog openFolder, ListBox listOfNameOfPicture)
        {
            try
            {
                int oldSize = listOfNameOfPicture.Items.Count;

                openFolder.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFolder.Title = "chooce some  picture";
                openFolder.Filter = ".JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif| PNG|*.png";

                if (openFolder.ShowDialog() == DialogResult.OK)
                {
                  

                    foreach (var f in openFolder.FileNames)
                    {

                        string name = Path.GetFileName(f);

                        if (listOfNameOfPicture.Items.Contains(name) == false)
                        {
                            listOfNameOfPicture.Items.Add(name);
                            listOfPathToPicture.Add(f);
                        }

                    }
                }
                int NewSize = listOfNameOfPicture.Items.Count;
                int newAddPictur = NewSize - oldSize;

                if (oldSize == NewSize)
                    MessageBox.Show("you do not selesct any new picture ): ");

                else if (oldSize != NewSize)
                    MessageBox.Show("you  selesct  " + newAddPictur.ToString() + "  new piture  ):....");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        
        }


    }
}
