# 🚗 RentACar

**RentACar**, C# ve .NET ile geliştirilmiş basit bir araç kiralama uygulamasıdır.
Araç bilgilerini, renkleri, yakıt türlerini, şanzıman tiplerini ve araç detaylarını yönetmenizi sağlar.

## 🚀 Özellikler

* 🚘 Araç ekleme, silme, güncelleme
* 🎨 Renk yönetimi
* ⛽ Yakıt türü yönetimi
* ⚙️ Şanzıman tipleri yönetimi
* 📄 Araç detaylarını listeleme
* Katmanlı mimari ve DTO yapısı

## 📂 Proje Yapısı

```
RentACar/
│
├── RentACar/                     # Uygulama ana klasörü
│   ├── Models/                    # Veri modelleri
│   │   ├── Car.cs
│   │   ├── Color.cs
│   │   ├── Fuel.cs
│   │   ├── Transmission.cs
│   │   └── Dtos/
│   │       └── CarDetailDto.cs
│   ├── Program.cs                  # Giriş noktası
│   └── RentACar.csproj
│
├── Car/                           # Alternatif modül
│   └── Program.cs
│
├── RentACar.sln                   # Çözüm dosyası
├── .gitignore
└── .gitattributes
```

## 🛠 Gereksinimler

* [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* Visual Studio 2022 veya Rider

## 📦 Kurulum & Çalıştırma

1. Depoyu klonlayın:

   ```bash
   git clone https://github.com/kullanici/RentACar.git
   ```
2. Proje dizinine gidin:

   ```bash
   cd RentACar/RentACar
   ```
3. Projeyi çalıştırın:

   ```bash
   dotnet run
   ```

## 📌 Kullanım

Uygulama çalıştığında şu işlemleri yapabilirsiniz:

* Yeni araç ekleme
* Araç bilgilerini güncelleme
* Araç detaylarını listeleme
* Renk, yakıt ve şanzıman tiplerini yönetme

## 🏗 Mimari

Proje, **katmanlı mimari** prensiplerine uygun olarak tasarlanmıştır:

* **Models** → Veri modelleri ve DTO’lar
* **Program.cs** → Uygulama başlangıç noktası
* **Car** → Alternatif modül veya test uygulaması

