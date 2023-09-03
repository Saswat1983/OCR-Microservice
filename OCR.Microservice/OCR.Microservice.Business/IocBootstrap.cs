using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR.Microservice.Business
{
    public class IocBootstrap
    {
        public IocBootstrap()
        {
            var container = new Container(_ =>
            {
                _.For<ICharacterRecogniser>().Use<CharacterRecogniser>();
            });
        }
    }
}
