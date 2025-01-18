# MailAutomation
Bu proje, şirketlere otomatik olarak e-posta göndermek için geliştirilmiş bir Windows Forms uygulamasıdır. Uygulama, staj başvurusu yapmak isteyen kullanıcıların belirli bir metin şablonu ve ekli bir PDF dosyası ile e-posta göndermesini sağlar.

## Özellikler
- Şirketlere e-posta göndermek için basit bir arayüz.
- E-posta mesajına **şirket adını** dinamik olarak ekleyebilme.
- PDF formatında CV ekleme özelliği.
- Gönderim sonrası başarılı gönderim bildirim mesajı.

## SMTP
Aşağıdaki adımları takip ederek Gmail hesabınız için bir uygulama şifresi oluşturun (bu, SMTP bağlantısı için gereklidir):
Gmail hesabınıza giriş yapın.
Google Hesabım > Güvenlik kısmına gidin.
İki Adımlı Doğrulama’yı etkinleştirin.
Uygulama Şifreleri kısmına gidin.
Uygulama türü olarak Posta, cihaz türü olarak Windows PC seçin ve bir şifre oluşturun.
Oluşan şifreyi koddaki SMTP şifre bölümüne girin.

## Kullanım
Uygulamayı çalıştırın.
Şirketin e-posta adresini ve adını ilgili alanlara girin.
Eklemek istediğiniz PDF dosyasını seçin.
Gönder butonuna tıklayın.
Gönderim başarıyla gerçekleştiğinde bir bildirim mesajı görüntülenecektir.
