﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ContenedorModulos
    {
        public ICollection<IModulo> Modulos { get; set; }
        public ContenedorModulos()
        {
            Modulos = new List<IModulo>();
        }
    }
}