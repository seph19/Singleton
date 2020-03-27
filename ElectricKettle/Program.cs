using System;

namespace ElectricKettle
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //var status = new Status();
            //string empty = "Empty";
            //status.status = empty;
            
            //string description = Status.Empty.GetType().de;
            Console.WriteLine("Electric Kettle!");
            Console.Write("DO you want to start?(Y/N):");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                Start.Process();
            }
            else
            {
                End.Message();
            }

        }

    }
   

}
