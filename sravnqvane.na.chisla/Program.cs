
namespace sravnqvane.na.chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] values = input.Split(',');

            int[] array = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                array[i] = int.Parse(values[i].Trim());
            }

            Console.WriteLine("Масив преди сортирането:");
            PrintArray(array);

            SelectionSortAlgorithm(array);

            Console.WriteLine("Масив след сортирането:");
            PrintArray(array);
        }

        static void SelectionSortAlgorithm(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        static void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }


    }
}
