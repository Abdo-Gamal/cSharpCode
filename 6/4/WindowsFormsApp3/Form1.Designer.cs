namespace inputBox
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
            this.btnVb = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDesign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVb
            // 
            this.btnVb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVb.Location = new System.Drawing.Point(8, 23);
            this.btnVb.Name = "btnVb";
            this.btnVb.Size = new System.Drawing.Size(205, 30);
            this.btnVb.TabIndex = 0;
            this.btnVb.Text = "btn.VB";
            this.btnVb.UseVisualStyleBackColor = false;
            this.btnVb.Click += new System.EventHandler(this.btnVb_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(8, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "runtime";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDesign
            // 
            this.btnDesign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDesign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesign.Location = new System.Drawing.Point(8, 69);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(205, 29);
            this.btnDesign.TabIndex = 2;
            this.btnDesign.Text = "Design";
            this.btnDesign.UseVisualStyleBackColor = false;
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVb);
            this.panel1.Controls.Add(this.btnDesign);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(177, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 178);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(542, 301);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDesign;
        private System.Windows.Forms.Panel panel1;
    }
}

