using System;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Trim().Split(' ');
            string[] text2 = Console.ReadLine().Trim().Split(' ');
            string firstArray = string.Empty;
            string secondArray = string.Empty;
            string comparedResult = CompareArrays(text1, text2);

            if (comparedResult.Equals("1After2"))
            {
                firstArray = ConvertArrayToText(text2);
                secondArray = ConvertArrayToText(text1);
            }
            else if (comparedResult.Equals("areEqual") || comparedResult.Equals("1Before2"))
            {
                firstArray = ConvertArrayToText(text1);
                secondArray = ConvertArrayToText(text2);
            }

            Console.WriteLine("{0}\n{1}", firstArray, secondArray);

        }


        public static string ConvertArrayToText(string [] array)
        {
            string[] arr = (string[])array.Clone();
            string text = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i];
            }
            return text;
        }

        public static string CompareArrays(string[] array1, string[] array2)
        {
            string value = string.Empty;
            bool text1SameText2 = false;
            bool text1BeforeText2 = false;
            bool text1AfterText2 = false;
            int arrayLength = Math.Min(array1.Length, array2.Length);
            for (int i = 0; i < arrayLength; i++)
            {
                if (array1[i].CompareTo(array2[i]) == 0)
                {
                    text1SameText2 = true;
                    continue;
                }
                else if (array1[i].CompareTo(array2[i])< 0)
                {
                    text1SameText2 = false;
                    text1BeforeText2 = true;
                    text1AfterText2 = false;
                    break;
                }
                else
                {
                    text1SameText2 = false;
                    text1BeforeText2 = false;
                    text1AfterText2 = true;
                    break;
                }
            }


            if ((array1.Length == array2.Length) && (text1SameText2 == true))
            {
                value = "areEqual";
            }
            else if ((array1.Length > array2.Length) && (text1SameText2 == true))
            {
                value = "1After2";
            }
            else if ((array1.Length < array2.Length) && (text1SameText2 == true))
            {
                value = "1Before2";
            }
            else if ((text1BeforeText2 == true))
            {
                value = "1Before2";
            }
            else if ((text1AfterText2 == true))
            {
                value = "1After2";
            }

            return value;
        }

    }
}
