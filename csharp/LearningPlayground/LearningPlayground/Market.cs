/*Program başlar:
"=== MARKET KASASI ===" yazar

3 ürün adı sor → kullanıcı girer (string)
3 ürün fiyatı sor → kullanıcı girer (double)

Toplam tutarı hesapla
    KDV ekle (%18)
İndirim sor: "İndirim var mı? (evet/hayır)"
    - "evet" ise %10 indirim uygula
    - "hayır" ise indirim yok

    Sonuçları göster:
Her ürün adı + fiyatı
Ara toplam
KDV tutarı  
İndirim tutarı (varsa)
Ödenecek tutar
*/
Console.WriteLine("=== ATA MARKET KASASI ===");
Console.WriteLine("1. Ürün adı nedir?");
string ürün1İsim = Console.ReadLine();
Console.WriteLine("2. Ürün adı nedir?");
string ürün2İsim = Console.ReadLine();
Console.WriteLine("3. Ürün adı nedir?");
string ürün3İsim = Console.ReadLine();
Console.WriteLine("1. Ürünün fiyatı nedir?");
bool ürünFiyat1 = double.TryParse(Console.ReadLine(), out double fiyat1);
Console.WriteLine("2. Ürünün fiyatı nedir?");
bool ürünFiyat2 = double.TryParse(Console.ReadLine(), out double fiyat2);
Console.WriteLine("3. Ürünün fiyatı nedir?");
bool ürünFiyat3 = double.TryParse(Console.ReadLine(), out double fiyat3);
if (ürünFiyat1 && ürünFiyat2 && ürünFiyat3)
{
    Console.WriteLine(ürün1İsim +" "+ fiyat1 + "TL");
    Console.WriteLine(ürün2İsim +" "+ fiyat2 + "TL");
    Console.WriteLine(ürün3İsim +" " +fiyat3 + "TL");
}
else
{
    Console.WriteLine("Hatalı tuşlama yaptınız.Yeniden deneyiniz... ");
}
double aratoplamTutar = fiyat1 + fiyat2 + fiyat3;
double kdvtoplamTutar=((aratoplamTutar/100)*18)+aratoplamTutar;
Console.WriteLine("İndiriminiz var mıdır?");
string cevap = Console.ReadLine();
double indirimliFiyat=kdvtoplamTutar - (kdvtoplamTutar/100)*10;
if (cevap== "evet")
{
    Console.WriteLine("İndirimli fiyatınız " + indirimliFiyat);
}
else
{
    Console.WriteLine("Ödenecek tutar: "+ kdvtoplamTutar+"TL");
    
}