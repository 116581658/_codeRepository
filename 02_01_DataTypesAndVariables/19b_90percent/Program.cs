using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19b_90percent
{
    class Program
    {
        static void Main(string[] args)
        {

            // Boolean DEBUG = false;
            Boolean DEBUG = true;
            do
            {

                try
                {
                    int nPictureAmount = int.Parse(Console.ReadLine());
                    int timePicturesToBeFilteredSeconds = int.Parse(Console.ReadLine());
                    int filterFactorPercentage = int.Parse(Console.ReadLine());
                    int timePicturesToBeUploadedSeconds = int.Parse(Console.ReadLine());


                    long totalTime = 0L;
                    long d = 0L;
                    byte hh = 0;
                    byte mm = 0;
                    byte ss = 0;

                    //d:HH:mm:ss 
                    long timeFilteringAllPictures = 0L;
                    int filteredPictures = 0;
                    long timeForUpload = 0L;
                    if ((nPictureAmount >= 0 && nPictureAmount <= 1000000))
                    {
                        if (((timePicturesToBeFilteredSeconds + timePicturesToBeUploadedSeconds) >= 0 &&
                            (timePicturesToBeFilteredSeconds + timePicturesToBeUploadedSeconds) <= 100000))
                        {
                            if ((filterFactorPercentage >= 0 && filterFactorPercentage <= 100))
                            {

                                if (filterFactorPercentage == 0)
                                {
                                    Console.WriteLine("{0}:{1:0#}:{2:0#}:{3:0#}", d, hh, mm, ss);
                                }
                                else
                                {

                                    double percentKoeff = filterFactorPercentage / 100.0;
                                    timeFilteringAllPictures = ((long)nPictureAmount * timePicturesToBeFilteredSeconds);
                                    filteredPictures = (int)Math.Ceiling(nPictureAmount * percentKoeff);

                                    if (DEBUG)
                                    {
                                        Console.WriteLine("percentKoeff: " + percentKoeff);
                                        Console.WriteLine("timeFilteringAllPictures: " + timeFilteringAllPictures);
                                        Console.WriteLine("nPictureAmount: " + nPictureAmount);

                                        Console.WriteLine("filteredPictures: " + filteredPictures);

                                        double filteredPictures2 = Math.Ceiling(nPictureAmount * percentKoeff);
                                        Console.WriteLine("filteredPictures2: " + filteredPictures2);

                                    }

                                    timeForUpload = (long)filteredPictures * timePicturesToBeUploadedSeconds;
                                    totalTime = timeFilteringAllPictures + timeForUpload;

                                    if (DEBUG)
                                    {
                                        Console.WriteLine("picToBeUploadedTimeSeconds: " + timePicturesToBeUploadedSeconds);
                                        Console.WriteLine("timeForUpload: " + timeForUpload);
                                        Console.WriteLine("totalTime: " + totalTime);
                                    }

                                    d = (totalTime / 86400); // calculates the days
                                    if (DEBUG)
                                    {
                                        Console.WriteLine("d: " + d);
                                    }
                                    totalTime %= 86400;
                                    hh = (byte)(totalTime / 3600); // calculates the hours
                                    if (DEBUG)
                                    {
                                        Console.WriteLine("hh: " + hh);
                                    }
                                    totalTime %= 3600;
                                    mm = (byte)(totalTime / 60); // calculates the minutes
                                    if (DEBUG)
                                    {
                                        Console.WriteLine("mm: " + mm);
                                    }
                                    totalTime %= 60;
                                    ss = (byte)(totalTime);// calculates the seconds
                                    if (DEBUG)
                                    {
                                        Console.WriteLine("ss: " + ss);
                                    }

                                    Console.WriteLine("{0}:{1:0#}:{2:0#}:{3:0#}", d, hh, mm, ss);

                                    // 10 d, 3 h, 21 m, 22 sek = 10 * 24*60*60 + 3 * 60*60 + 21 * 60 + 22 = 876082
                                    //                                86400          3600         60
                                }
                            }
                            else
                            {
                                Console.WriteLine("wrong value");
                            }
                        }
                        else
                        {
                            Console.WriteLine("wrong value");
                        }
                    }
                    else
                    {
                        Console.WriteLine("wrong value");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("wrong value");
                }
            } while ((Console.ReadLine()) != "x" || (Console.ReadKey(true).Key != ConsoleKey.X));

        }
    }
}
