namespace QuanLyThuQuan
{
    partial class AddLoanForm
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(125, 30);
            label1.Name = "label1";
            label1.Size = new Size(335, 40);
            label1.TabIndex = 0;
            label1.Text = "Phiếu mượn thiết bị";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.Location = new Point(39, 181);
            label2.Name = "label2";
            label2.Size = new Size(205, 29);
            label2.TabIndex = 1;
            label2.Text = "Chọn sản phửm:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ấy 1", "ấy 2", "ấy đi 3" });
            comboBox1.Location = new Point(272, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 29);
            comboBox1.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Location = new Point(40, 285);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 165);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F);
            button1.Location = new Point(394, 227);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 4;
            button1.Text = "+ Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Arial", 12F);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(195, 475);
            button2.Name = "button2";
            button2.Size = new Size(180, 50);
            button2.TabIndex = 5;
            button2.Text = "Thêm phiếu nhập";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold);
            label3.Location = new Point(40, 109);
            label3.Name = "label3";
            label3.Size = new Size(182, 29);
            label3.TabIndex = 6;
            label3.Text = "Mã thành viên:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 7;
            // 
            // AddLoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddLoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddLoanForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ListView listView1;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
    }
}