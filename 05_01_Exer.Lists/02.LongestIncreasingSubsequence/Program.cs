using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LongestIncreasingSubsequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToList();


            List<int> subseqs = new List<int>();

            //0 10 10 20 30 10 30 40 1 50 2 3 4 5 6  -> 0 1 2 3 4 5 6
            // 0 10 20 30 40 50 , 6 ; 0 1 2 3 4 5 6 , 7

            List<string> firstInSeq = new List<string>();
            List<string> nextInSeq = new List<string>();

            int numbersLen = numbers.Count;
            int i = 0;
            int max = 0;
            int firstLen = 1;
            firstInSeq = CalculateElementsNumber(numbers, i);
            firstLen = int.Parse(firstInSeq[0]);

            for (int j = 1; j < numbersLen; j++)
            {
                
                nextInSeq = CalculateElementsNumber(numbers, j);
                int secondLen = int.Parse(nextInSeq[0]);

                if (firstLen >= secondLen)
                {
                    max = i;
                    continue;
                }
                else
                {
                    i = j;
                    max = i;
                }

                firstInSeq = CalculateElementsNumber(numbers, i);
                firstLen = int.Parse(firstInSeq[0]);

            }

            string myresult = CalculateElementsNumber(numbers, max)[1];
            Console.WriteLine(myresult);

        }




        //0 10 10 20 30 10 30 40 1 50 2 3 4 5 6  -> 0 1 2 3 4 5 6



        public static List<string> CalculateElementsNumber(List<int> theList, int index)
        {
            List<int> working = new List<int>(theList.Count);

            for (int i = 0; i < theList.Count; i++)
            {
                working.Add(theList[i]);
            }

            int firstEl = working[index];
            int maxLen = 2;
            int minIndex = 0;
            int maxIndex = 0;
            string text = string.Empty;
            int varibleInd = index;
            List<int> intermedIndex = new List<int>();
            List<string> intermedText = new List<string>();
            List<string> listFromFind = new List<string>();
            List<string> result = new List<string>();

            while (maxLen > 1)
            {
                listFromFind = FindSeqenceOfIncreaingElements(working, varibleInd);
                minIndex = int.Parse(listFromFind[0]);
                maxIndex = int.Parse(listFromFind[1]);
                maxLen = int.Parse(listFromFind[2]);
                text = listFromFind[3];

                
                intermedIndex.Add(maxLen);
                intermedText.Add(text);

                if (minIndex < maxIndex)
                {
                    varibleInd = minIndex;
                    working[varibleInd] = firstEl; //makes the max integer in a sequence equal to the minimal number
                                                   //in this way we will try to look for another max number

                    varibleInd = index;
                }
                else
                {
                    varibleInd = index;
                }







            }

            listFromFind = FindSeqenceOfIncreaingElements(intermedIndex, 0);

            maxIndex = int.Parse(listFromFind[1]);
            maxLen = int.Parse(listFromFind[2]);
            text = intermedText[maxIndex];

            result.Add(maxLen.ToString());
            result.Add(text);

            return result;
        }

        public static List<string> FindSeqenceOfIncreaingElements(List<int> list, int beginIndex)
        {
            List<string> result = new List<string>();

            int lenOfList = list.Count;
            int firstEl = list[beginIndex];
            int previous = list[beginIndex];
            int nextNext = 0;
            int countElementInSeq = 1;
            int indexOfMax = 0;
            int indexCounter = 0;
            string text = string.Empty;
            int elementsInSeq = 1;
            bool firstEntrance = true;
            int indexOfMin = 0;

            for (int j = beginIndex + 1; j <= lenOfList; j++)
            {
                if (j == lenOfList)
                {
                    nextNext = firstEl;
                }
                else
                {
                    nextNext = list[j];
                }


                if (firstEntrance && previous < nextNext)
                {
                    indexOfMin = j;
                    firstEntrance = false;
                }


                if (previous >= nextNext)
                {
                    indexOfMax = indexCounter;
                    continue;
                }
                else
                {
                    indexCounter = j;
                    text += previous + " ";
                    previous = nextNext;
                    countElementInSeq++;

                }
            }

            indexOfMax = indexCounter;
            elementsInSeq = countElementInSeq;
            text += previous;

            result.Add(indexOfMin.ToString());
            result.Add(indexOfMax.ToString());
            result.Add(elementsInSeq.ToString());
            result.Add(text);

            return result;

        }



    }
}
