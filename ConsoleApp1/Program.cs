using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //StatConsole stata = new StatConsole();

            //stata.GetStatConsole();

            ClickHouse clStat = new ClickHouse();

            clStat.GetStatClickHouse("sum(Sum)");

            Console.WriteLine("END!");
            Console.ReadLine();

        }
    }
}
