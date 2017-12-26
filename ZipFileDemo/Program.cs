using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\SourceFiles";
            string targetPath = @"D:\Backup";

            ZipProcess zipProcess = new ZipProcess(sourcePath, targetPath);

            zipProcess.Do();

        }
    }
}
