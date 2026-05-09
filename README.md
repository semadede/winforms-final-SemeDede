# Etkinlik ve Organizasyon Yönetim Otomasyonu

Konser, konferans ve düğün gibi etkinlikleri planlayan bir organizasyon firması için geliştirilmiş Windows Forms masaüstü uygulaması. Mekan rezervasyonları, tedarikçi yönetimi ve bütçe takibini tek bir sistemde birleştirir.

---

## İçindekiler

- [Senaryo Özeti](#senaryo-özeti)
- [Uygulama Mimarisi](#uygulama-mimarisi)
- [Özellikler](#özellikler)
- [Kurulum Adımları](#kurulum-adımları)
- [Kullanım](#kullanım)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [Teknik Detaylar](#teknik-detaylar)

---

## Senaryo Özeti

Bir organizasyon firması; mekan rezervasyonlarını, tedarikçi sözleşmelerini ve bütçe takibini Excel üzerinde yönetmekteydi. Etkinlik gününe yakın eksik teslimler geç fark ediliyordu. Bu uygulama:

- Etkinlik oluşturulduğunda mekan müsaitliğini otomatik kontrol eder
- Her etkinliğe tedarikçi ve görev ataması yapılmasını sağlar
- Bütçeyi gerçekleşen maliyetlerle anlık olarak karşılaştırır
- Etkinlik tamamlandığında müşteriye nihai fatura PDF olarak hazırlar

---

## Uygulama Mimarisi

Uygulama üç ana alt sistemden oluşur ve aralarında kesintisiz veri akışı vardır:

```
┌─────────────────────┐     ┌──────────────────────┐     ┌────────────────────┐
│  Alt Sistem 1       │────▶│  Alt Sistem 2         │────▶│  Alt Sistem 3      │
│  Etkinlik & Mekan   │     │  Tedarikçi & Görev    │     │  Bütçe & Fatura    │
│                     │     │                       │     │                    │
│  - Etkinlik oluştur │     │  - Tedarikçi kayıt    │     │  - Bütçe planlama  │
│  - Mekan envanteri  │     │  - Etkinliğe ata      │     │  - Maliyet girişi  │
│  - Çakışma kontrolü │     │  - Teslim takibi      │     │  - PDF fatura      │
│  - Sözleşme kaydı  │     │  - 48 saat uyarısı    │     │  - Bütçe raporu    │
└─────────────────────┘     └──────────────────────┘     └────────────────────┘
```

### Katmanlı Mimari

```
EtkinlikVeOrganizasyonYonetimi/
├── Forms/          → Kullanıcı arayüzü (UI katmanı)
├── Database/       → Repository sınıfları (veri erişim katmanı)
├── Models/         → Veri modelleri
└── Reports/        → PDF rapor üretimi (iTextSharp)
```

### Formlar Arası Veri Akışı

```
LoginForm
    │
    ▼
AnaForm (Dashboard)
    ├── EtkinlikListeForm ──▶ EtkinlikForm
    ├── MekanListeForm ──────▶ MekanForm
    ├── TedarikciListeForm ──▶ TedarikciForm
    ├── TedarikciAtamaForm
    ├── ButceForm
    ├── FaturaForm ──────────▶ PDF Çıktısı
    └── KullaniciYonetimForm
```

---

## Özellikler

### İş Kuralları

| Kural | Uygulama |
|---|---|
| Mekan çakışma kontrolü | Kurulum süresi dahil tarih-saat çakışması engellenir |
| 48 saat uyarısı | Teslim onayı olmayan tedarikçiler otomatik "Kritik" işaretlenir |
| Bütçe aşımı uyarısı | Gerçekleşen maliyet planlanan bütçenin %15'ini geçince kırmızı uyarı |
| Rol bazlı erişim | Admin tüm işlemleri yapabilir; Kullanıcı sadece kendi etkinliklerini görür |

### Raporlar

- **Müşteri Nihai Fatura PDF** — müşteri bilgileri, sağlanan hizmetler, sözleşme bedeli, imza alanı
- **Bütçe-Gerçekleşme Raporu PDF** — planlanan vs gerçekleşen karşılaştırması, maliyet detayları

---

## Kurulum Adımları

### Gereksinimler

- Windows 10/11
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (.NET Desktop Development workload)
- [SQL Server Express](https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/tr-tr/sql/ssms/download-sql-server-management-studio-ssms)

### 1. Repoyu Klonla

```bash
git clone https://github.com/semadede/winforms-final-SemaDede.git
cd winforms-final-SemaDede
```

### 2. Veritabanını Oluştur

1. SSMS'i aç
2. `.\SQLEXPRESS` sunucusuna **Windows Authentication** ile bağlan
3. Sol panelde **Databases** klasörüne sağ tıkla → **New Database**
4. Veritabanı adı: `EtkinlikYonetimDb` → **OK**
5. Üst menüden **File → Open → File** → repo kökündeki `setup.sql` dosyasını seç
6. **Execute** (`F5`) — tüm tablolar ve örnek veriler oluşur

### 3. Bağlantı Ayarı

`EtkinlikVeOrganizasyonYonetimi/App.config` dosyasındaki bağlantı dizesi:

```xml
<add name="EtkinlikDB"
     connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=EtkinlikYonetimDb;Integrated Security=True;TrustServerCertificate=True;"
     providerName="System.Data.SqlClient" />
```

SQL Server Express farklı bir isimle kurulduysa `Data Source` değerini güncelle.

### 4. NuGet Paketlerini Yükle

Visual Studio'da projeyi aç, **Package Manager Console**'da:

```powershell
Update-Package -reinstall
```

### 5. Çalıştır

`F5` veya **Debug → Start Debugging**

---

## Kullanım

### Giriş Bilgileri (Varsayılan)

| Kullanıcı Adı | Şifre | Rol |
|---|---|---|
| `admin` | `admin123` | Admin |

Admin hesabıyla giriş yapıldığında tüm menüler görünür. Kullanıcı rolüyle giriş yapıldığında yalnızca kendi etkinlikleri listelenir.

### Temel İş Akışı

1. **Mekan ekle** → Mekan Yönetimi
2. **Tedarikçi ekle** → Tedarikçi Listesi
3. **Etkinlik oluştur** → Etkinlik Listesi → Yeni Etkinlik (mekan çakışma kontrolü otomatik yapılır)
4. **Tedarikçi ata** → Tedarikçiye Tedarikçi Ata
5. **Bütçe gir** → Bütçe Yönetimi
6. **PDF oluştur** → Bütçe & Fatura

---

## Teknik Detaylar

### Teknoloji Yığını

| Bileşen | Teknoloji |
|---|---|
| Platform | C# Windows Forms (.NET Framework 4.7.2) |
| Veritabanı | MSSQL (SQL Server Express) |
| ORM | ADO.NET (ham SQL, Repository pattern) |
| PDF | iTextSharp 5.5.13 |
| Kimlik Doğrulama | Windows Authentication (Trusted Connection) |

### Veritabanı Tabloları

| Tablo | Açıklama |
|---|---|
| `Kullanicilar` | Kullanıcı adı, şifre, rol (Admin/Kullanıcı) |
| `Mekanlar` | Mekan adı, kapasite, adres, kurulum süresi |
| `EtkinlikTurleri` | Etkinlik türü tanımları |
| `Kategoriler` | Tedarikçi kategorileri, zorunluluk bilgisi |
| `Tedarikciler` | Firma adı, kategori, telefon, aktiflik durumu |
| `Etkinlikler` | Etkinlik bilgileri, mekan, tarih, müşteri, durum |
| `EtkinlikTedarikciler` | Etkinlik-tedarikçi atamaları, teslim durumu |
| `Butceler` | Planlanan bütçe, yönetici onayı |
| `GerceklesenMaliyetler` | Maliyet açıklaması, tutar, tarih |

### Cascade Delete İlişkileri

- Kullanıcı silinince → bağlı etkinlikler silinir
- Etkinlik silinince → bağlı tedarikçi atamaları ve bütçe silinir
- Bütçe silinince → bağlı gerçekleşen maliyetler silinir
