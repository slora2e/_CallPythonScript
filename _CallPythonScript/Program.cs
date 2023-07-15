using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu;
using Emgu.CV.Structure;
using Emgu.CV.Reg;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace PythonProject
{
    public class PythonOperation
    {
        static void Main(string[] args)
        {
            // Initialize the Python engine
            PythonEngine.Initialize();

            // Load the Python script
            dynamic opImageModule = PythonEngine.ModuleFromString("_HED", File.ReadAllText("_HED.py"));

            // We call the Python function
            dynamic imgOut = opImageModule._HED("C:\\Users\\slorate\\Desktop\\py\\-6+5_Cut.bmp");

            // Convert dynamic to string

            string idd = Convert.ToString(imgOut);
            //byte[] bytes = Encoding.Unicode.GetBytes(idd);
            char[] se = idd.ToCharArray();

            Console.WriteLine(se);
        }
    }
}