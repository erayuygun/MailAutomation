using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace MailAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                // PDF dosyasının tam yolu
                string pdfPath = @"C:\Users\Example\ExampleCV.pdf";

                // Dosya var mı kontrol et
                if (!File.Exists(pdfPath))
                {
                    MessageBox.Show("CV dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TextBox'lardan veri al
                string firmaAdi = textBoxİsimAl.Text; // Firma adı
                string aliciMail = textBoxMailAl.Text; // Alıcı e-posta adresi

                // E-posta mesajı oluştur
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("example@gmail.com"); // Gönderen e-posta adresi
                mail.To.Add(aliciMail); // Alıcı e-posta adresi
                mail.Subject = "Zorunlu İş Yeri Eğitimi Staj Başvurusu"; // Mail konusu

                // Dinamik mail gövdesi
                mail.Body = $@"Sayın {firmaAdi} Yetkilisi, 
                 

Mail İçeriğiniz.
                    ";





                // Gövdeyi HTML olarak göndermek istiyorsanız aşağıdaki satırı aktif edebilirsiniz
                // mail.IsBodyHtml = true;

                // PDF dosyasını eklenti olarak ekle
                Attachment pdfAttachment = new Attachment(pdfPath);
                mail.Attachments.Add(pdfAttachment);

                // SMTP istemcisi oluştur
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential("example@gmail.com", "**** **** **** ****") // Şifrenizi buraya girin
                };

                // Mail gönder
                smtpClient.Send(mail);

                // Başarı mesajı
                MessageBox.Show("Başvuru maili başarıyla gönderildi!", "İleti Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show("Mail gönderilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}