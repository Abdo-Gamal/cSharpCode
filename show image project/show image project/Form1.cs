using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Drawing.Drawing2D;

namespace AbdoGamal
{
    //I tried to apply the things to her studies at the oop and SW

    public partial class Form1 : Form
    {
        public Form1()
        {
            NumberCurruntPicutureInSlideShow = 0;
            PictureSetObject = new PictureSet();
            SinglePictureObject = new SinglePicture();
            MulitiPictureObject = new MulitiPicture();
            ShowSlidePictureObject = new ShowSlidePicture();
            InitializeComponent();
            setUpFunc();


        }
        private int _NumberCurruntPicutureInSlideShow;
        private PictureSet PictureSetObject;
        private SinglePicture SinglePictureObject;
        private MulitiPicture MulitiPictureObject;
        private ShowSlidePicture ShowSlidePictureObject;
        
        public int NumberCurruntPicutureInSlideShow
        {
            get { return _NumberCurruntPicutureInSlideShow; }
            set { _NumberCurruntPicutureInSlideShow = value; }
        }

        //==========================================================================================================
        /// <summary>
        ///Here I am setting the time and some sentences
        /// </summary>
        /// 

        void setUpFunc()
        {
            this.BackColor = Color.DarkGray;
            myPictureBoxViewer.BackColor = Color.DarkGray;
            listOfNameOfPicture.BackColor = Color.DarkGray;

            btnGoFront.BackgroundImageLayout = ImageLayout.Stretch;

        }

        //=============================================================================================================================



        /// <summary>
        /// Here I am opening a file in order to specify the growth of some pictures, 
        /// and in the dark, and with some buttons
        /// </summary>

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {

                openFolder.Multiselect = true;
                PictureSetObject.addPictureNameFunc(openFolder, listOfNameOfPicture);
                if (listOfNameOfPicture.Items.Count >= 1)
                    listOfNameOfPicture.Visible = true;

                if (listOfNameOfPicture.Visible == true && singlePictureToolStripMenuI.Checked == true)
                {
                    btnClearPanlForMultiPicture.Visible = false;
                    btnClearSlectedItem.Visible = false;

                    panlForSingleAndMultiPlayPictureButtom.Visible = true;
                    btnGoBack.Visible = true;
                    btnGoFront.Visible = true;
                    btnDeledt.Visible = true;
                    panlForSingleAndMultiPlayPictureButtom.Refresh();

                }
               else  if (listOfNameOfPicture.Visible == true && multiPictureToolStripMenuI.Checked == true)
                {
                    panlForSingleAndMultiPlayPictureButtom.Visible = true;
                    btnClearPanlForMultiPicture.Visible = true;
                    btnClearSlectedItem.Visible = true;
                    btnGoBack.Visible = false;
                    btnGoFront.Visible = false;
                    btnDeledt.Visible = false;
                    panlForSingleAndMultiPlayPictureButtom.Refresh();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //=============================================================================================================================

        /// <summary>
        /// Here I define some characteristics
        /// regarding the first type of snapping to is display only image units
        /// /// and in the dark, and with some buttons
        /// And  class called to the responsible for displaying the image alone
        /// </summary>


        private void singlepictureToolStripMenuItem_Click(object sender, EventArgs e)
        {

            myPictureBoxViewer.Visible = false;
            listOfNameOfPicture.SelectedItem = null;

            btnShowSlidePicture.Visible = false;
            
            panlForPictureBox.Controls.Clear();
            panlForPictureBox.Controls.Add(myPictureBoxViewer);
            myPictureBoxViewer.Image = myPictureBoxViewer.InitialImage;
            myPictureBoxViewer.Visible = true;

            myPictureBoxViewer.Dock = DockStyle.Fill;

            multiPictureToolStripMenuI.Checked = false;
            slideShowToolStripMenuI.Checked = false;
            singlePictureToolStripMenuI.Checked = true;
            listOfNameOfPicture.SelectionMode = SelectionMode.One;


            if (listOfNameOfPicture.Visible == true && singlePictureToolStripMenuI.Checked == true)
            {
                panlForSingleAndMultiPlayPictureButtom.Visible = true;
                btnGoBack.Visible = true;
                btnGoFront.Visible = true;
                btnDeledt.Visible = true;
                btnClearPanlForMultiPicture.Visible = false;
                btnClearSlectedItem.Visible = false;
                panlForSingleAndMultiPlayPictureButtom.Refresh();
            }


            if (listOfNameOfPicture.Items.Count > 0)
                MessageBox.Show("Start to selected any picture to show it (:....");

            else if (listOfNameOfPicture.Visible == false)
                MessageBox.Show("you should openfolder and add some picture first ");
        }
        private void listOfNameOfPicture_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            if (singlePictureToolStripMenuI.Checked == true)
                SinglePictureObject.singlePicturefunc(listOfNameOfPicture, PictureSetObject.listOfPathToPicture, myPictureBoxViewer,false);

        }


        //=============================================================================================================================

        /// <summary>
        /// Here, I define some characteristics regarding the second type of biting, 
        /// which is to display more than one image, with a hidden fiddle and the back of some buttons.
        /// And  class called to the responsible for displaying the multiImage
        /// </summary>

        private void MultiPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPictureBoxViewer.Visible = true;

            listOfNameOfPicture.SelectedItem = null;
            panlForPictureBox.Controls.Clear();
            myPictureBoxViewer.Visible = false;
            statShowNameOfPicture.Visible = false;
            singlePictureToolStripMenuI.Checked = false;
            slideShowToolStripMenuI.Checked = false;
            showPictureToolStripMenuI.Visible = false;
            btnShowSlidePicture.Visible = false;
            multiPictureToolStripMenuI.Checked = true;

       
            listOfNameOfPicture.SelectionMode = SelectionMode.One;
            listOfNameOfPicture.Refresh();

            listOfNameOfPicture.SelectionMode = SelectionMode.MultiSimple;
            listOfNameOfPicture.Refresh();

            if (listOfNameOfPicture.Items.Count > 0)
                MessageBox.Show("Start to chooce any picture to show it (:....");

            else if (listOfNameOfPicture.Visible == false)
                MessageBox.Show("you should openfolder and add some picture first ");

             if (listOfNameOfPicture.Visible == true && multiPictureToolStripMenuI.Checked == true)
            {
                panlForSingleAndMultiPlayPictureButtom.Visible = true;
                btnClearPanlForMultiPicture.Visible = true;
                btnClearSlectedItem.Visible = true;
                btnGoBack.Visible = false;
                btnGoFront.Visible = false;
                btnDeledt.Visible = false;
                panlForSingleAndMultiPlayPictureButtom.Refresh();

            }

            //  MulitiPictureObject.multiPicturefunc(panlForPictureBox, listOfNameOfPicture, PictureSetObject.listOfPathToPicture, this.Width,true);
        }
        private void listOfNameOfPicture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (multiPictureToolStripMenuI.Checked == true)
            {
                MulitiPictureObject.multiPicturefunc(panlForPictureBox, listOfNameOfPicture, PictureSetObject.listOfPathToPicture, this.Width,false);
            }

        }
        //=============================================================================================================================

        /// <summary>
        /// Here, I define some characteristics regarding the third type of biting, 
        /// which is to display slide show for image, with a hidden fiddle and the back of some buttons.
        /// And  class called to the responsible for displaying the slide show picture
        /// </summary>
        /// 
        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPictureBoxViewer.Visible = false;
         
            panlForPictureBox.Controls.Clear();
            panlForPictureBox.Controls.Add(myPictureBoxViewer);
            myPictureBoxViewer.Image = myPictureBoxViewer.InitialImage;
            myPictureBoxViewer.Dock = DockStyle.Fill;

            panlForSingleAndMultiPlayPictureButtom.Visible = false;
            multiPictureToolStripMenuI.Checked = false;
            singlePictureToolStripMenuI.Checked = false;
            myPictureBoxViewer.Visible = true;
            btnShowSlidePicture.Visible = true;


            listOfNameOfPicture.SelectedItem = null;
            listOfNameOfPicture.SelectionMode = SelectionMode.One;
            
          
                  if (listOfNameOfPicture.Visible == false)
                MessageBox.Show("you should openfolder and add some picture first ");
             if (listOfNameOfPicture.Visible == true)
                MessageBox.Show("if you want show slide show clic on buttom slideShow please (: ");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
              

                if (PictureSetObject.listOfPathToPicture.Count <= NumberCurruntPicutureInSlideShow)
                {
                    panelForListOfName.Visible = true;
                    panelInBotomForStatesPar.Visible = false;
                    myPictureBoxViewer.Image = myPictureBoxViewer.InitialImage;

                    timerOfSlideShow.Stop();
                    NumberCurruntPicutureInSlideShow = 0;
                    this.WindowState = FormWindowState.Normal;
                    toolStripStatusLabelForNameOFCurrentPicutr.Text = "whiat to click on Bottom ):......";
                   



                }
                else 
                {
                        string statBarShowNameOfPictureSTR;
                        ShowSlidePictureObject.ShowSlidePictureFun(NumberCurruntPicutureInSlideShow, listOfNameOfPicture, myPictureBoxViewer, PictureSetObject.listOfPathToPicture, out statBarShowNameOfPictureSTR);
                        NumberCurruntPicutureInSlideShow++;
                        toolStripStatusLabelForNameOFCurrentPicutr.Text = statBarShowNameOfPictureSTR;
                    
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            try
            {

                if (listOfNameOfPicture.Visible == false)
                {
                    MessageBox.Show("you should add some picture and try agian ):....");
                }
                else
                {
                    statShowNameOfPicture.Visible = true;
                    toolStripStatusLabelForNameOFCurrentPicutr.Visible = true;
                    panelInBotomForStatesPar.Visible = true;
                    myPictureBoxViewer.Visible = true;
                    timerOfSlideShow.Interval = (int)(1000 * 0.1f);
                    timerOfSlideShow.Start();

                    if (listOfNameOfPicture.Items.Count > 1)
                    {
                        this.WindowState = FormWindowState.Maximized;
                        panelForListOfName.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //=============================================================================================================================
        /// <summary>
        /// to Exsit from form 

        /// </summary>
        private void exsitFunction(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //=============================================================================================================================
        /// <summary>
        ///To make the form movable
        /// </summary>
        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //========================================================================================================================
        /// <summary>
        ///To make the form fill the screen and return to its original
        /// </summary>
        private void toolStripBtnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            

        }

        private void toolStripBtnFillAndNormal_Click(object sender, EventArgs e)
        {

            if(this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
            this.WindowState = FormWindowState.Maximized;

            if (multiPictureToolStripMenuI.Checked == true)
                MulitiPictureObject.multiPicturefunc(panlForPictureBox, listOfNameOfPicture, PictureSetObject.listOfPathToPicture, this.Width,false);

        }
        //========================================================================================================================
        /// <summary>
        ///To move dowen through the buttons in the boxList
        /// </summary>
        private void btnGoBack_Click(object sender, EventArgs e)
        {

            try
            {

                if (listOfNameOfPicture.Items.Count < 0)
                    MessageBox.Show(" the list is empty ");
               else   if (listOfNameOfPicture.SelectedIndex < 0)
                    listOfNameOfPicture.SelectedIndex = 0;

                else
                {

                    if (listOfNameOfPicture.SelectedIndex == 0)
                        listOfNameOfPicture.SelectedIndex = listOfNameOfPicture.Items.Count - 1;
                    else
                        listOfNameOfPicture.SelectedIndex--;

                    listOfNameOfPicture_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          


        }
        /// <summary>
        ///To move up through the buttons in the boxList
        /// </summary>
        private void btnGoFront_Click(object sender, EventArgs e)
        {
            try
            {

                if (listOfNameOfPicture.Items.Count < 0)
                    MessageBox.Show(" the list is empty ");

             else   if (listOfNameOfPicture.SelectedIndex < 0)
                    listOfNameOfPicture.SelectedIndex = 0;

                else
                {
                    if (listOfNameOfPicture.SelectedIndex == listOfNameOfPicture.Items.Count - 1)
                        listOfNameOfPicture.SelectedIndex = 0;
                    else
                        listOfNameOfPicture.SelectedIndex++;


                    listOfNameOfPicture_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         

        }
        /// <summary>
        ///To deledt name of picture form  boxList
        /// </summary>
        private void btnDeletNameOFPicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (listOfNameOfPicture.Items.Count < 0)
                    MessageBox.Show("you cna not delede as the list is empty");

               else if (listOfNameOfPicture.SelectedIndex < 0)
                    MessageBox.Show("you should selected index first use it if there are element ");
                else
                {
                    int indx = listOfNameOfPicture.SelectedIndex;
                    if (listOfNameOfPicture.SelectedIndex != -1)
                    {
                         listOfNameOfPicture.Items.RemoveAt(indx);
                        PictureSetObject.listOfPathToPicture.RemoveAt(indx);
                        listOfNameOfPicture.Refresh();
                       if (listOfNameOfPicture.Items.Count>=1)
                       listOfNameOfPicture.SelectedIndex= 0;
                       else
                            MessageBox.Show("you cna not delede as the list is empty");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //========================================================================================================================

        /// <summary>
        ///   This is a function to make  all selected name  form listbox unselected
        ///   ans  clear the paln also
        /// </summary>
        private void btnReselect_Click(object sender, EventArgs e)
        {
            listOfNameOfPicture.SelectedItem = null;

            listOfNameOfPicture.SelectionMode = SelectionMode.One;
            listOfNameOfPicture.Refresh();

            listOfNameOfPicture.SelectionMode = SelectionMode.MultiSimple;
        }
        /// <summary>
        ///This is a function to clear all images to in form
        /// </summary>
        private void btnClearPlan_Click(object sender, EventArgs e)
        {
            try
            {

                panlForPictureBox.Controls.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        //========================================================================================================================

    }



}