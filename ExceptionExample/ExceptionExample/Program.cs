﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace UserDefinedException 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Temperature temp = new Temperature(); 
            try 
            { 
                temp.showTemp(); 
            } 
            catch (TempIsZeroException e) 
            { 
                Console.WriteLine("TempIsZeroException: {0}", e.Message); } 
            Console.ReadKey(); 
        } 
    } 
}
public class TempIsZeroException : Exception 
{ 
    public TempIsZeroException(string message) : base(message) 
    { } 
}
public class Temperature 
{ 
    int temperature = 0; 
    public void showTemp() 
    { 
        if (temperature == 0) 
        { 
            throw new TempIsZeroException("Zero Temperature found"); 
        } 
        else 
        { 
            Console.WriteLine("Temperature: {0}", temperature); 
        } 
    } 
}
