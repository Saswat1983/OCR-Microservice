using OCR.Microservice.Model;
using System;
using IronOcr;
using static OCR.Microservice.Model.Constants;

namespace OCR.Microservice.Biz
{
    public class CharacterRecogniser : ICharacterRecogniser
    {
        public string ReturnContent(Byte[] fileContent, FileType fileType)
        {
            IronTesseract ocr = new IronTesseract();
            using (OcrInput input = new OcrInput())
            {
                // We can also select specific PDF page numnbers to OCR
                input.AddPdf("example.pdf", "password");
                OcrResult result = ocr.Read(input);
                Console.WriteLine(result.Text);
                // 1 page for every page of the PDF
                Console.WriteLine($"{result.Pages.Count()} Pages");
            }

        }
    }
}
