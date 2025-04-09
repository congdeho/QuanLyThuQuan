namespace QuanLyThuQuan
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            label1 = new Label();
            label2 = new Label();
            MemName = new TextBox();
            label3 = new Label();
            dateTimePickerMem = new DateTimePicker();
            label4 = new Label();
            DiachiText = new TextBox();
            label5 = new Label();
            AddMemberPic = new PictureBox();
            UploadImgMem = new Button();
            Addmem = new Button();
            ((System.ComponentModel.ISupportInitialize)AddMemberPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(150, 40);
            label1.Name = "label1";
            label1.Size = new Size(273, 40);
            label1.TabIndex = 1;
            label1.Text = "Thim thành viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.8000011F, FontStyle.Bold);
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 2;
            label2.Text = "Tên thành viên:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MemName
            // 
            MemName.Font = new Font("Arial", 14F);
            MemName.Location = new Point(233, 95);
            MemName.Name = "MemName";
            MemName.Size = new Size(281, 34);
            MemName.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.8000011F, FontStyle.Bold);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerMem
            // 
            dateTimePickerMem.CalendarFont = new Font("Arial", 14F);
            dateTimePickerMem.Location = new Point(232, 149);
            dateTimePickerMem.Name = "dateTimePickerMem";
            dateTimePickerMem.Size = new Size(282, 27);
            dateTimePickerMem.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.8000011F, FontStyle.Bold);
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DiachiText
            // 
            DiachiText.Font = new Font("Arial", 14F);
            DiachiText.Location = new Point(233, 204);
            DiachiText.Multiline = true;
            DiachiText.Name = "DiachiText";
            DiachiText.Size = new Size(281, 81);
            DiachiText.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.8000011F, FontStyle.Bold);
            label5.Location = new Point(12, 313);
            label5.Name = "label5";
            label5.Size = new Size(126, 30);
            label5.TabIndex = 8;
            label5.Text = "Hình ảnh:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddMemberPic
            // 
            AddMemberPic.BackColor = SystemColors.ActiveBorder;
            AddMemberPic.ErrorImage = (Image)resources.GetObject("AddMemberPic.ErrorImage");
            AddMemberPic.InitialImage = (Image)resources.GetObject("AddMemberPic.InitialImage");
            AddMemberPic.Location = new Point(232, 313);
            AddMemberPic.Name = "AddMemberPic";
            AddMemberPic.Size = new Size(150, 150);
            AddMemberPic.SizeMode = PictureBoxSizeMode.StretchImage;
            AddMemberPic.TabIndex = 9;
            AddMemberPic.TabStop = false;
            // 
            // UploadImgMem
            // 
            UploadImgMem.Font = new Font("Arial", 10F, FontStyle.Bold);
            UploadImgMem.Location = new Point(17, 419);
            UploadImgMem.Name = "UploadImgMem";
            UploadImgMem.Size = new Size(121, 45);
            UploadImgMem.TabIndex = 10;
            UploadImgMem.Text = "Tải ảnh lên";
            UploadImgMem.UseVisualStyleBackColor = true;
            UploadImgMem.Click += UploadImgMem_Click;
            // 
            // Addmem
            // 
            Addmem.BackColor = SystemColors.Highlight;
            Addmem.Font = new Font("Arial", 13F, FontStyle.Bold);
            Addmem.ForeColor = SystemColors.Info;
            Addmem.Location = new Point(232, 518);
            Addmem.Name = "Addmem";
            Addmem.Size = new Size(121, 45);
            Addmem.TabIndex = 11;
            Addmem.Text = "Thêm";
            Addmem.UseVisualStyleBackColor = false;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 603);
            Controls.Add(Addmem);
            Controls.Add(UploadImgMem);
            Controls.Add(AddMemberPic);
            Controls.Add(label5);
            Controls.Add(DiachiText);
            Controls.Add(label4);
            Controls.Add(dateTimePickerMem);
            Controls.Add(label3);
            Controls.Add(MemName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMember";
            ((System.ComponentModel.ISupportInitialize)AddMemberPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox MemName;
        private Label label3;
        private DateTimePicker dateTimePickerMem;
        private Label label4;
        private TextBox DiachiText;
        private Label label5;
        private PictureBox AddMemberPic;
        private Button UploadImgMem;
        private Button Addmem;
    }
}