using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LargeFileOperations
{
    public class FileService : IFileService
    {
        public UploadResponse Upload(UploadRequest uploadRequest)
        {
            long fileSize;
            var fileStream = uploadRequest.Stream;
            try
            {
                const int bufferSize = 1024;
                byte[] buffer = new byte[bufferSize];

                int bytesRead = fileStream.Read(buffer, 0, bufferSize);
                fileSize = bytesRead;
                while (bytesRead > 0)
                {
                    bytesRead = fileStream.Read(buffer, 0, bufferSize);
                    fileSize += bytesRead;
                }
                return new UploadResponse
                {
                    UploadSucceeded = true,
                    FileSize = fileSize
                };
            }
            catch (IOException ex)
            {
                throw new FaultException<IOException>(ex, new FaultReason(ex.Message));
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
