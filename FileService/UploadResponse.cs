using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LargeFileOperations
{
    [MessageContract]
    public class UploadResponse
    {
        [MessageBodyMember(Order = 1)]
        public bool UploadSucceeded { get; set; }

        [MessageBodyMember(Order = 2)]
        public long FileSize { get; set; }
    }
}
