namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoIt = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtStuff = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DoIt
            // 
            this.DoIt.Location = new System.Drawing.Point(529, 407);
            this.DoIt.Name = "DoIt";
            this.DoIt.Size = new System.Drawing.Size(112, 34);
            this.DoIt.TabIndex = 0;
            this.DoIt.Text = "Do It";
            this.DoIt.UseVisualStyleBackColor = true;
            this.DoIt.Click += new System.EventHandler(this.DoIt_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(179, 222);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "yeet";
            // 
            // txtStuff
            // 
            this.txtStuff.Location = new System.Drawing.Point(416, 344);
            this.txtStuff.Name = "txtStuff";
            this.txtStuff.Size = new System.Drawing.Size(150, 31);
            this.txtStuff.TabIndex = 2;
            this.txtStuff.Text = "Stuff";
            this.txtStuff.TextChanged += new System.EventHandler(this.txtStuff_TextChanged);
            this.txtStuff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStuff_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(826, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 717);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtStuff);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.DoIt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DoIt;
        private Label lblTitle;
        private TextBox txtStuff;
        private CheckBox checkBox1;
    }
}