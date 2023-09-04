using static OCR.Microservice.Model.Constants;

namespace OCR.Microservice.Model
{
    public class FileRequest
    {
        public byte[] Content { get;set;}
        public FileType FileType { get; set; }
    }
}