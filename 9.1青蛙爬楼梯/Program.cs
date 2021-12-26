using System;

namespace _9._1青蛙爬楼梯
{    // frog can jump stair by 1 or 2  steps per time
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many steps on the stairs?");
            int stairNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Frog climbs :" +TimesClimbing(stairNum));
            Console.WriteLine("Frog climbs :" + climb(stairNum));

        }

        public static int climb(int maxSteps)
        {
            int steps, num = 0, x = 0;
            if (maxSteps > 0) {
                do {
                    Random rnd = new Random();
                    steps = rnd.Next(1, 3);
                    x++;
                    num += steps;
                }
                while (num < maxSteps);
            }
            return x;
        }

        public static int TimesClimbing(int stairNumber)
        {
            int len = stairNumber;
            int times = 0;
            int number = 0;
            for (int i = 0; i < len ; i++)
            {
                Console.WriteLine("Please choose 1 stair or 2 stairs does frog jump this time?");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 1 && stairNumber >0 )
                {
                    times++;
                    stairNumber = stairNumber - number;
                    if (stairNumber == 0)
                    {
                        break;
                    }

                }
                else if (number == 2 && stairNumber >0)
                {
                    times++;
                    stairNumber = stairNumber - number;
                    if (stairNumber == 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please type 1 or 2");
                    number = Convert.ToInt32(Console.ReadLine());
                }

            }
            return times;
        }
    }
}
