using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronDiseño.Models
{
    public class CatalogoAnio
    {   
        private static CatalogoAnio instancia = null;
        public string anioAct = "";
        public string anioAct1 = "";
        public string anioAct2 = "";

        public CatalogoAnio() {
            anioAct = "2021";
            anioAct1 = "2020";
            anioAct2 = "2019";
        }

        public static CatalogoAnio Instanciar {
            get {
                if (instancia == null) {
                    instancia = new CatalogoAnio();
                }
                return instancia;
            }
        }
    }
}
