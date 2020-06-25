using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class Autos
    {
        int idAuto;
        string patente;
        int idMarca;
        int km;
        bool promocion;
        float precio;

        public Autos(int idAuto=0, string patente="", int idMarca=0, int km=0, bool promocion= false, float precio=0)
        {
            this.idAuto= idAuto;
            this.patente = patente;
            this.idMarca = idMarca;
            this.km = km;
            this.promocion = promocion;
            this.precio = precio;

        }
        public int IdAuto { get => idAuto; set => idAuto = value; }
        public string Patente { get => patente; set => patente = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public int Km { get => km; set => km = value; }
        public bool Promocion { get => promocion; set => promocion = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}