using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinApp.ClientApp.src.model
{
    public class Rutine
    {
        private String navn { get; set; }
        private int intervall { get; set; }

        public Rutine(String navn, int intervall)
        {
            this.navn = navn;
            this.intervall = intervall;
        }
    }
}
