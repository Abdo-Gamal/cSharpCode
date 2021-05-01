namespace WindowsFormsApp1
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.txtRest = new System.Windows.Forms.TextBox();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(175, 257);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(456, 20);
            this.textInput.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd5);
            this.groupBox1.Controls.Add(this.rd4);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Controls.Add(this.rd2);
            this.groupBox1.Controls.Add(this.rd1);
            this.groupBox1.Location = new System.Drawing.Point(296, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "opration";
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(6, 142);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(60, 17);
            this.rd5.TabIndex = 4;
            this.rd5.Text = "lastdigit";
            this.rd5.UseVisualStyleBackColor = true;
            this.rd5.AppearanceChanged += new System.EventHandler(this.RdCheckedChanged);
            this.rd5.CheckedChanged += new System.EventHandler(this.RdCheckedChanged);
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(6, 106);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(44, 17);
            this.rd4.TabIndex = 3;
            this.rd4.Text = "shift";
            this.rd4.UseVisualStyleBackColor = true;
            this.rd4.AppearanceChanged += new System.EventHandler(this.RdCheckedChanged);
            this.rd4.CheckedChanged += new System.EventHandler(this.RdCheckedChanged);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(6, 73);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(39, 17);
            this.rd3.TabIndex = 2;
            this.rd3.Text = "div";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.AppearanceChanged += new System.EventHandler(this.RdCheckedChanged);
            this.rd3.CheckedChanged += new System.EventHandler(this.RdCheckedChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(6, 50);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(57, 17);
            this.rd2.TabIndex = 1;
            this.rd2.Text = "bitwise";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.AppearanceChanged += new System.EventHandler(this.RdCheckedChanged);
            this.rd2.CheckedChanged += new System.EventHandler(this.RdCheckedChanged);
            // 
            // txtRest
            // 
            this.txtRest.Location = new System.Drawing.Point(175, 294);
            this.txtRest.Name = "txtRest";
            this.txtRest.Size = new System.Drawing.Size(456, 20);
            this.txtRest.TabIndex = 5;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(6, 16);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(45, 17);
            this.rd1.TabIndex = 0;
            this.rd1.Text = "mod";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.AppearanceChanged += new System.EventHandler(this.RdCheckedChanged);
            this.rd1.CheckedChanged += new System.EventHandler(this.RdCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRest);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.TextBox txtRest;
        private System.Windows.Forms.RadioButton rd1;
    }
}

