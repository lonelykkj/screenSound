using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace screenSound.Models
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        double Media { get; } 
    }
}