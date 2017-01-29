using System;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean DEBUG = false;
            Boolean DEBUG = true;

            do
            {
                try
                {
                    if (DEBUG){ Console.Write("             pictureAmount: "); }
                    int pictureAmount = int.Parse(Console.ReadLine());

                    if (DEBUG) { Console.Write("         filterTimeSeconds: "); }
                    int filterTimeSeconds = int.Parse(Console.ReadLine());

                    if (DEBUG) { Console.Write("              filterFactor: "); }
                    int filterFactor = int.Parse(Console.ReadLine());

                    if (DEBUG) { Console.Write("picToBeUploadedTimeSeconds: "); }
                    int picToBeUploadedTimeSeconds = int.Parse(Console.ReadLine());
                    if (DEBUG) { Console.WriteLine("\n"); }

                    long totalTime = 0;
                    long d = 0;
                    long hh = 0;
                    long mm = 0;
                    long ss = 0;

                    //d:HH:mm:ss 
                    long timeFilteringAllPictures = 0L;
                    int goodPictures = 0;
                    long timeForUpload = 0L;
                    if ((pictureAmount >= 0 && pictureAmount <= 1000000))
                    {
                        if (((filterTimeSeconds + picToBeUploadedTimeSeconds) >= 0 &&
                            (filterTimeSeconds + picToBeUploadedTimeSeconds) <= 100000))
                        {
                            if ((filterFactor >= 0 && filterFactor <= 100))
                            {

                                if (pictureAmount == 0 || filterTimeSeconds == 0 || filterFactor == 0)
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
                                    timeFilteringAllPictures = ((long)pictureAmount * filterTimeSeconds);
                                    goodPictures = (int)Math.Ceiling(pictureAmount * (filterFactor / 100.0));
                                    if (goodPictures == 0)
                                    {
                                        Console.WriteLine("{0}:{1:0#}:{2:0#}:{3:0#}", d, hh, mm, ss);
                                        // break;
                                    }

                                    if (DEBUG)
                                    {
//Total pictures = 1 000, 50 % of them are useful->Filtered pictures = 500
//Total pictures *filter time = 1000 s
//Filtered pictures* upload time = 500 s
//Total time = 1500 s


                                        Console.WriteLine("  timeFilteringAllPictures: " + timeFilteringAllPictures);
                                        Console.WriteLine("            nPictureAmount: " + pictureAmount);
                                        Console.WriteLine("          filteredPictures: " + goodPictures);
                                    }

                                    timeForUpload = (long)goodPictures * picToBeUploadedTimeSeconds;
                                    totalTime = timeFilteringAllPictures + timeForUpload;

                                    if (DEBUG)
                                    {
                                        Console.WriteLine("             timeForUpload: " + timeForUpload);
                                        Console.WriteLine("picToBeUploadedTimeSeconds: " + picToBeUploadedTimeSeconds);
                                        Console.WriteLine("             timeForUpload: " + timeForUpload);
                                        Console.WriteLine("                 totalTime: " + totalTime);
                                    }

                                    d = (totalTime / 86400); // calculates the days

                           if (DEBUG) { Console.WriteLine("                         d: " + d); }

                                    totalTime %= 86400; // = 35200
                                    hh = (totalTime) / 3600; // calculates the hours

                                    if (DEBUG) { Console.WriteLine("                        hh: " + hh); }

                                    totalTime %= 3600; // 2800
                                    mm = (totalTime) / 60; // calculates the minutes

                                    if (DEBUG) { Console.WriteLine("                        mm: " + mm); }

                                    totalTime %= 60;
                                    ss = (totalTime);// calculates the seconds

                                    if (DEBUG) { Console.WriteLine("                        ss: " + ss); 
                                    Console.WriteLine(" =========================== "); }
                                    Console.WriteLine("       {0}:{1:0#}:{2:0#}:{3:0#}", d, hh, mm, ss);
                                    
                                    if (DEBUG) { Console.WriteLine("===========================");
                                        Console.WriteLine("\nPress Enter or write X to exit: "); }

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
