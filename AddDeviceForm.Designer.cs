namespace QuanLyThuQuan
{
    partial class AddDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDeviceForm));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            AddDevicePic = new PictureBox();
            UploadImg = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)AddDevicePic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 177);
            label1.Location = new Point(132, 25);
            label1.Name = "label1";
            label1.Size = new Size(299, 40);
            label1.TabIndex = 0;
            label1.Text = "Thêm mới thiết bị";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(25, 103);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên thiết bị:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(193, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 34);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F);
            label3.Location = new Point(25, 171);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 3;
            label3.Text = "Mô tả: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(193, 165);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 115);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F);
            label4.Location = new Point(25, 306);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 5;
            label4.Text = "Hình ảnh:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // AddDevicePic
            // 
            AddDevicePic.BackColor = SystemColors.ActiveBorder;
            AddDevicePic.ErrorImage = (Image)resources.GetObject("AddDevicePic.ErrorImage");
            AddDevicePic.InitialImage = (Image)resources.GetObject("AddDevicePic.InitialImage");
            AddDevicePic.Location = new Point(193, 303);
            AddDevicePic.Name = "AddDevicePic";
            AddDevicePic.Size = new Size(150, 150);
            AddDevicePic.SizeMode = PictureBoxSizeMode.StretchImage;
            AddDevicePic.TabIndex = 6;
            AddDevicePic.TabStop = false;
            // 
            // UploadImg
            // 
            UploadImg.Font = new Font("Arial", 10F, FontStyle.Bold);
            UploadImg.Location = new Point(25, 408);
            UploadImg.Name = "UploadImg";
            UploadImg.Size = new Size(121, 45);
            UploadImg.TabIndex = 7;
            UploadImg.Text = "Tải ảnh lên";
            UploadImg.UseVisualStyleBackColor = true;
            UploadImg.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Arial", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(231, 484);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 8;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // AddDeviceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 553);
            Controls.Add(button1);
            Controls.Add(UploadImg);
            Controls.Add(AddDevicePic);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDevice";
            Load += AddDevice_Load;
            ((System.ComponentModel.ISupportInitialize)AddDevicePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private PictureBox AddDevicePic;
        private Button UploadImg;
        private Button button1;
    }
}