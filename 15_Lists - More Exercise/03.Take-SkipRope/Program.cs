using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _03.Take_SkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = Console.ReadLine().ToList();
            List<int> nums = new List<int>();
            StringBuilder result = new StringBuilder();
            int index = 0;

            for (int i = 0; i < chars.Count; i++)
            {
                if (char.IsNumber(chars[i]))
                {
                    nums.Add(chars[i] - '0');
                    chars.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < nums.Count; i += 2)
            {
                nums[i] = index + nums[i] >= chars.Count ? chars.Count - index : nums[i];
                result.Append(string.Concat(chars.GetRange(index, nums[i])));
                index += nums[i] + nums[i + 1];
            }
            Console.WriteLine(result.ToString());
        }
    }
}
