using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoGrupal.AccesoDatos;
using TrabajoGrupal.Entidad;

namespace TrabajoGrupal.Negocio
{
    public class InsertarTrabajor
    {
        public string Insertar(string Nombre, string Apellido, string Dni, string Rol, string Clave)
        {
            ClsTrabajadorDatos objTrabajador = new ClsTrabajadorDatos();

            ClsTrabajadorEntidad objEntiTrabajador = new ClsTrabajadorEntidad();

            objEntiTrabajador.Nombre = Nombre;
            objEntiTrabajador.Apellido = Apellido;
            objEntiTrabajador.DNI = Dni;
            objEntiTrabajador.Rol = Rol;
            objEntiTrabajador.Clave = Clave;
            return objTrabajador.Insertar(objEntiTrabajador);

        }
    }
}
