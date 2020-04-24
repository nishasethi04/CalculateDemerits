using System;
/*Write a program for a speed camera that asks the user to enter the speed limit. Once set, 
the program asks for the speed of a car.
If the user enters a value less than the speed limit, program should display Ok on the console.
If the value is above the speed limit, the program should calculate the number of 
demerit points. 
For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
the console. If the number of demerit points is above 12, the program should display License Suspended.
 */
         
namespace CalculateDemerit
{
    class Program
    {
        static void Main(string[] args)
        {
                   Console.Write("What is the speed limit? ");
                    var speedLimit = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is the speed of this car? ");
                    var carSpeed = Convert.ToInt32(Console.ReadLine());

                    if (carSpeed < speedLimit)
                        Console.WriteLine("Ok");
                    else
                    {
                        const int kmPerDemeritPoint = 5;
                        var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                        if (demeritPoints > 12)
                            Console.WriteLine("License Suspended");
                        else

                            Console.WriteLine("Demerit points: " + demeritPoints);
                    }
                }
        }
    }


