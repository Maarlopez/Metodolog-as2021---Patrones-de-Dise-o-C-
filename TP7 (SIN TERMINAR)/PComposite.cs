﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP7.Adapter;
using TP7.Factory_Method;
using TP7.Iterator;
using TP7.Proxy;

namespace TP7
{
    public class PComposite
    {
        public static void Run()
        {
            Pila p = new Pila();
            Aula a = new Aula();
            p.setOrdenInicio(new OrdenInicio(a));
            p.setOrdenLlegaAlumno(new OrdenLlegaAlumno(a));
            p.setOrdenAulaLlena(new OrdenAulaLlena(a));
            Helper.Llenar(p, "5");



            //Teacher teacher = new Teacher();

            //IAlumno alumnoComp = (AlumnoComposite)FabricaDeComparables.CrearComparable("6");
            //IAlumno alumnoComp2 = (AlumnoComposite)FabricaDeComparables.CrearComparable("6");

            //Student s1 = new AdaptadorAlumno(alumnoComp);
            //Student s2 = new AdaptadorAlumno(alumnoComp2);

            //teacher.goToClass(s1);
            //teacher.goToClass(s2);

            //teacher.teachingAClass();
        }

    }
}
