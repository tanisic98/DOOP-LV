﻿using System;
using System.Collections.Generic;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. zadatak
            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Book("Knjiga"));
            rentables.Add(new Video("Kazeta"));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(rentables);
            printer.PrintTotalPrice(rentables);
        }
    }
}
