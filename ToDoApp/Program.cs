using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            BroadManager operations = new BroadManager();

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    operations.boardListeleme();
                    break;
                case 2:
                    operations.kartEkle();
                    break;
                case 3:
                    operations.kartSil();
                    break;
                case 4:
                    operations.kartTasi();
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    break;


            }
        }
    }
}
