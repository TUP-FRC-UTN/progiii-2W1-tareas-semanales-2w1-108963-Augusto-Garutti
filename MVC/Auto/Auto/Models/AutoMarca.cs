using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class AutoMarca
    {
        int idMarca;
        string nombre;
        string patente;
        int km;
        bool promocion;
        float precio;

        public AutoMarca(int idMarca=0, string nombre="", string patente="", int km=0, bool promocion=false, float precio=0)
        {
            this.idMarca = idMarca;
            this.nombre = nombre;
            this.patente = patente;
            this.km = km;
            this.promocion = promocion;
            this.precio = precio;
        }

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Patente { get => patente; set => patente = value; }
        public int Km { get => km; set => km = value; }
        public bool Promocion { get => promocion; set => promocion = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}