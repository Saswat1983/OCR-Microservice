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
            using (OcrInput input = new OcrInput())
            {
                // We can also select specific PDF page numnbers to OCR
                input.AddPdf("example.pdf", "password");
                result = ocr.Read(input);
                
            }
            return result.Text;
        }
    }
}
