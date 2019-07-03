using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEventos
{
    public class Factura
    {
        int Id;
        string Descripcion;
        string Direccion;

        public Factura(int _id, string _descripcion, string _direccion)
        {
            this.Id = _id;
            this.Descripcion = _descripcion;
            this.Direccion = _direccion;
        }
    }
}
