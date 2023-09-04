using OCR.Microservice.Model;
using System;
using IronOcr;
using static OCR.Microservice.Model.Constants;

namespace OCR.Microservice.Biz
{
    interface ICharacterRecogniser
    {
        string ReturnContent(Byte[] fileContent, FileType fileType);
    }
}
