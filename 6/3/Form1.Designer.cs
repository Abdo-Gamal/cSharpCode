namespace _3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RabMult = new System.Windows.Forms.RadioButton();
            this.RabEval = new System.Windows.Forms.RadioButton();
            this.RabSub = new System.Windows.Forms.RadioButton();
            this.RabAdd = new System.Windows.Forms.RadioButton();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RabMult);
            this.groupBox1.Controls.Add(this.RabEval);
            this.groupBox1.Controls.Add(this.RabSub);
            this.groupBox1.Controls.Add(this.RabAdd);
            this.groupBox1.Location = new System.Drawing.Point(305, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RabMult
            // 
            this.RabMult.AutoSize = true;
            this.RabMult.Location = new System.Drawing.Point(6, 62);
            this.RabMult.Name = "RabMult";
            this.RabMult.Size = new System.Drawing.Size(44, 17);
            this.RabMult.TabIndex = 3;
            this.RabMult.TabStop = true;
            this.RabMult.Text = "mult";
            this.RabMult.UseVisualStyleBackColor = true;
            this.RabMult.CheckedChanged += new System.EventHandler(this.RabMult_CheckedChanged);
            // 
            // RabEval
            // 
            this.RabEval.AutoSize = true;
            this.RabEval.Location = new System.Drawing.Point(6, 85);
            this.RabEval.Name = "RabEval";
            this.RabEval.Size = new System.Drawing.Size(46, 17);
            this.RabEval.TabIndex = 2;
            this.RabEval.TabStop = true;
            this.RabEval.Text = "Eval";
            this.RabEval.UseVisualStyleBackColor = true;
            this.RabEval.CheckedChanged += new System.EventHandler(this.RabEval_CheckedChanged);
            // 
            // RabSub
            // 
            this.RabSub.AutoSize = true;
            this.RabSub.Location = new System.Drawing.Point(6, 39);
            this.RabSub.Name = "RabSub";
            this.RabSub.Size = new System.Drawing.Size(42, 17);
            this.RabSub.TabIndex = 1;
            this.RabSub.TabStop = true;
            this.RabSub.Text = "sub";
            this.RabSub.UseVisualStyleBackColor = true;
            this.RabSub.CheckedChanged += new System.EventHandler(this.RabSub_CheckedChanged);
            // 
            // RabAdd
            // 
            this.RabAdd.AutoSize = true;
            this.RabAdd.Location = new System.Drawing.Point(6, 16);
            this.RabAdd.Name = "RabAdd";
            this.RabAdd.Size = new System.Drawing.Size(43, 17);
            this.RabAdd.TabIndex = 0;
            this.RabAdd.TabStop = true;
            this.RabAdd.Text = "add";
            this.RabAdd.UseVisualStyleBackColor = true;
            this.RabAdd.CheckedChanged += new System.EventHandler(this.RabAdd_CheckedChanged);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(107, 42);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(162, 172);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(475, 42);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(162, 172);
            this.txtNum2.TabIndex = 3;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(107, 254);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(530, 49);
            this.txtRes.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RabMult;
        private System.Windows.Forms.RadioButton RabEval;
        private System.Windows.Forms.RadioButton RabSub;
        private System.Windows.Forms.RadioButton RabAdd;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtRes;
    }
}

