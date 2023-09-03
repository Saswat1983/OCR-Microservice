using System;
using IronOcr;
using static OCR.Microservice.Model.Constants;

namespace OCR.Microservice.Business
{
    interface ICharacterRecogniser
    {
        string ReturnContent(Byte[] fileContent, FileType fileType);
    }
}
