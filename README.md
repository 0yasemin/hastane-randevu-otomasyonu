# Hastane ve Klinik Randevu Yönetim Sistemi Otomasyonu

Bu proje; Sağlık Bakanlığı Merkezi Hekim Randevu Sistemi (MHRS) mimarisi örnek alınarak, tek bir hastanenin randevu, klinik ve personel süreçlerini dijitalleştirmek amacıyla geliştirilmiş masaüstü tabanlı bir otomasyon sistemidir. 

Proje kapsamında arayüz tasarımı kullanıcı deneyimini ön planda tutacak şekilde sade ve işlevsel tasarlanmış, ilişkisel veri tabanı mimarisi sorunsuz bir şekilde entegre edilmiştir.

---

## Teknolojik Altyapı
* Geliştirme Dili & Ortamı: C# / Visual Studio (Windows Forms)
* Veritabanı Teknolojisi: Microsoft SQL Server (MSSQL) / SSMS

---

## Kullanıcı Rolleri ve Özellikleri
Sistem, roller arası güvenlik ve yetkilendirme standartlarına uygun olarak 3 temel profil üzerinden tasarlanmıştır:

### 1. Yönetici (Admin) Paneli
* Doktor & Klinik Yönetimi: Yeni doktor/klinik kaydı oluşturma, bilgilerini güncelleme ve sistemden silme.
* Yetkilendirme: Sisteme yeni yöneticiler tanımlama ve doktor giriş şifrelerini belirleme.

### 2. Hasta Paneli
* Sade ve kullanıcı dostu arayüz ile güvenli kayıt ve giriş işlemleri.
* Klinik/doktor bilgilerini görüntüleme, randevu oluşturma ve randevu iptal süreçleri.

### 3. Doktor Paneli (Gelecek Versiyon)
* Proje planında yer alan bu modülün, gelecek güncellemelerde işlevsel hale getirilerek sisteme entegre edilmesi planlanmaktadır.
