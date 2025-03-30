namespace QuanLyThuQuan
{
    partial class UpdateDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDeviceForm));
            button1 = new Button();
            UploadImg = new Button();
            AddDevicePic = new PictureBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)AddDevicePic).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Arial", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(232, 479);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 17;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UploadImg
            // 
            UploadImg.Font = new Font("Arial", 10F, FontStyle.Bold);
            UploadImg.Location = new Point(52, 408);
            UploadImg.Name = "UploadImg";
            UploadImg.Size = new Size(121, 45);
            UploadImg.TabIndex = 16;
            UploadImg.Text = "Tải ảnh lên";
            UploadImg.UseVisualStyleBackColor = true;
            // 
            // AddDevicePic
            // 
            AddDevicePic.BackColor = SystemColors.ActiveBorder;
            AddDevicePic.ErrorImage = (Image)resources.GetObject("AddDevicePic.ErrorImage");
            AddDevicePic.InitialImage = (Image)resources.GetObject("AddDevicePic.InitialImage");
            AddDevicePic.Location = new Point(220, 303);
            AddDevicePic.Name = "AddDevicePic";
            AddDevicePic.Size = new Size(150, 150);
            AddDevicePic.SizeMode = PictureBoxSizeMode.StretchImage;
            AddDevicePic.TabIndex = 15;
            AddDevicePic.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F);
            label4.Location = new Point(52, 306);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 14;
            label4.Text = "Hình ảnh:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(220, 165);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 115);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15F);
            label3.Location = new Point(52, 171);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 12;
            label3.Text = "Mô tả: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(220, 97);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(311, 34);
            textBox1.TabIndex = 11;
            textBox1.Text = "Tên này sẽ dc ấy dô";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F);
            label2.Location = new Point(52, 103);
            label2.Name = "label2";
            label2.Size = new Size(143, 28);
            label2.TabIndex = 10;
            label2.Text = "Tên thiết bị:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 177);
            label1.Location = new Point(159, 25);
            label1.Name = "label1";
            label1.Size = new Size(279, 40);
            label1.TabIndex = 9;
            label1.Text = "Cập nhật thiết bị";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateDeviceForm
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
            Name = "UpdateDeviceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDeviceForm";
            ((System.ComponentModel.ISupportInitialize)AddDevicePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button UploadImg;
        private PictureBox AddDevicePic;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}