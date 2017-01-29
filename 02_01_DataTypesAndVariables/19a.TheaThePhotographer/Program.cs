using System;

namespace _19a.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    int nPictureAmount = int.Parse(Console.ReadLine());
                    int filterTimeSeconds = int.Parse(Console.ReadLine());
                    int filterFactor = int.Parse(Console.ReadLine());
                    int picToBeUploadedTimeSeconds = int.Parse(Console.ReadLine());

                    long totalTime = 0;
                    long d = 0;
                    long hh = 0;
                    long mm = 0;
                    long ss = 0;

                    //d:HH:mm:ss 
                    long timeFilteringAllPictures = 0L;
                    int filteredPictures = 0;
                    long timeForUpload = 0L;
                    if ((nPictureAmount >= 0 && nPictureAmount <= 1000000))
                    {
                        if (((filterTimeSeconds + picToBeUploadedTimeSeconds) >= 0 &&
                            (filterTimeSeconds + picToBeUploadedTimeSeconds) <= 100000))
                        {
                            if ((filterFactor >= 0 && filterFactor <= 100))
                            {

                                if (nPictureAmount == 0 || filterTimeSeconds == 0 || filterFactor == 0)
                                {
                                    Console.WriteLine("{0}:{1:0#}:{2:0#}:{3:0#}", d, hh, mm, ss);
                                    // break;
                                }
                                else if (picToBeUploadedTimeSeconds == 0)
                                {
                                    Console.WriteLine("{0}:{1:0#}:{2:0#}:{3:0#}", d, hh, mm, ss);
                                    // Console.WriteLine("\u221E"); // infinity symbol
                                }
                                else
                                {

                                    double percentage = filterFactor / 100.0;
                                    timeFilteringAllPictures = ((long)nPictureAmount * filterTimeSeconds);
                                    filteredPictures = (int)Math.Ceiling(nPictureAmount * percentage);

                                    timeForUpload = (long)filteredPictures * picToBeUploadedTimeSeconds;
                                    totalTime = timeFilteringAllPictures + timeForUpload;

                                    d = (totalTime / 86400); // calculates the days

                                    totalTime %= 86400; // = 35200
                                    hh = (totalTime) / 3600; // calculates the hours

                                    totalTime %= 3600; // 2800
                                    mm = (totalTime) / 60; // calculates the minutes

                                    totalTime %= 60;
                                    ss = (totalTime);// calculates the seconds

                                    Console.WriteLine("{0}:{1:0#}:{2:0#}:{3:0#}", d, hh, mm, ss);


                                    // 10 d, 3 h, 21 m, 22 sek = 10 * 24*60*60 + 3 * 60*60 + 21 * 60 + 60 = 876120
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
                    Console.WriteLine("overflow value");
                }
                catch (FormatException)
                {
                    Console.WriteLine("wrong format");
                }

            } while ((Console.ReadLine()) != "x" || (Console.ReadKey(true).Key != ConsoleKey.X));

        }
    }
}
