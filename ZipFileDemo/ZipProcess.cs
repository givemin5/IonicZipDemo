using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipFileDemo
{
    class ZipProcess
    {
        private string sourcePath;
        private string targetPath;

        public ZipProcess(string sourcePath, string targetPath)
        {
            this.sourcePath = sourcePath;
            this.targetPath = targetPath;
        }

        public void Do()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            string zipFileName = $"Backup_{date}.zip";

            string fullZipPath = $"{targetPath}\\{zipFileName}";

            FileInfo file = new FileInfo(fullZipPath);

            using (ZipFile zip = new ZipFile())
            {
                zip.AlternateEncodingUsage = ZipOption.Default;
                zip.AddDirectory(sourcePath);
                zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");

                if (file.Exists)
                    file.Delete();

                zip.Save(fullZipPath);
            }
        }
    }
}
