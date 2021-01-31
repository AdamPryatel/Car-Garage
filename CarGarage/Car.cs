using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }

        // Write methods to pass the tests


        public string SetMake(string make)                               // Done
        {
            Make = make;
            return Make;
        }

        public string SetModel(string model)                              // Done
        {
            Model = model;
            return Model;
        }

        public int GetSpeed()                                              // Done
        {
            return Speed;
        }

        public bool IsSpeeding()                                           // Done
        {
            if (Speed > 70)

                return true;

            else
                return false;
        }

        public void Accelerate()                                           // Done
        {

                if (Speed < 100)
                {
                    if (Make == "Ferrari")

                        Speed += 20;

                    else
                    {
                        Speed += 10;
                    }
                }
                else
                {
                    Speed = Speed;
                }
        }

        public void Brake()
        {

            if (Speed > 7)      
            {                                                     
                if (AutoBrakeActive == true)         
                {                                      
                    Speed /= 2;
                }


                else 
                {
                    Speed -= 7;
                }

            }
            else
            {
                Speed -= Speed;
            }
        }
    }
}
