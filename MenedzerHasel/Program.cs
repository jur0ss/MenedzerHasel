// See https://aka.ms/new-console-template for more information

string[] maleLitery =
[
    "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
    "x", "y", "z"
];
string[] duzeLitery =
[
    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
    "X", "Y", "Z"
];
string[] znakiDiakrytyczne = ["ą", "ć", "ę", "ł", "ń", "ó", "ś", "ż", "ź", "Ą", "Ć", "Ę", "Ł", "Ń", "Ó", "Ś", "Ż", "Ź"];
string[] cyfry = ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
string[] znakiSpecjalne = ["!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+"];


/*
nazwa funkcji: GenerujHaslo
opis funkcji: tworzy losowe hasło dwunastoznakowe z małych i dużych liter, znaków diakrytycznych, cyfr i znaków specjalnych
parametry: brak
zwracany typ i opis: typ zwracany to string, zwraca hasło w typie tekstowym
autor:
    <nazwa typu i opis co jest zwracane, lub "brak">
    <numer zdającego>
*/

string GenerujHaslo()
{
    
    List<String> haslo = [];
    
    var random = new Random();

    for (int i = 0; i < 3; i++)
    {
        var index = random.Next(0, maleLitery.Length);
        var losowyZnak = maleLitery[index];
        haslo.Add(losowyZnak);
    }

    for (int i = 0; i < 3; i++)
    {
        var index = random.Next(0, duzeLitery.Length);
        var losowyZnak = duzeLitery[index];
        haslo.Add(losowyZnak);
    }

    for (int i = 0; i < 2; i++)
    {
        var index = random.Next(0, znakiDiakrytyczne.Length);
        var losowyZnak = znakiDiakrytyczne[index];
        haslo.Add(losowyZnak);
    }

    for (int i = 0; i < 2; i++)
    {
        var index = random.Next(0, cyfry.Length);
        var losowyZnak = cyfry[index];
        haslo.Add(losowyZnak);
    }

    for (int i = 0; i < 2; i++)
    {
        var index = random.Next(0, znakiSpecjalne.Length);
        var losowyZnak = znakiSpecjalne[index];
        haslo.Add(losowyZnak);
    }
    
    haslo = haslo.Shuffle().ToList();

    // var hasloString = "";
    // foreach(var znak in haslo)
    // {
    //     hasloString += znak;
    // }

    return string.Join("", haslo);
}

for (int i = 1; i <= 5; i++)
{
    var haslo1 = GenerujHaslo();
    Console.WriteLine($"Twoje hasło to {haslo1}");
}




