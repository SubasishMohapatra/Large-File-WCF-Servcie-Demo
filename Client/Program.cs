using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileServiceClient = new FileService.FileServiceClient();
            //const int bufferSize = 2048;
            //byte[] buffer = new byte[bufferSize];
            //using (FileStream outputStream = new FileStream(path,
            //    FileMode.Open, FileAccess.Read))
            //{
            //    int bytesRead = request.Stream.Read(buffer, 0, bufferSize);
            //    while (bytesRead > 0)
            //    {
            //        outputStream.Write(buffer, 0, bytesRead);
            //        bytesRead = request.Stream.Read(buffer, 0, bufferSize);
            //    }
            //    outputStream.Close();
            //}
            long fileSize;
            fileServiceClient.Upload("Test1", new FileStream(@"C:\Users\SUMOHAP\Desktop\TFS Error.jpg", FileMode.Open, FileAccess.Read), out fileSize);
            Console.WriteLine($"File received{0} of size {1}", "Test1", fileSize);
        }
    }
}
