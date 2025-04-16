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
