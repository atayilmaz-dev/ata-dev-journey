
//Program başlar:
//"=== BASKETBOL MAÇ SKORU HESAPLAYICI ===" 

    /*Takım 1 adını sor → kullanıcı girer (string)
Takım 1 için:
- Kaç tane 2'lik basket? → girer
    - Kaç tane 3'lük basket? → girer  
    - Kaç tane serbest atış? → girer
    Takım 1 skoru hesapla: (ikilik*2) + (uclu*3) + (serbest*1)

Aynısını Takım 2 için yap

Sonuçları göster:
"Takım 1 Adı: XX sayı"
"Takım 2 Adı: XX sayı"
  
Kazananı ilan et:
Eğer Takım 1 > Takım 2 → "Kazanan: Takım 1 Adı!"
Eğer Takım 2 > Takım 1 → "Kazanan: Takım 2 Adı!"
Eğer eşitse → "Berabere!"

Geçersiz giriş olursa TryParse ile yakala
*/
    Console.WriteLine("=== BASKETBOL MAÇ SKORU HESAPLAYICI ===");

    Console.Write("1. Takım adı: ");
    string takim1 = Console.ReadLine();

    Console.Write("Kaç 2'lik attı? ");
    bool ikilikt1 = int.TryParse(Console.ReadLine(), out int ikilik1);
    Console.Write("Kaç 3'lik attı? ");
    bool üçlükt1 = int.TryParse(Console.ReadLine(), out int üçlük1);
Console.WriteLine("Kaç tane serbest atış attı?: ");
 bool serbestatışt1=int.TryParse(Console.ReadLine(), out int serbestatış1);
 int hesaplama1 = (ikilik1 * 2) + (üçlük1 * 3) + (serbestatış1 * 1);
 if (ikilikt1 && üçlükt1 && serbestatışt1)
 {
     Console.WriteLine($"{takim1} Skoru: {hesaplama1}");
 }
else
{
Console.WriteLine("Yanlış girdiniz");
}
Console.WriteLine("2. Takım adı: ");
string takim2 = Console.ReadLine();
Console.WriteLine("Kaç üçlük attı? ");
bool ikiliikt2 = int.TryParse(Console.ReadLine(), out int ikilik2);
Console.WriteLine("Kaç ikilik attı? ");
bool üçlükt2 = int.TryParse(Console.ReadLine(), out int üçlük2);
Console.WriteLine("Kaç serbest atış attı? ");
bool serbestatışt2 = int.TryParse(Console.ReadLine(), out int serbestatış2);
int hesaplama2 = (ikilik2 * 2) + (üçlük2 * 3) + (serbestatış2 * 1);
if (ikiliikt2 && üçlükt2 && serbestatışt2)
{
    Console.WriteLine($"{takim2} Skoru: {hesaplama2}");
}
else
{
    Console.WriteLine("Yanlış girdiniz");
}

if (hesaplama2 == hesaplama1)
{
    Console.WriteLine("Berabere");
}
else if (hesaplama2>hesaplama1)   
{
    Console.WriteLine($"{takim2} Kazandı!");
}
else
{
    Console.WriteLine($"{takim1} Kazandı!");
}
Console.ReadLine();
