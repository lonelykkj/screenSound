using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screenSound.Models
{
    internal class Avaliacao
    {
        public Avaliacao(int not)
        {
            if (Nota < 0) Nota = 0;
            if (Nota > 10) Nota = 10;
            Nota = Nota;
        }
           
        public int Nota { get; }
        public static Avaliacao Parse(string texto)
        {
            int nota = int.Parse(texto);
            return new Avaliacao(nota);
        }
        
    }
}
