using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablica_ascii
{
    class Szyfr_ascii
    {
        public static string CaesarCypher(string text)

        {

            //zamieniamy na duże litery i usuwamy spacje - chainowanie metod

            text = text.ToUpper().Replace(" ", "");

            char[] charArray = text.ToCharArray();

            string output = String.Empty;

            foreach (char c in charArray)

            {

                //jesli wpisano literę pomiedzy A a Z to jej wartośc liczbowa wynosi pomiędzy 65 a 90

                //wyciągamy wartość liczbową poprzez jawne rzutowanie na int

                int charValue = (int)c;

                //dodajemy wartość "klucza" - 3

                charValue += 3;

                //sprawdzamy czy wynik mieści się w zakresie dużych liter alfabetu łacińskiego

                if (charValue > 90)

                {

                    //jeśli nie to odejmujemy 26 żeby "przewinąć do początku alfabetu"

                    charValue -= 26;

                }

                //konwertujemy wartość liczbową na znak

                char result = (char)charValue;

                //dodajemy znak do wyniku

                output += result;

            }

            return output;

        }
        public static string DictionaryCaesar(string text)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('A', 'D');
            dict.Add('B', 'E');
            dict.Add('C', 'F');
            dict.Add('D', 'G');
            dict.Add('E', 'H');
            dict.Add('F', 'I');
            dict.Add('G', 'J');
            dict.Add('H', 'K');
            dict.Add('I', 'L');
            dict.Add('J', 'M');
            dict.Add('K', 'N');
            dict.Add('L', 'O');
            dict.Add('M', 'P');
            dict.Add('N', 'Q');
            dict.Add('O', 'R');
            dict.Add('P', 'S');
            dict.Add('Q', 'T');
            dict.Add('R', 'U');
            dict.Add('S', 'V');
            dict.Add('T', 'W');
            dict.Add('U', 'X');
            dict.Add('V', 'Y');
            dict.Add('W', 'Z');
            dict.Add('X', 'A');
            dict.Add('Y', 'B');
            dict.Add('Z', 'C');
            text = text.ToUpper().Replace(" ", "");
            char[] charArray = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in charArray)
            {
                output += dict[c];
            }
            return output;
        }
        public static string gaderypoluki_cypher(string text)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('G', 'A');
            dict.Add('D', 'E');
            dict.Add('R', 'Y');
            dict.Add('P', 'O');
            dict.Add('L', 'U');
            dict.Add('K', 'I');
            dict.Add('I', 'K');
            dict.Add('U', 'L');
            dict.Add('O', 'P');
            dict.Add('Y', 'R');
            dict.Add('E', 'D');
            dict.Add('A', 'G');
            dict.Add('B', 'B');
            dict.Add('C', 'C');
            dict.Add('F', 'F');
            dict.Add('H', 'H');
            dict.Add('J', 'J');
            dict.Add('M', 'M');
            dict.Add('N', 'N');
            dict.Add('Q', 'Q');
            dict.Add('S', 'S');
            dict.Add('T', 'T');
            dict.Add('V', 'V');
            dict.Add('W', 'W');
            dict.Add('X', 'X');
            dict.Add('Z', 'Z');
            text = text.ToUpper().Replace(" ", "");
            char[] charArray = text.ToCharArray();
            string output = String.Empty;
            foreach (char c in charArray)
            {
                output += dict[c];
            }
            return output;
        }
    }
}
