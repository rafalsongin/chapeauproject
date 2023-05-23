using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace SomerenService
{
    public class ErrorLogger
    {
        // ErrorLog.txt file is in "bin\Debug\net6.0-windows" folder
        private string filename = "ErrorLog.txt";

        public void LogError(string message)
        {
            StreamWriter writer = new StreamWriter(filename, true);

            if (File.Exists(filename))
            {
                writer.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - {message}");
            }

            writer.Close();
        }
    }
}