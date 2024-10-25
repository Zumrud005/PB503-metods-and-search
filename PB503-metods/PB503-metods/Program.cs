using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace PB503_metods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bir int parametr qəbul edən və o ədədə qədər bütün cüt ədədlərin cəmini ekrana yazdıran, 
            // həm return type - ı olan bir method, həm də void bir method yazırsız
            Console.WriteLine("verilen eded qeder  cut ededlerin cemi:");
            Console.WriteLine(NumberSum(11));


            NumberSum2(19);

            string name = " salam  necesen ";
            
            Console.WriteLine(RemoveSpace(name));


            //Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq 
            //hala gətirən metod.Misal olaraq, name = "  Code  Acacemy   " deyə bir variable - mız varsa onu 
            //yaratdigimiz metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır.




        }


        static int NumberSum(int a)
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        static void NumberSum2(int b)
        {
            int sum2 = 0;
            for (int i = 0; i < b; i++)
            {
                if (i % 2 == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            Console.WriteLine($"{b} ededine kimi cut ededlerin cemi= {sum2}");
        }



        static string RemoveSpace(string words)
        {
            string updateWord = "";
            foreach (var wrd in words)
            {
                if (wrd != ' ')
                {
                    updateWord = updateWord + wrd;
                }
            }
            return updateWord;


        }



    }
}
