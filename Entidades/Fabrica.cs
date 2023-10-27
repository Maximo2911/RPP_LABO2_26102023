﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;
        
        private Fabrica() 
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Fabrica(int capacidad) : this()
        {

        }

        public List<Vehiculo> Vehiculos { get { return this.vehiculos; } }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo) 
        {
            if(fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
                return fabrica;
            }
            return fabrica;
        }
        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo) 
        {
            foreach(Vehiculo vehiculoComparacion in fabrica.vehiculos)
            {
                if(vehiculoComparacion.GetType() == vehiculo.GetType() && vehiculoComparacion.ToString() == vehiculo.ToString())
                {
                    fabrica.vehiculos.Remove(vehiculo);
                }
            }
            return fabrica;
        }
    }
}
