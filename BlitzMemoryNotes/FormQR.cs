using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

using MaterialSkin.Controls;

using QRCoder;
using static System.Net.Mime.MediaTypeNames;
namespace BlitzMemoryNotes
{
    public partial class FormQR : MaterialForm
    {
        public string TSource { get; set; }
        public string T2L { get; set; }
        public string T1L { get; set; }

        public FormQR()
        {
            InitializeComponent();
        }

        private void FormQR_Load(object sender, EventArgs e)
        {
            try {

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(TSource, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(32);
                        pictureBoxQRCode.Image = qrCodeImage;
                    }
                }
            }
            catch { MessageBox.Show("El texto es demaciado largo", "Error"); }

            try
            {
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(T2L, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(32);
                    pictureBoxQRCode2L.Image = qrCodeImage;
                }
            }
        }
            catch { MessageBox.Show("El texto es demaciado largo","Error"); }
            try
            {
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(T1L, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(32);
                    pictureBoxQRCode1L.Image = qrCodeImage;
                }
            }
            }
            catch { MessageBox.Show("El texto es demaciado largo", "Error"); }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
