﻿using System;
using System.Diagnostics;

namespace GestUAB
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Listening on port 8888");
            Console.WriteLine ("Press CTRL+C to quit :-)");
            Process.Start ("http://127.0.0.1:8888/");
            Starter.Start (8888, true);
        }
    }
}