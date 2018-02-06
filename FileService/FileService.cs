using System;
using System.Collections.Generic;
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
            return new UploadResponse
            {
                UploadSucceeded = true,
                FileSize = uploadRequest.Stream.Length
            };
        }
    }
}
