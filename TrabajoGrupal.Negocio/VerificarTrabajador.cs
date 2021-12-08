using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrabajoGrupal.Negocio
{
    public class VerificarTrabajador
    {

        public bool Verificar(string Dni, string Clave)
        {
            
            
            
            DataTable tabla = new DataTable();

            bool co = false;


            tabla = ClsTrabajadorNegocio.Loguin(Dni, Clave);


            if (tabla.Rows.Count <= 0)
            {
                co = true;

            }
            else
            {
                co = false;
            }
            

            return co;

        }




    }
}
