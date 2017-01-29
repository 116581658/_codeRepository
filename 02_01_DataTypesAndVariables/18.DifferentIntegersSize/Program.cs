using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
       DEF           MIN                     MAX                 
 sbyte| 0 | -128                 | 127                   |  
  byte| 0 | 0                    | 255                   |
 short| 0 | -32768               | 32767                 |
ushort| 0 | 0                    | 65535                 |
   int| 0 | -2147483648          | 2147483647            |
  uint| 0u| 0                    | 4294967295            |
  long| 0L| -9223372036854775808 | 9223372036854775807   |
 ulong| 0u| 0                    | 18446744073709551615  |

*/

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var aString = Console.ReadLine();
            Boolean boolSbyte = true;
            Boolean boolByte = true;
            Boolean boolShort = true;
            Boolean boolUshort = true;
            Boolean boolInt = true;
            Boolean boolUint = true;
            Boolean boolLong = true;
            sbyte aSbyte;
            byte aByte;
            short aShort;
            ushort aUshort;
            int aInt;
            uint aUint;
            long aLong;

            try
            {
                aSbyte = sbyte.Parse(aString);
            }
            catch (OverflowException)
            {
                boolSbyte = false;
            }


            try
            {
                aByte = byte.Parse(aString);
            }
            catch (OverflowException)
            {
                boolByte = false;
            }


            try
            {
                aShort = short.Parse(aString);
            }
            catch (OverflowException)
            {
                boolShort = false;
            }


            try
            {
                aUshort = ushort.Parse(aString);
            }
            catch (OverflowException)
            {
                boolUshort = false;
            }


            try
            {
                aInt = int.Parse(aString);
            }
            catch (OverflowException)
            {
                boolInt = false;
            }


            try
            {
                aUint = uint.Parse(aString);
            }
            catch (OverflowException)
            {
                boolUint = false;
            }


            try
            {
                aLong = long.Parse(aString);
            }
            catch (OverflowException)
            {
                boolLong = false;
            }


          


            if (boolSbyte || boolByte || boolShort || boolUshort || boolInt || boolUint || boolLong )
            {
                Console.WriteLine("{0} can fit in:", aString);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", aString);

            }


            if (boolSbyte)
            {
                Console.WriteLine("* sbyte");
            }

            if (boolByte)
            {
                Console.WriteLine("* byte");
            }

            if (boolShort)
            {
                Console.WriteLine("* short");
            }

            if (boolUshort)
            {
                Console.WriteLine("* ushort");
            }

            if (boolInt)
            {
                Console.WriteLine("* int");
            }

            if (boolUint)
            {
                Console.WriteLine("* uint");
            }

            if (boolLong)
            {
                Console.WriteLine("* long");
            }


        }
    }
}
