using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1;

public sealed class Logger
{
    public void Log(string message)
    {
        //save to BD
        //write to console
        Console.WriteLine($"Action performed: {message}");
    }
}
