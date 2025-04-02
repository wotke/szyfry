using tablica_ascii;
Console.WriteLine("Podaj tekst do zakodowania: ");

//readline zawsze zwraca string - nawet jeśli wpiszecie jedną literę

string text = Console.ReadLine();
string output = Szyfr_ascii.gaderypoluki_cypher(text);
//wypisujemy wynik

Console.WriteLine("Zaszyfrowany tekst: " + output);
//output to jest ten zaszyfrowany ciag znakow
