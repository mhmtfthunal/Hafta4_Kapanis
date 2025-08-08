# Hafta4 Kapanış

Bu proje, bir teknoloji mağazasında **Telefon** ve **Bilgisayar** kayıtlarını alan bir konsol uygulamasıdır. Çalışma mantığı Object-Oriented Programming (OOP) prensiplerini kullanır:

* **Inheritance (Kalıtım)**
* **Encapsulation (Kapsülleme)**
* **Polymorphism (Çok Biçimlilik)**
* **Abstraction (Soyutlama)**

---

## 🎯 Amaç

* Ortak özellikleri **BaseMakine** soyut sınıfında toplamak.
* **Telefon** ve **Bilgisayar** sınıflarını BaseMakine’den türetmek.
* Encapsulation ile Bilgisayar’ın `UsbGirisSayisi` özelliğini 2 veya 4 ile sınırlamak, aksi durumda uyarı verip `-1` atamak.
* Üretim tarihini nesne oluşturulduğu anda otomatik atamak.
* Polymorphism ile `BilgileriYazdir()` metodunu alt sınıflarda genişletmek.
* Abstraction ile `UrunAdiGetir()` metodunu her alt sınıfta özelleştirmek.

---

## 📁 Proje Yapısı

```
Hafta4_Kapanis/
 ├─ Program.cs          → Program akışı, menü, kullanıcıdan veri alma
 ├─ BaseMakine.cs       → Soyut base class, ortak özellikler ve metotlar
 ├─ Telefon.cs          → Telefon class, TR lisanslı bilgisi ekler
 └─ Bilgisayar.cs       → Bilgisayar class, USB giriş sayısı + Bluetooth ekler
```

---

## 🚀 Çalıştırma Adımları

1. .NET 6+ yüklü olduğundan emin ol.
2. Proje klasöründe `dotnet run` komutunu çalıştır.
3. Menüden **1** (Telefon) veya **2** (Bilgisayar) seç.
4. Konsoldaki yönergeleri takip ederek ürün bilgilerini gir.
5. Ürün başarıyla oluşturulduğunda bilgileri ekranda gör.
6. İstediğinde başka ürün eklemeye devam et veya çık.

---

## 🧠 OOP Kullanımı

* **Inheritance**: Telefon ve Bilgisayar, BaseMakine’den miras alır.
* **Encapsulation**: Bilgisayar’ın `UsbGirisSayisi` özelliği kontrollü olarak atanır.
* **Polymorphism**: `BilgileriYazdir()` base’de temel bilgileri, alt sınıflarda ek özellikleri yazar.
* **Abstraction**: `UrunAdiGetir()` her alt sınıfta kendi mesajını döner.

---

## 🖨️ Örnek Konsol Diyaloğu

```
=== Teknoloji Mağazası Ürün Üretim ===
Telefon üretmek için: 1
Bilgisayar üretmek için: 2
Seçiminiz: 1

Seri Numarası: T12345
Ad: Galaxy S25
Açıklama (boş geçilebilir): Yeni model
İşletim Sistemi: Android
TR Lisanslı mı? (E/H): E

✔ Ürün başarıyla üretildi: TELEFON
=== Ürün Bilgileri ===
Üretim Tarihi   : 2025-08-09 15:32:10
Seri Numarası   : T12345
Ad              : Galaxy S25
Açıklama        : Yeni model
İşletim Sistemi : Android
TR Lisanslı     : Evet
Telefonunuzun adı ---> Galaxy S25

Başka bir ürün üretmek ister misiniz? (E/H): H
İyi günler!
```

---

## 🔧 Genişletme Fikirleri

* Ürünleri bir `List<BaseMakine>` içinde saklayıp program sonunda hepsini listelemek.
* Ürünleri dosyaya veya veritabanına kaydetmek.
* Arayüz ekleyerek (WinForms/WPF) konsol dışı çalıştırmak.
