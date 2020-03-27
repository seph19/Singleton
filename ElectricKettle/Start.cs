using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace ElectricKettle
{
    public class Start
    {
        static int fill = 3000;
        static int boil = 8000;
        static int drain = 5000;

        static string empty = "Empty";
        static string inProgress = "InProgress";
        static string boiled = "Boiled";

        static string kettle = empty;

        public static void Process()
        {
            var status = GetStatus.GetDescription(Status.Empty);

            Console.WriteLine("Starting. . .");
            status = Fill(status);
            status = Boil(status);
            status = Drain(status);
            Thread.Sleep(drain);
        }
        public static void End()
        {
            Console.WriteLine("Bye!!!!");
        }

        public static string Fill(string status)
        {
            Thread.Sleep(fill);
            if (status == empty)
            {
                Console.WriteLine("Filling . . . .");
            }
            return GetStatus.GetDescription(Status.Inprogress);
        }

        public static string Boil(string status)
        {
            Thread.Sleep(boil);
            if (status == inProgress)
            {
                Console.WriteLine("Boiling . . . .");
            }
            return GetStatus.GetDescription(Status.Boiled);
        }

        public static string Drain(string status)
        {
            Thread.Sleep(drain);
            if (status == boiled)
            {
                Console.WriteLine("Draining . . . .");
            }
            return GetStatus.GetDescription(Status.Empty);
        }
    }
}
