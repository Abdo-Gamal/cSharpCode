namespace AbdoGamal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modesOfOperation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePictureToolStripMenuI = new System.Windows.Forms.ToolStripMenuItem();
            this.multiPictureToolStripMenuI = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowToolStripMenuI = new System.Windows.Forms.ToolStripMenuItem();
            this.showPictureToolStripMenuI = new System.Windows.Forms.ToolStripMenuItem();
            this.exsitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defautMenueStreip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFolder = new System.Windows.Forms.OpenFileDialog();
            this.statShowNameOfPicture = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusNameOfCurrentPicture = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelForNameOFCurrentPicutr = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerOfSlideShow = new System.Windows.Forms.Timer(this.components);
            this.panelForTopOFProject = new System.Windows.Forms.Panel();
            this.pictureIcone = new System.Windows.Forms.PictureBox();
            this.myNameLable = new System.Windows.Forms.Label();
            this.toolStripForTopOFProject = new System.Windows.Forms.ToolStrip();
            this.StripToolExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonForHideForm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonForFillScreen = new System.Windows.Forms.ToolStripButton();
            this.panelForBtnSlideShow = new System.Windows.Forms.Panel();
            this.panlForSingleAndMultiPlayPictureButtom = new System.Windows.Forms.Panel();
            this.btnClearPanlForMultiPicture = new System.Windows.Forms.Button();
            this.btnClearSlectedItem = new System.Windows.Forms.Button();
            this.btnDeledt = new System.Windows.Forms.Button();
            this.btnGoFront = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnShowSlidePicture = new System.Windows.Forms.Button();
            this.panlForPictureBox = new System.Windows.Forms.Panel();
            this.myPictureBoxViewer = new System.Windows.Forms.PictureBox();
            this.panelInBotomForStatesPar = new System.Windows.Forms.Panel();
            this.listOfNameOfPicture = new System.Windows.Forms.ListBox();
            this.panelForListOfName = new System.Windows.Forms.Panel();
            this.modesOfOperation.SuspendLayout();
            this.statShowNameOfPicture.SuspendLayout();
            this.panelForTopOFProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcone)).BeginInit();
            this.toolStripForTopOFProject.SuspendLayout();
            this.panelForBtnSlideShow.SuspendLayout();
            this.panlForSingleAndMultiPlayPictureButtom.SuspendLayout();
            this.panlForPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBoxViewer)).BeginInit();
            this.panelInBotomForStatesPar.SuspendLayout();
            this.panelForListOfName.SuspendLayout();
            this.SuspendLayout();
            // 
            // modesOfOperation
            // 
            this.modesOfOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.showPictureToolStripMenuI,
            this.exsitToolStripMenuItem});
            this.modesOfOperation.Name = "model";
            this.modesOfOperation.Size = new System.Drawing.Size(170, 92);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openFileToolStripMenuItem.Text = "OpenFile";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlePictureToolStripMenuI,
            this.multiPictureToolStripMenuI,
            this.slideShowToolStripMenuI});
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modelToolStripMenuItem.Text = "Model";
            // 
            // singlePictureToolStripMenuI
            // 
            this.singlePictureToolStripMenuI.Name = "singlePictureToolStripMenuI";
            this.singlePictureToolStripMenuI.Size = new System.Drawing.Size(142, 22);
            this.singlePictureToolStripMenuI.Text = "singlePicture";
            this.singlePictureToolStripMenuI.Click += new System.EventHandler(this.singlepictureToolStripMenuItem_Click);
            // 
            // multiPictureToolStripMenuI
            // 
            this.multiPictureToolStripMenuI.Name = "multiPictureToolStripMenuI";
            this.multiPictureToolStripMenuI.Size = new System.Drawing.Size(142, 22);
            this.multiPictureToolStripMenuI.Text = "MultiPicture";
            this.multiPictureToolStripMenuI.Click += new System.EventHandler(this.MultiPictureToolStripMenuItem_Click);
            // 
            // slideShowToolStripMenuI
            // 
            this.slideShowToolStripMenuI.Name = "slideShowToolStripMenuI";
            this.slideShowToolStripMenuI.Size = new System.Drawing.Size(142, 22);
            this.slideShowToolStripMenuI.Text = "slideShow";
            this.slideShowToolStripMenuI.Click += new System.EventHandler(this.slideShowToolStripMenuItem_Click);
            // 
            // showPictureToolStripMenuI
            // 
            this.showPictureToolStripMenuI.Name = "showPictureToolStripMenuI";
            this.showPictureToolStripMenuI.Size = new System.Drawing.Size(169, 22);
            this.showPictureToolStripMenuI.Text = "show slide picture";
            this.showPictureToolStripMenuI.Visible = false;
            this.showPictureToolStripMenuI.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // exsitToolStripMenuItem
            // 
            this.exsitToolStripMenuItem.Name = "exsitToolStripMenuItem";
            this.exsitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exsitToolStripMenuItem.Text = "Exsit";
            this.exsitToolStripMenuItem.Click += new System.EventHandler(this.exsitFunction);
            // 
            // defautMenueStreip
            // 
            this.defautMenueStreip.Name = "select";
            this.defautMenueStreip.Size = new System.Drawing.Size(61, 4);
            // 
            // openFolder
            // 
            this.openFolder.FileName = "choose some picture(s)";
            this.openFolder.Multiselect = true;
            // 
            // statShowNameOfPicture
            // 
            this.statShowNameOfPicture.AutoSize = false;
            this.statShowNameOfPicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statShowNameOfPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statShowNameOfPicture.BackgroundImage")));
            this.statShowNameOfPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statShowNameOfPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusNameOfCurrentPicture,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelForNameOFCurrentPicutr});
            this.statShowNameOfPicture.Location = new System.Drawing.Point(0, 0);
            this.statShowNameOfPicture.Name = "statShowNameOfPicture";
            this.statShowNameOfPicture.ShowItemToolTips = true;
            this.statShowNameOfPicture.Size = new System.Drawing.Size(921, 21);
            this.statShowNameOfPicture.TabIndex = 8;
            this.statShowNameOfPicture.Text = "wait...";
            // 
            // toolStripStatusNameOfCurrentPicture
            // 
            this.toolStripStatusNameOfCurrentPicture.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusNameOfCurrentPicture.Name = "toolStripStatusNameOfCurrentPicture";
            this.toolStripStatusNameOfCurrentPicture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusNameOfCurrentPicture.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripStatusLabelForNameOFCurrentPicutr
            // 
            this.toolStripStatusLabelForNameOFCurrentPicutr.ActiveLinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelForNameOFCurrentPicutr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabelForNameOFCurrentPicutr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabelForNameOFCurrentPicutr.LinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelForNameOFCurrentPicutr.Name = "toolStripStatusLabelForNameOFCurrentPicutr";
            this.toolStripStatusLabelForNameOFCurrentPicutr.Size = new System.Drawing.Size(64, 16);
            this.toolStripStatusLabelForNameOFCurrentPicutr.Text = "whait ): .....";
            // 
            // timerOfSlideShow
            // 
            this.timerOfSlideShow.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelForTopOFProject
            // 
            this.panelForTopOFProject.Controls.Add(this.pictureIcone);
            this.panelForTopOFProject.Controls.Add(this.myNameLable);
            this.panelForTopOFProject.Controls.Add(this.toolStripForTopOFProject);
            this.panelForTopOFProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForTopOFProject.Location = new System.Drawing.Point(0, 0);
            this.panelForTopOFProject.Name = "panelForTopOFProject";
            this.panelForTopOFProject.Size = new System.Drawing.Size(921, 29);
            this.panelForTopOFProject.TabIndex = 12;
            // 
            // pictureIcone
            // 
            this.pictureIcone.Image = ((System.Drawing.Image)(resources.GetObject("pictureIcone.Image")));
            this.pictureIcone.Location = new System.Drawing.Point(74, 0);
            this.pictureIcone.Name = "pictureIcone";
            this.pictureIcone.Size = new System.Drawing.Size(118, 30);
            this.pictureIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcone.TabIndex = 15;
            this.pictureIcone.TabStop = false;
            // 
            // myNameLable
            // 
            this.myNameLable.AutoSize = true;
            this.myNameLable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.myNameLable.ContextMenuStrip = this.defautMenueStreip;
            this.myNameLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myNameLable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myNameLable.Location = new System.Drawing.Point(191, 6);
            this.myNameLable.Name = "myNameLable";
            this.myNameLable.Size = new System.Drawing.Size(115, 20);
            this.myNameLable.TabIndex = 13;
            this.myNameLable.Text = "Abdo Gamal  (:";
            // 
            // toolStripForTopOFProject
            // 
            this.toolStripForTopOFProject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripForTopOFProject.ContextMenuStrip = this.defautMenueStreip;
            this.toolStripForTopOFProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripForTopOFProject.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripForTopOFProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripToolExit,
            this.toolStripSeparator1,
            this.toolStripButtonForHideForm,
            this.toolStripSeparator2,
            this.toolStripButtonForFillScreen});
            this.toolStripForTopOFProject.Location = new System.Drawing.Point(0, 0);
            this.toolStripForTopOFProject.Name = "toolStripForTopOFProject";
            this.toolStripForTopOFProject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripForTopOFProject.Size = new System.Drawing.Size(921, 29);
            this.toolStripForTopOFProject.TabIndex = 0;
            this.toolStripForTopOFProject.Text = "toolStrip1";
            this.toolStripForTopOFProject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.toolStripForTopOFProject.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.toolStripForTopOFProject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // StripToolExit
            // 
            this.StripToolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StripToolExit.Image = ((System.Drawing.Image)(resources.GetObject("StripToolExit.Image")));
            this.StripToolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StripToolExit.Name = "StripToolExit";
            this.StripToolExit.Size = new System.Drawing.Size(23, 26);
            this.StripToolExit.Text = "toolStripButton1";
            this.StripToolExit.Click += new System.EventHandler(this.exsitFunction);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonForHideForm
            // 
            this.toolStripButtonForHideForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForHideForm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForHideForm.Image")));
            this.toolStripButtonForHideForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForHideForm.Name = "toolStripButtonForHideForm";
            this.toolStripButtonForHideForm.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonForHideForm.Text = "toolStripButton2";
            this.toolStripButtonForHideForm.Click += new System.EventHandler(this.toolStripBtnHide_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonForFillScreen
            // 
            this.toolStripButtonForFillScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonForFillScreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonForFillScreen.Image")));
            this.toolStripButtonForFillScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonForFillScreen.Name = "toolStripButtonForFillScreen";
            this.toolStripButtonForFillScreen.Size = new System.Drawing.Size(23, 26);
            this.toolStripButtonForFillScreen.Text = "toolStripButton3";
            this.toolStripButtonForFillScreen.Click += new System.EventHandler(this.toolStripBtnFillAndNormal_Click);
            // 
            // panelForBtnSlideShow
            // 
            this.panelForBtnSlideShow.Controls.Add(this.panlForSingleAndMultiPlayPictureButtom);
            this.panelForBtnSlideShow.Controls.Add(this.btnShowSlidePicture);
            this.panelForBtnSlideShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForBtnSlideShow.Location = new System.Drawing.Point(0, 29);
            this.panelForBtnSlideShow.Name = "panelForBtnSlideShow";
            this.panelForBtnSlideShow.Size = new System.Drawing.Size(921, 26);
            this.panelForBtnSlideShow.TabIndex = 13;
            // 
            // panlForSingleAndMultiPlayPictureButtom
            // 
            this.panlForSingleAndMultiPlayPictureButtom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panlForSingleAndMultiPlayPictureButtom.Controls.Add(this.btnClearPanlForMultiPicture);
            this.panlForSingleAndMultiPlayPictureButtom.Controls.Add(this.btnClearSlectedItem);
            this.panlForSingleAndMultiPlayPictureButtom.Controls.Add(this.btnDeledt);
            this.panlForSingleAndMultiPlayPictureButtom.Controls.Add(this.btnGoFront);
            this.panlForSingleAndMultiPlayPictureButtom.Controls.Add(this.btnGoBack);
            this.panlForSingleAndMultiPlayPictureButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panlForSingleAndMultiPlayPictureButtom.Location = new System.Drawing.Point(0, 0);
            this.panlForSingleAndMultiPlayPictureButtom.Name = "panlForSingleAndMultiPlayPictureButtom";
            this.panlForSingleAndMultiPlayPictureButtom.Size = new System.Drawing.Size(921, 26);
            this.panlForSingleAndMultiPlayPictureButtom.TabIndex = 15;
            this.panlForSingleAndMultiPlayPictureButtom.Visible = false;
            // 
            // btnClearPanlForMultiPicture
            // 
            this.btnClearPanlForMultiPicture.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearPanlForMultiPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearPanlForMultiPicture.BackgroundImage")));
            this.btnClearPanlForMultiPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearPanlForMultiPicture.ContextMenuStrip = this.defautMenueStreip;
            this.btnClearPanlForMultiPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearPanlForMultiPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearPanlForMultiPicture.Location = new System.Drawing.Point(776, 0);
            this.btnClearPanlForMultiPicture.Name = "btnClearPanlForMultiPicture";
            this.btnClearPanlForMultiPicture.Size = new System.Drawing.Size(77, 26);
            this.btnClearPanlForMultiPicture.TabIndex = 22;
            this.btnClearPanlForMultiPicture.UseVisualStyleBackColor = false;
            this.btnClearPanlForMultiPicture.Click += new System.EventHandler(this.btnClearPlan_Click);
            // 
            // btnClearSlectedItem
            // 
            this.btnClearSlectedItem.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearSlectedItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearSlectedItem.BackgroundImage")));
            this.btnClearSlectedItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearSlectedItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearSlectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearSlectedItem.Location = new System.Drawing.Point(68, 0);
            this.btnClearSlectedItem.Name = "btnClearSlectedItem";
            this.btnClearSlectedItem.Size = new System.Drawing.Size(75, 26);
            this.btnClearSlectedItem.TabIndex = 21;
            this.btnClearSlectedItem.UseVisualStyleBackColor = false;
            this.btnClearSlectedItem.Click += new System.EventHandler(this.btnReselect_Click);
            // 
            // btnDeledt
            // 
            this.btnDeledt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeledt.BackgroundImage")));
            this.btnDeledt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeledt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeledt.Location = new System.Drawing.Point(506, 0);
            this.btnDeledt.Name = "btnDeledt";
            this.btnDeledt.Size = new System.Drawing.Size(68, 29);
            this.btnDeledt.TabIndex = 20;
            this.btnDeledt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeledt.UseVisualStyleBackColor = true;
            this.btnDeledt.Click += new System.EventHandler(this.btnDeletNameOFPicture_Click);
            // 
            // btnGoFront
            // 
            this.btnGoFront.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoFront.BackgroundImage")));
            this.btnGoFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoFront.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGoFront.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoFront.Location = new System.Drawing.Point(853, 0);
            this.btnGoFront.Name = "btnGoFront";
            this.btnGoFront.Size = new System.Drawing.Size(68, 26);
            this.btnGoFront.TabIndex = 19;
            this.btnGoFront.UseVisualStyleBackColor = true;
            this.btnGoFront.Click += new System.EventHandler(this.btnGoFront_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoBack.BackgroundImage")));
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Location = new System.Drawing.Point(0, 0);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(68, 26);
            this.btnGoBack.TabIndex = 18;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnShowSlidePicture
            // 
            this.btnShowSlidePicture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowSlidePicture.ContextMenuStrip = this.defautMenueStreip;
            this.btnShowSlidePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowSlidePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowSlidePicture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowSlidePicture.Location = new System.Drawing.Point(0, 0);
            this.btnShowSlidePicture.Name = "btnShowSlidePicture";
            this.btnShowSlidePicture.Size = new System.Drawing.Size(921, 26);
            this.btnShowSlidePicture.TabIndex = 13;
            this.btnShowSlidePicture.Text = "show slide picture";
            this.btnShowSlidePicture.UseVisualStyleBackColor = false;
            this.btnShowSlidePicture.Visible = false;
            this.btnShowSlidePicture.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panlForPictureBox
            // 
            this.panlForPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panlForPictureBox.BackgroundImage")));
            this.panlForPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panlForPictureBox.ContextMenuStrip = this.modesOfOperation;
            this.panlForPictureBox.Controls.Add(this.myPictureBoxViewer);
            this.panlForPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panlForPictureBox.Location = new System.Drawing.Point(195, 55);
            this.panlForPictureBox.Name = "panlForPictureBox";
            this.panlForPictureBox.Size = new System.Drawing.Size(726, 420);
            this.panlForPictureBox.TabIndex = 14;
            // 
            // myPictureBoxViewer
            // 
            this.myPictureBoxViewer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myPictureBoxViewer.ContextMenuStrip = this.modesOfOperation;
            this.myPictureBoxViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPictureBoxViewer.ErrorImage = null;
            this.myPictureBoxViewer.Image = ((System.Drawing.Image)(resources.GetObject("myPictureBoxViewer.Image")));
            this.myPictureBoxViewer.InitialImage = ((System.Drawing.Image)(resources.GetObject("myPictureBoxViewer.InitialImage")));
            this.myPictureBoxViewer.Location = new System.Drawing.Point(0, 0);
            this.myPictureBoxViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myPictureBoxViewer.Name = "myPictureBoxViewer";
            this.myPictureBoxViewer.Size = new System.Drawing.Size(726, 420);
            this.myPictureBoxViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBoxViewer.TabIndex = 3;
            this.myPictureBoxViewer.TabStop = false;
            // 
            // panelInBotomForStatesPar
            // 
            this.panelInBotomForStatesPar.Controls.Add(this.statShowNameOfPicture);
            this.panelInBotomForStatesPar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInBotomForStatesPar.Location = new System.Drawing.Point(0, 475);
            this.panelInBotomForStatesPar.Name = "panelInBotomForStatesPar";
            this.panelInBotomForStatesPar.Size = new System.Drawing.Size(921, 21);
            this.panelInBotomForStatesPar.TabIndex = 4;
            this.panelInBotomForStatesPar.Visible = false;
            // 
            // listOfNameOfPicture
            // 
            this.listOfNameOfPicture.BackColor = System.Drawing.SystemColors.Window;
            this.listOfNameOfPicture.ContextMenuStrip = this.defautMenueStreip;
            this.listOfNameOfPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfNameOfPicture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listOfNameOfPicture.FormattingEnabled = true;
            this.listOfNameOfPicture.HorizontalScrollbar = true;
            this.listOfNameOfPicture.ItemHeight = 20;
            this.listOfNameOfPicture.Location = new System.Drawing.Point(0, 0);
            this.listOfNameOfPicture.Name = "listOfNameOfPicture";
            this.listOfNameOfPicture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listOfNameOfPicture.ScrollAlwaysVisible = true;
            this.listOfNameOfPicture.Size = new System.Drawing.Size(195, 420);
            this.listOfNameOfPicture.TabIndex = 4;
            this.listOfNameOfPicture.Visible = false;
            this.listOfNameOfPicture.SelectedIndexChanged += new System.EventHandler(this.listOfNameOfPicture_SelectedIndexChanged);
            this.listOfNameOfPicture.SelectedValueChanged += new System.EventHandler(this.listOfNameOfPicture_SelectedValueChanged);
            // 
            // panelForListOfName
            // 
            this.panelForListOfName.Controls.Add(this.listOfNameOfPicture);
            this.panelForListOfName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForListOfName.Location = new System.Drawing.Point(0, 55);
            this.panelForListOfName.Name = "panelForListOfName";
            this.panelForListOfName.Size = new System.Drawing.Size(195, 420);
            this.panelForListOfName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 496);
            this.ContextMenuStrip = this.modesOfOperation;
            this.Controls.Add(this.panlForPictureBox);
            this.Controls.Add(this.panelForListOfName);
            this.Controls.Add(this.panelInBotomForStatesPar);
            this.Controls.Add(this.panelForBtnSlideShow);
            this.Controls.Add(this.panelForTopOFProject);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "play  with   pictures ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.modesOfOperation.ResumeLayout(false);
            this.statShowNameOfPicture.ResumeLayout(false);
            this.statShowNameOfPicture.PerformLayout();
            this.panelForTopOFProject.ResumeLayout(false);
            this.panelForTopOFProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcone)).EndInit();
            this.toolStripForTopOFProject.ResumeLayout(false);
            this.toolStripForTopOFProject.PerformLayout();
            this.panelForBtnSlideShow.ResumeLayout(false);
            this.panlForSingleAndMultiPlayPictureButtom.ResumeLayout(false);
            this.panlForPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBoxViewer)).EndInit();
            this.panelInBotomForStatesPar.ResumeLayout(false);
            this.panelForListOfName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip modesOfOperation;
        private System.Windows.Forms.ContextMenuStrip defautMenueStreip;
        private System.Windows.Forms.ToolStripMenuItem exsitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFolder;
        private System.Windows.Forms.StatusStrip statShowNameOfPicture;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPictureToolStripMenuI;
        private System.Windows.Forms.Timer timerOfSlideShow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusNameOfCurrentPicture;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelForNameOFCurrentPicutr;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowToolStripMenuI;
        private System.Windows.Forms.ToolStripMenuItem multiPictureToolStripMenuI;
        private System.Windows.Forms.ToolStripMenuItem singlePictureToolStripMenuI;
        private System.Windows.Forms.Panel panelForTopOFProject;
        private System.Windows.Forms.ToolStrip toolStripForTopOFProject;
        private System.Windows.Forms.ToolStripButton StripToolExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonForHideForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonForFillScreen;
        private System.Windows.Forms.Label myNameLable;
        private System.Windows.Forms.Panel panelForBtnSlideShow;
        private System.Windows.Forms.Button btnShowSlidePicture;
        private System.Windows.Forms.Panel panelInBotomForStatesPar;
        private System.Windows.Forms.Panel panlForPictureBox;
        private System.Windows.Forms.ListBox listOfNameOfPicture;
        private System.Windows.Forms.Panel panelForListOfName;
        private System.Windows.Forms.PictureBox pictureIcone;
        private System.Windows.Forms.PictureBox myPictureBoxViewer;
        private System.Windows.Forms.Panel panlForSingleAndMultiPlayPictureButtom;
        private System.Windows.Forms.Button btnClearPanlForMultiPicture;
        private System.Windows.Forms.Button btnClearSlectedItem;
        private System.Windows.Forms.Button btnDeledt;
        private System.Windows.Forms.Button btnGoFront;
        private System.Windows.Forms.Button btnGoBack;
    }
}

