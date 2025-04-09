using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void UploadImgMem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image|*.png;*.jpg;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    AddMemberPic.Image = new Bitmap(ofd.FileName);
                }
            }
        }
    }
}
