using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture
{
    internal class DilAyar
    {

        public DilAyar(string dil_)
        {
            dil = dil_ == "tr" ? "tr" : "en";
        }

        private string dil = "en";

        public readonly Dictionary<string, string> sozlukTR = new Dictionary<string, string>
        {
            {"adim", "adım"},
            {"aralikKutusu", "Belli Bir Aralığa Bak"},
            {"ayarlar", "Ayarlar"},
            {"ayarlarAltiAciklama", "Matematik proje ödevim için yaptım"},
            {"ayarlariSifirla", "Ayarları Sıfırla"},
            {"bilgi", "Bilgi"},
            {"bilgiLabel", "Başlangıç Sayısı : /Tek Sayı Miktarı : /Çift Sayı Miktarı : /Ulaşılan En Büyük Sayı : /Adım Miktarı : "},
            {"collatzSanisi", "Collatz Sanısı"},
            {"collatzSanisiAciklama", "Collatz Sanısı, iki aritmetik işlemin sürekli tekrarlanarak en sonunda tüm pozitif tam sayıların 1'e ulaşacağını anlatan bir sanıdır." +
            "\n\nEğer sayı çift ise ikiye böl (x/2)\nEğer sayı tek ise üçle çarpıp bir ekle (3x+1)"},
            {"degistir", "Yerlerini Değiştir"},
            {"goster", "Göster"},
            {"grafikRengi", "Grafik Rengi"},
            {"grafikStilEleman", "Alan\nEğrili Alan\nÇizgi\nEğrili Çizgi\nSütun"},
            {"grafikStili", "Grafik Stili"},
            {"hesapBilgilendirme", "Hesapla / Göster tuşuna bastıktan sonra\ngrafiğiniz burada gözükecektir."},
            {"hesapDeger", "Hesaplanacak Değer"},
            {"hesapla", "Hesapla"},
            {"kaynakKod", "Kaynak Kodu"},
            {"onizleme", "Önizleme"},
            {"renkSec", "Renk Seç"},
            {"tamam", "Tamam"},
            {"rakamDagilim", "Baş Rakam Dağılımları" },
            {"logHover", "Daha kolay görmek için grafiğin logaritmasını alır" },
            {"rakamDagilimHover", "Her sayının en solundaki basamağındaki rakamlarının dağılımları" },
            {"linkUyari", "{0} sitesine yönlendiriliyorsunuz." }
        };
        public readonly Dictionary<string, string> sozlukEN = new Dictionary<string, string>
        {
            {"adim", "steps"},
            {"aralikKutusu", "Look at a certain range"},
            {"ayarlar", "Settings"},
            {"ayarlarAltiAciklama", "I made this for my math project"},
            {"ayarlariSifirla", "Reset Settings"},
            {"bilgi", "Information"},
            {"bilgiLabel", "Starting Number : /Odd Number Amount : /Even Number Amount : /Greatest Number Reached : /Step Amount : "},
            {"collatzSanisi", "Collatz Conjecture"},
            {"collatzSanisiAciklama", "The Collatz conjecture asks whether repeating two simple arithmetic operations will eventually transform every positive integer into 1. [Wikipedia]" +
            "\n\nIf its even, divide it by 2 (x/2)\nIf its odd, multiply by 3 and add 1 (3x+1)"},
            {"degistir", "Switch Positions"},
            {"goster", "Show"},
            {"grafikRengi", "Graph Color"},
            {"grafikStilEleman", "Area\nCurved Area\nLine\nCurved Line\nColumn"},
            {"grafikStili", "Graph Style"},
            {"hesapBilgilendirme", "Your graph will be shown here after\nclicking Calculate / Show"},
            {"hesapDeger", "Value to Calculate"},
            {"hesapla", "Calculate"},
            {"kaynakKod", "Source Code"},
            {"onizleme", "Preview"},
            {"renkSec", "Choose Color"},
            {"tamam", "OK"},
            {"rakamDagilim", "Leading Number Distribution" },
            {"logHover", "Takes the logarithm of the graph to see it easier" },
            {"rakamDagilimHover", "Distribution of the number in the leading digit of every number" },
            {"linkUyari", "You are being redirected to {0}." }
        };

        public string KelimeAl(string key)
        {
            if (dil == "tr")
            {
                if (sozlukTR.TryGetValue(key, out var result1))
                {
                    return result1;
                } else
                {
                    return "null-tr";
                }
            }
            if (sozlukEN.TryGetValue(key, out var result2))
            {
                return result2;
            }
            else
            {
                return "null-en";
            }
        }
    }
}
