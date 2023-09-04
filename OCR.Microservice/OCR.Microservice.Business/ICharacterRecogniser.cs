using System;
using IronOcr;
using static OCR.Microservice.Model.Constants;

namespace OCR.Microservice.Business
{
    public interface ICharacterRecogniser
    {
        string ReturnContent(Byte[] fileContent, FileType fileType);
    }
}
