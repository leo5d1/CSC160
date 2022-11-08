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
            this.button1 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DoIt
            // 
            this.DoIt.Location = new System.Drawing.Point(529, 407);
            this.DoIt.Name = "DoIt";
            this.DoIt.Size = new System.Drawing.Size(111, 33);
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
            this.txtStuff.Location = new System.Drawing.Point(416, 343);
            this.txtStuff.Name = "txtStuff";
            this.txtStuff.Size = new System.Drawing.Size(150, 31);
            this.txtStuff.TabIndex = 2;
            this.txtStuff.TextChanged += new System.EventHandler(this.txtStuff_TextChanged);
            this.txtStuff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStuff_KeyDown);
            this.txtStuff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStuff_KeyPress);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(781, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cont";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 25;
            this.lb.Items.AddRange(new object[] {
            "Shrek",
            "Bee Movie",
            "Star Wars",
            "Spider-man: Into the Spider-verse",
            "Rocky"});
            this.lb.Location = new System.Drawing.Point(12, 301);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(309, 154);
            this.lb.TabIndex = 5;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 717);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.button1);
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
        private Button button1;
        private ListBox lb;
    }
}