namespace inputBox
{
    partial class FractionCal
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
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rdDiv = new System.Windows.Forms.RadioButton();
            this.rdMuns = new System.Windows.Forms.RadioButton();
            this.rdMulti = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Location = new System.Drawing.Point(54, 37);
            this.rdAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(36, 24);
            this.rdAdd.TabIndex = 1;
            this.rdAdd.TabStop = true;
            this.rdAdd.Text = "+";
            this.rdAdd.UseVisualStyleBackColor = true;
            this.rdAdd.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdAdd.Click += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(97, 45);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(246, 324);
            this.txtInput.TabIndex = 2;
            // 
            // rdDiv
            // 
            this.rdDiv.AutoSize = true;
            this.rdDiv.Location = new System.Drawing.Point(54, 165);
            this.rdDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdDiv.Name = "rdDiv";
            this.rdDiv.Size = new System.Drawing.Size(31, 24);
            this.rdDiv.TabIndex = 3;
            this.rdDiv.TabStop = true;
            this.rdDiv.Text = "/";
            this.rdDiv.UseVisualStyleBackColor = true;
            this.rdDiv.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdDiv.Click += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rdMuns
            // 
            this.rdMuns.AutoSize = true;
            this.rdMuns.Location = new System.Drawing.Point(54, 72);
            this.rdMuns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMuns.Name = "rdMuns";
            this.rdMuns.Size = new System.Drawing.Size(32, 24);
            this.rdMuns.TabIndex = 4;
            this.rdMuns.TabStop = true;
            this.rdMuns.Text = "-";
            this.rdMuns.UseVisualStyleBackColor = true;
            this.rdMuns.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdMuns.Click += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rdMulti
            // 
            this.rdMulti.AutoSize = true;
            this.rdMulti.Location = new System.Drawing.Point(54, 129);
            this.rdMulti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMulti.Name = "rdMulti";
            this.rdMulti.Size = new System.Drawing.Size(33, 24);
            this.rdMulti.TabIndex = 5;
            this.rdMulti.TabStop = true;
            this.rdMulti.Text = "*";
            this.rdMulti.UseVisualStyleBackColor = true;
            this.rdMulti.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            this.rdMulti.Click += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdAdd);
            this.panel1.Controls.Add(this.rdMulti);
            this.panel1.Controls.Add(this.rdDiv);
            this.panel1.Controls.Add(this.rdMuns);
            this.panel1.Location = new System.Drawing.Point(407, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 230);
            this.panel1.TabIndex = 6;
            // 
            // FractionCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FractionCal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rdDiv;
        private System.Windows.Forms.RadioButton rdMuns;
        private System.Windows.Forms.RadioButton rdMulti;
        private System.Windows.Forms.Panel panel1;
    }
}

