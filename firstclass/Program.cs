using System.Globalization;
using System.Collections;

namespace firstclass
{
    internal class Program
    {
        public void arrayManipulationAsc(int[] arr)
        {
            int temp;
            for (int i = 0; i < 5; i++){
                for (int j = i + 1; j < 5; j++){
                    if (arr[i] > arr[j]){
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
            Console.WriteLine("Ascending Order:");
            for(int i = 0;i < 5; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }

        public void arrayManipulationDesc(int[] arr)
        {
            int temp;
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nDescending Order:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("\nMax in Array:");
            Console.WriteLine(arr[0]);

            Console.WriteLine("\nMin in Array:");
            Console.WriteLine(arr[arr.Length -1]);
        }

        public void printPattern()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for(int j = i;j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int k = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }
                k = k - 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine() ;
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{j + 1}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 65; i < 70; i++)
            {
                for (int j = 65; j <= i; j++)
                {
                    Console.Write((char)j);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 65; i < 70; i++)
            {
                for (int j = 65; j <= i; j++)
                {
                    Console.Write((char)i);
                }
                Console.WriteLine();
            }
        }

        public void findName(String[] arrayNames, String findName)
        {
            for(int i = 0;i < arrayNames.Length; i++)
            {
                if (arrayNames[i] == findName)
                {
                    Console.WriteLine("Name is Present!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Name is Not Present!!");
                    break;

                }
            }
        }

        public void segragateArray()
        {
            Console.WriteLine("Enter array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            
            int[] arr = new int[size];

            var evenArr = new ArrayList();
            var oddArr = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter Array Element {i + 1}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            int evenSum = 0, oddSum = 0;
            for(int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] != 0
                    ) {
                    evenArr.Add(arr[i]);
                    evenSum += arr[i];
                }
                else if(arr[i] % 2 != 0){
                    oddArr.Add(arr[i]);
                    oddSum += arr[i];
                }
                else if (arr[i] == 0)
                {
                    continue;
                }
            }

            Console.WriteLine("\nEven Array: ");
            for (int i = 0; i < evenArr.Count; i++)
            {
                Console.Write($"{evenArr[i]}\t");
            }

            Console.WriteLine($"Even Sum: {evenSum}");

            Console.WriteLine("\nOdd Array: ");
            for (int i = 0; i < oddArr.Count; i++)
            {
                Console.Write($"{oddArr[i]}\t");
            }
            Console.WriteLine($"Odd Sum: {oddSum}");

        }

        public void concatArray()
        {
            var firstArr = new ArrayList();
            var secondArr = new ArrayList();
            var concatArr = new ArrayList();

            Console.WriteLine("Enter first array element:");
            for(int i =  0; i < 5; i++)
            {
                Console.WriteLine($"Enter element {i + 1}");
                firstArr.Add(Console.ReadLine());
            }

            Console.WriteLine("Enter second array element:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter element {i + 1}");
                secondArr.Add(Console.ReadLine());
            }

            for(int i = 0; i < firstArr.Count; i++)
            {
                concatArr.Add(firstArr[i]);
            }

            for (int i = 0; i < secondArr.Count; i++)
            {
                concatArr.Add(secondArr[i]);
            }

            for(int i = 0; i <  concatArr.Count; i++)
            {
                Console.Write($"{concatArr[i]}\t");
            }
        }



        static void Main(string[] args)
        {
            Program one = new Program();

            /*Ascending/ Descending/ Max/ Min*/
            /*int[] arr = { 75, 24, 11, 100, 101 };
            one.arrayManipulationAsc(arr);
            one.arrayManipulationDesc(arr);*/

            /*one.printPattern();*/

            /*Console.WriteLine("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            String[] arrNames = new String[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a name: ");
                arrNames[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter a name to find in the array:");
            String findName = Console.ReadLine();
            one.findName(arrNames, findName);*/

            /*one.segragateArray();*/

            one.concatArray();
        }
    }
}