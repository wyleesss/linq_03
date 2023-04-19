using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Text;

namespace Requests
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int sortKey;
            string[] result;
            string[] array = { "будка", "метеорит", "банкет",
                               "насіння", "звір", "траншея",
                               "богородиця", "вода", "рослина",
                               "кружка", "колія", "жайворонок",
                               "зірка", "лампа", "сода"};

            do
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("СПИСОК СЛІВ:\n");

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write($"{array[i],-15} ");
                        if ((i + 1) % 3 == 0)
                            Console.Write("\n");
                    }

                    Console.Write("\n\nвведіть потрібну кількість букв\nдля сортування\n-> ");
                }
                while (!int.TryParse(Console.ReadLine(), out sortKey));


                result = array.Where(word => word.Length == sortKey).ToArray();


                Console.WriteLine("\n\nРЕЗУЛЬТАТ:\n");

                if (result.Length > 0)
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        Console.Write($"{result[i],-15} ");
                        if ((i + 1) % 3 == 0)
                            Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("таких слів немає у списку");
                }

                Console.WriteLine("\n\nнатисність будь-яку клавішу для продовження\nабо натисність ESC для виходу..");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}