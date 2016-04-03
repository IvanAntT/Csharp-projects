using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallDown_Array_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[8];
            for (int i = 0; i < 8; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 7; i++)
            {
                for (int line = 7; line >0; line--)
                {
                     for (int num = 0; num < 8; num++) // 4isloto se razdelq na 8 kletki kato v 
                                        // v binaren kod i se obhojda vsqka kletka
                        {
                    if ((nums[line] >> num & 1) == 0 &&//dali kato izmestim n7 s i pozicii 4isloto e 0
                        (nums[line-1] >> num & 1) == 1) //dali kato izmestim n6 s i pozicii 4isloto e 1 
                            {
                        nums[line] = nums[line] | (1 << num);
                        nums[line-1] = nums[line-1] ^ (1 << num);
                            }
                        }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(nums[i]);
            }


        }
    }
}
