using System;

namespace _10_Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };//49
            int[] height2 = { 1, 1 };//1
            int[] height3 = {4,3,2,1,4 };//16
            int[] height4 = { 1, 2,1 };//2
            Console.WriteLine(MaxArea(height1));
            Console.WriteLine(MaxArea(height2));
            Console.WriteLine(MaxArea(height3));
            Console.WriteLine(MaxArea(height4));
            Console.ReadLine();

        }

        public static int MaxArea(int[] height)
        {
            int leftPoint = 0;
            int rightPoint = height.Length - 1;
            int maxArea = 0;
      

            while (leftPoint< rightPoint)
            {
               int area = (rightPoint-leftPoint) * Math.Min(height[leftPoint], height[rightPoint]);
               // Console.WriteLine(rightPoint-leftPoint);
                maxArea = Math.Max(maxArea, area);
                if (height[leftPoint]< height[rightPoint])
                {
                    leftPoint++;
                }
                else if (height[leftPoint]> height[rightPoint])
                {
                    rightPoint--;
                }
                else
                {
                    leftPoint++;
                    rightPoint--;
                }
            }
            
            
            return maxArea;
        }


    }
}
