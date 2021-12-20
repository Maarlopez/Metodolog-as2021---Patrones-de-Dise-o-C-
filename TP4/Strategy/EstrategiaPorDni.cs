﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Strategy;

namespace TP4.Strategy
{
    public class EstrategiaPorDni: EstrategiaDeAlumnosComparables
    {
        public bool sosIgual(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Dni == ((AlumnoAbstracto)elemento2).Dni;
        }

        public bool sosMayor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Dni < ((AlumnoAbstracto)elemento2).Dni;
        }

        public bool sosMenor(Comparable elemento, Comparable elemento2)
        {
            return ((AlumnoAbstracto)elemento).Dni > ((AlumnoAbstracto)elemento2).Dni;
        }
    }
}
