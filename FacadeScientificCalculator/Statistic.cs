namespace FacadeScientificCalculator
{
    internal class Statistic
    {
        public Statistic(int type)
        {
            if (type == 1)
            {
                mean();
            }
            if (type == 2)
            {
                median();
            }
        }

        public void mean()
        {
            int counter = 0, result = 0;
            List<int> list = new List<int>();
            Console.WriteLine("Enter all the numbers to find their mean || Press -1 to stop adding");
            while (true)
            {
                int current_input = 0;
                Console.WriteLine($"Enter number {counter + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                    current_input = -1;
                if (current_input != -1)
                {
                    list.Add(number);
                }
                else
                {
                    break;
                }
                counter++;
            }

            int length = list.Count;

            foreach (int item in list)
            {
                result += item;
            }

            double median = result / length;
            Console.WriteLine($"median: {median}");
        }

        public void median()
        {
            int i, j, n, max;

            float median, temp = 0;

            int counter = 0, result = 0;
            List<int> list = new List<int>();
            Console.WriteLine("Enter all the numbers to find their mean || Press -1 to stop adding");
            while (true)
            {
                int current_input = 0;
                Console.WriteLine($"Enter number {counter + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                    current_input = -1;
                if (current_input != -1)
                {
                    list.Add(number);
                }
                else
                {
                    break;
                }
                counter++;
            }
            /* sorting */
            for (i = 0; i < list.Count - 1; i++)
            {
                for (j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = (int)temp;
                    }
                }
            }


            /* calculation median */
            if (list.Count % 2 == 0)
            {
                median = (list[(list.Count / 2) - 1] + list[(list.Count / 2)]) / 2.0F;
            }
            else
            {
                median = list[(list.Count / 2)];
            }

            /*printing result */

            for (i = 0; i < list.Count; i++)
                Console.WriteLine(list[i] + "\t");

            Console.WriteLine("Median is " + median);
        }
    }
}
