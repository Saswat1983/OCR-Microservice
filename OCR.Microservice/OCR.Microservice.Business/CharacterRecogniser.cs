using OCR.Microservice.Model;
using System;
using IronOcr;
using static OCR.Microservice.Model.Constants;

namespace OCR.Microservice.Business
{
    public class CharacterRecogniser : ICharacterRecogniser
    {
        public string ReturnContent(Byte[] fileContent, FileType fileType)
        {
            OcrResult result = null;
            IronTesseract ocr = new IronTesseract();
            using (OcrInput input = new OcrInput(fileContent))
            {
                result = ocr.Read(input);
            }
            return result.Text;
        }
    }
}
