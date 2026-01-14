# İnsan Kaynakları Yönetim Sistemi - Use Case Diyagramı

Aşağıdaki diyagram, sistemdeki aktörlerin (Admin ve Personel) gerçekleştirebileceği işlemleri göstermektedir.

```mermaid
usecaseDiagram
    actor "Admin" as A
    actor "Personel" as P

    package "İnsan Kaynakları Yönetim Sistemi" {
        usecase "Sisteme Giriş Yap" as UC1
        usecase "Personel Ekle/Düzenle/Sil" as UC2
        usecase "Departman Yönetimi" as UC3
        usecase "Maaş Hesaplama ve Takibi" as UC4
        usecase "İzin Talebi Oluştur" as UC5
        usecase "İzin Talebi Onayla/Reddet" as UC6
        usecase "Performans Değerlendirme" as UC7
        usecase "Raporları Görüntüle" as UC8
        usecase "Şifre Değiştir" as UC9
    }

    A --> UC1
    P --> UC1
    
    A --> UC2
    A --> UC3
    A --> UC4
    A --> UC6
    A --> UC7
    A --> UC8
    
    P --> UC5
    P --> UC9
    
    UC2 ..> UC1 : <<include>>
    UC3 ..> UC1 : <<include>>
```
