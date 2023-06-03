using System;
using System.Numerics;


public class TwoNumsSolution
{  
    public static void Main()
    {
        int[] nums = //{ 3, 2, 4 };
                       {1,3,2,4};
                     //{3,3};
                     //{ 2, 7, 11, 15 };
                     //{ 2, 5, 7, 9, 156, 325, 943 }; 
        var target = 6;
        int[] results= TwoNums(nums, target);

        foreach (var x in results)
        {
            Console.WriteLine(x);
        }


    }
    public static int[] TwoNums(int[] nums, int target)
    {
        
        for (int counter1 = 0; counter1 < nums.Length; counter1++)
        {
            int x = nums[counter1];
            for (int counter2 = counter1; counter2 < nums.Length - 1; counter2++)
            {
                if (target == ((x + nums[(counter2 + 1)])))
                {
                    int index1 = counter1;
                    int index2 = 0;
                    if (counter1 == 0)
                    {
                        index2 = 1 + Array.IndexOf(nums.Skip(1).ToArray(), nums[(counter2 + 1)]);
                    }
                    else
                    {
                        index2 = 1+ counter1 + Array.IndexOf(nums.Skip(counter1 + 1).ToArray(), nums[(counter2 + 1)]);
                    }
                    int[] result = { index1, index2 };
                    return result;
                }
            }
        }
        int[] results = { 0, 0 };
        return results;

    }
}
