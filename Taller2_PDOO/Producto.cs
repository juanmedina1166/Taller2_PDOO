﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_PDOO
{
    internal class Producto
    {
        private string nombre;
        private int tamano;
        private float precio;
        private float peso;
        private int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Tamano { get => tamano; set => tamano = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Peso { get => peso; set => peso = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto()
        {

        }
    }
}
