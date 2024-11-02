namespace BookSystem.WinApp
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
            button1 = new Button();
            bookName_txt = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            price_txt = new TextBox();
            label3 = new Label();
            firstName_txt = new TextBox();
            label4 = new Label();
            lastName_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(581, 136);
            button1.Name = "button1";
            button1.Size = new Size(192, 50);
            button1.TabIndex = 0;
            button1.Text = "Add new book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bookName_txt
            // 
            bookName_txt.BackColor = SystemColors.HighlightText;
            bookName_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookName_txt.ForeColor = SystemColors.Desktop;
            bookName_txt.Location = new Point(22, 50);
            bookName_txt.Name = "bookName_txt";
            bookName_txt.Size = new Size(122, 39);
            bookName_txt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(465, 283);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 3;
            label1.Text = "BookName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 22);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 8;
            label2.Text = "Price";
            // 
            // price_txt
            // 
            price_txt.BackColor = SystemColors.HighlightText;
            price_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price_txt.ForeColor = SystemColors.Desktop;
            price_txt.Location = new Point(172, 50);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(122, 39);
            price_txt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 22);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 10;
            label3.Text = "WriterFirstName";
            // 
            // firstName_txt
            // 
            firstName_txt.BackColor = SystemColors.HighlightText;
            firstName_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName_txt.ForeColor = SystemColors.Desktop;
            firstName_txt.Location = new Point(337, 50);
            firstName_txt.Name = "firstName_txt";
            firstName_txt.Size = new Size(169, 39);
            firstName_txt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 22);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 12;
            label4.Text = "WriterLastName";
            // 
            // lastName_txt
            // 
            lastName_txt.BackColor = SystemColors.HighlightText;
            lastName_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName_txt.ForeColor = SystemColors.Desktop;
            lastName_txt.Location = new Point(561, 50);
            lastName_txt.Name = "lastName_txt";
            lastName_txt.Size = new Size(182, 39);
            lastName_txt.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(805, 442);
            Controls.Add(label4);
            Controls.Add(lastName_txt);
            Controls.Add(label3);
            Controls.Add(firstName_txt);
            Controls.Add(label2);
            Controls.Add(price_txt);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(bookName_txt);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox bookName_txt;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox price_txt;
        private Label label3;
        private TextBox firstName_txt;
        private Label label4;
        private TextBox lastName_txt;
    }
}
