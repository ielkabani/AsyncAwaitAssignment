namespace AsyncAwaitAssignment
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
            label1 = new Label();
            label2 = new Label();
            txtFileName1 = new TextBox();
            txtFileName2 = new TextBox();
            btnBrowse1 = new Button();
            btnBrowse2 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnSubmit = new Button();
            btnExit = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 66);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Book1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(587, 66);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Book2";
            // 
            // txtFileName1
            // 
            txtFileName1.Location = new Point(179, 66);
            txtFileName1.Name = "txtFileName1";
            txtFileName1.Size = new Size(169, 31);
            txtFileName1.TabIndex = 2;
            // 
            // txtFileName2
            // 
            txtFileName2.Location = new Point(669, 66);
            txtFileName2.Name = "txtFileName2";
            txtFileName2.Size = new Size(171, 31);
            txtFileName2.TabIndex = 3;
            // 
            // btnBrowse1
            // 
            btnBrowse1.Location = new Point(363, 66);
            btnBrowse1.Name = "btnBrowse1";
            btnBrowse1.Size = new Size(128, 31);
            btnBrowse1.TabIndex = 4;
            btnBrowse1.Text = "Browse";
            btnBrowse1.UseVisualStyleBackColor = true;
            btnBrowse1.Click += btnBrowse1_Click;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(862, 66);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(111, 32);
            btnBrowse2.TabIndex = 5;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(92, 233);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(416, 254);
            listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(587, 233);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(427, 254);
            listBox2.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(416, 146);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(128, 49);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(564, 146);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 49);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 548);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(btnBrowse2);
            Controls.Add(btnBrowse1);
            Controls.Add(txtFileName2);
            Controls.Add(txtFileName1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFileName1;
        private TextBox txtFileName2;
        private Button btnBrowse1;
        private Button btnBrowse2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnSubmit;
        private Button btnExit;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}
