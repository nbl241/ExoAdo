﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoAdo
{
    class SaveFile
    {
        static string path = @"c:\temp\listPeople.csv";
        string delimiter = ",";

        List<People> peoples = new List<People>();

        public void WriteInFile(List<People> peoples)
        {
            if (!File.Exists(path))
            {
                //Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("{0}");
                    sw.WriteLine("{1}");
                    sw.WriteLine("{2}");
                    sw.WriteLine("{3}");
                    sw.WriteLine("{4}");
                    sw.WriteLine("{5}");
                }
            }
            //Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }
}
