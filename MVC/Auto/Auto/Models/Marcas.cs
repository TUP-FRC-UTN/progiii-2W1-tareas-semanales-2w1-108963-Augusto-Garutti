using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto.Models
{
    public class Marcas
    {
        int idMarca;
        string nombre;

        public Marcas(int idMarca=0, string nombre = "")
        {
            this.idMarca = idMarca;
            this.nombre = nombre;
        }

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}