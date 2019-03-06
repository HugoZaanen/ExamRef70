using System;

namespace Objective_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-47 
            //int x = 5;
            //int y = 5;
            //int z = 6;

            //bool result = x != y || y ==z;
            //Console.WriteLine(result);
            #endregion

            #region 1-48 Short-circuiting the Or operator
            //bool x = true;
            //bool result = x || GetY();
            #endregion

            #region 1-49 Using the AND operator
            //int value = 42;
            //bool result = (value > 0) && (value < 100);
            #endregion

            #region 1-50 Short-circuiting the AND operator
            //string input = null;
            //bool result = (input != null) && GetX();
            //Console.WriteLine(result);
            #endregion

            #region 1-52 basic if statements
            //bool b = false;
            //bool c = true;
            //bool z = true;

            //if(b == true)
            //{
            //    Console.WriteLine("b is true");
            //}
            //else if(c == true)
            //{
            //    if(z == false)
            //    {
            //        Console.WriteLine("c is true");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("c and b are false");
            //}

            //int x = 7;
            //int z = x == 5 ? 10 : 0;
            //Console.WriteLine(z);
            #endregion

            #region 1-62 A switch statement
            //int x = 15;

            //if(x == 14)
            //{

            //}
            //else if(x == 15)
            //{

            //}
            //else if (x == 16)
            //{

            //}
            //else
            //{
            //    //defualt
            //}

            //switch(x)
            //{
            //    case 14:
            //        {
            //            Console.WriteLine("The value is 14");
            //            goto case 16;
            //        }
            //    case 15:
            //        {
            //            Console.WriteLine("The value is 15");
            //            break;
            //        }
            //    case 16:
            //        {
            //            Console.WriteLine("The value is 16");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("The value is not 14,15,or 16");
            //            break;
            //        }
            //}
            #endregion

            #region 1-64 basic for loop
            int[] values = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            #endregion
        }

        private static bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }

        private static bool GetX()
        {
            Console.WriteLine("OUTPUT");
            return true;
        }
    }
}
