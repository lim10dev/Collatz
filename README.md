# COLLATZ - v1.0

- [Collatz Sanısı](#collatz-san%C4%B1s%C4%B1)  
- [Nasıl Kullanılır](#nas%C4%B1l-kullan%C4%B1l%C4%B1r)  
- [İletişime Geçin](#i%CC%87leti%C5%9Fime-ge%C3%A7in)  
- [Linkler](#linkler)

## Collatz Sanısı
Collatz Sanısı, iki aritmetik işlemin tekrarlanmasıyla tüm doğal sayıların 1'e ulaşacağını söyleyen bir sanıdır.
Bu iki işlemler şu şekildedir:

- Eğer sayı çiftse sayıyı ikiye böl (x/2)
- Eğer sayı tekse sayıyı üçle çarp (3x+1)

Bu işlemleri sayı 1'e ulaşana kadar tekrarlayabiliyoruz.

Bunu denemek için bir sayıyla başlayalım, sayımız 3 olsun.

- 3 tek sayı **→** 3(3) + 1 = 10
- 10 çift sayı **→** (10)/2 = 5
- 5 tek sayı **→** 3(5) + 1 = 16
- 16 çift sayı **→** (16)/2 = 8
- 8 çift sayı **→** (8)/2 = 4
- 4 çift sayı **→** (4)/2 = 2
- 2 çift sayı **→** (2)/2 = 1
	
**Son sayı olarak 1'e ulaştık. Eğer 1'den sonra devam edersek farklı bir sonuç doğuyor:**  
- 1 tek sayı **→** 3(1) + 1 = 4
- 4 çift sayı **→** (4)/2 = 2
- 2 çift sayı **→** (2)/2 = 1

1'den sonra devam etmek bizi sonu gelmeyen bir döngüye sokuyor. Döngüden kaçınmak için 1'e ulaştığımız anda devam etmeyi bitiriyoruz.

Bu program ile tüm işlemleri bilgisayar hesaplar ve size grafiğini oluşturur!

## Nasıl kullanılır
Programı açtığınızda karşınıza çıkan ekranda belli şeyler var:
- [Sayı Alanı](#say%C4%B1-alan%C4%B1)
- [Hesapla Tuşu](#hesapla-tu%C5%9Fu)
- [Alttaki bölge](#alttaki-b%C3%B6lge)
- [Ayarlar](#ayarlar)

### Sayı alanı
1'e ulaşana kadar hesaplanacak sayıyı buraya yazılır.
Girebileceğiniz değerler 1 ile 34359738368 arasında olabilir (2^0 ve 2^35).

### Hesapla tuşu
Sayı alanına girdiğiniz değeri Collatz sanısına göre hesaplar.
Hesaplanan sonuç; adım sayısı x, adımda ulaşılan sayı y ekseninde olmak üzere belirtilen grafiğe yazılır.

>#### log() İşlemi
>Grafikte uçurumlar olduğu zaman daha küçük sayıların görülmesi zorlaşıyor.
>Bu işlem grafikteki her sayının logaritmasını alır, böylece normal haline kıyasla iki sayı arasındaki fark daha az olur.

### Alttaki bölge
Bu bölge iki kısımdan oluşur:
- [Aralığa bakma](#aral%C4%B1%C4%9Fa-bakma)
- [Bilgi](#bilgi)

#### Aralığa Bakma
Çizilen grafikte, iki adım arasında kalan bölgeyi ayrı olarak gösterir.
Hesapla tuşuyla bir değeri hesapladıktan sonra,
1. Kaydırma araçları ile aralığına bakacağınız iki sayıyı seçin
2. Göster tuşuna basın
Göster tuşuna bastıktan sonra grafik sağ alta çizilecektir.
Aralığın, büyük grafiğe çizilmesi için "Yerlerini Değiştir" kutusuna tıklayın.

#### Bilgi
Hesapladığınız sayı hakkında ek bilgiler gösterir. Bunlar:
- Tüm adımlardaki tek sayı adeti
- Tüm adımlardaki çift sayı adeti
- Tüm adımlar boyunca ulaşılan en büyük sayı
- Tüm adımlardaki sayıların en sol basamağında bulunan rakamların adetinin dağılımı:  
 Sırasıyla bir adımdaki sayıyı alır. Bu sayının, en sol basamağındaki rakamı bulur ve bunu grafiğe yazar.
  Bu dağılım, sayı büyüdükçe en çok 1, en az 9 rakamının belirdiğine varıyor.

### Ayarlar
Uygulamanın ayarlarının olduğu yer. Bu ayarlar şu şekilde:
- Grafik Stili
- Grafik Rengi
- Dil
- Ayarları Sıfırla

#### Grafik Stili
Grafiğin ne grafiği olduğunu ayarlar. Geçerli seçenekler:
- Alan
- Eğrili Alan
- Çizgi
- Eğri
- Sütun

#### Grafik Rengi
Grafiğin rengini ayarlar

#### Dil
Uygulamanın dilini ayarlar (Türkçe ve İngilizce)
	
#### Ayarları Sıfırla
Tüm ayarları eski haline getirir.

## İletişime geçin
e-posta:   ahmetem8rulu1991@gmail.com  
Instagram: [@lim10dev](https://instagram.com/lim10dev/)  
Twitter:   [@lim10dev](https://twitter.com/lim10dev/)  
Discord:   LIM10#5919  

## Linkler
Kaynak kodu: https://github.com/lim10dev/collatz  
Derleme: https://lim10dev.itch.io/collatz  
Discord:   https://discord.gg/guchhN5wcn  

-@lim10dev
