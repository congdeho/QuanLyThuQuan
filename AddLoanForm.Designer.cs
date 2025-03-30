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
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listView2 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label18 = new Label();
            label3 = new Label();
            DeviceType = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Arial", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(217, 574);
            button1.Name = "button1";
            button1.Size = new Size(168, 52);
            button1.TabIndex = 26;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(339, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 34);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(52, 117);
            label2.Name = "label2";
            label2.Size = new Size(204, 28);
            label2.TabIndex = 19;
            label2.Text = "Mã người mượn:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 177);
            label1.Location = new Point(153, 33);
            label1.Name = "label1";
            label1.Size = new Size(285, 40);
            label1.TabIndex = 18;
            label1.Text = "Lập phiếu mượn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
            listView2.Font = new Font("Arial", 13F, FontStyle.Bold);
            listView2.Location = new Point(52, 326);
            listView2.Name = "listView2";
            listView2.Size = new Size(470, 227);
            listView2.TabIndex = 28;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã TB";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "";
            columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên thiết bị";
            columnHeader5.Width = 290;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 20F);
            label18.Location = new Point(52, 268);
            label18.Name = "label18";
            label18.Size = new Size(293, 39);
            label18.TabIndex = 27;
            label18.Text = "Danh sách thiết bị ";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F);
            label3.Location = new Point(52, 181);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 29;
            label3.Text = "Chọn thiết bị:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeviceType
            // 
            DeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            DeviceType.Font = new Font("Arial", 14F);
            DeviceType.FormattingEnabled = true;
            DeviceType.Items.AddRange(new object[] { "Chọn ấy đi mẹ", "Sách", "Máy tính bảng", "Tài liệu điện tử", "Máy tính cầm tay" });
            DeviceType.Location = new Point(255, 181);
            DeviceType.Name = "DeviceType";
            DeviceType.Size = new Size(191, 34);
            DeviceType.TabIndex = 30;
            DeviceType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Arial", 13F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Info;
            button2.Location = new Point(470, 176);
            button2.Name = "button2";
            button2.Size = new Size(52, 45);
            button2.TabIndex = 31;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            // 
            // AddLoanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 653);
            Controls.Add(button2);
            Controls.Add(DeviceType);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(label18);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddLoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddLoanForm";
            Load += AddLoanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ListView listView2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label18;
        private Label label3;
        private ComboBox DeviceType;
        private Button button2;
    }
}