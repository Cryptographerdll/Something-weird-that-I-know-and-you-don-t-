using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Exceptions_Master
{
    class DemoCode
    {
        public int GrandParentMehod(int position)
        {
            return ParentMethod(position);
        }

        public int ParentMethod(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int output = 0;

            int[] Numbers = new int[] { 1, 4, 2, 11, 78, 14, 92, 85, 6, 12, 4 };
              output = Numbers[position];
            //try
            //{
            //    int[] Numbers = new int[] { 1, 4, 2, 11, 78, 14, 92, 85, 6, 12, 4 };
            //    output = Numbers[position];
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            return output;

            #region condition <= 10 if ! well throw an exception .
            #endregion
        }
    }
}

namespace ExceptionsLibrary
{
    public class Demo
    {

    }
}
