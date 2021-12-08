using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoGrupal.Entidad;

namespace TrabajoGrupal.AccesoDatos
{
    public class ClsTrabajadorDatos
    {
        //Listar
        public DataTable Listar()
        {
            //SqlDataReader Resultado;
            //DataTable Tabla = new DataTable();
            //SqlConnection sqlCnx = new SqlConnection();
            //try
            //{
            //    sqlCnx = ClsConexionDatos.getInstancia().establecerConexion();
            //    SqlCommand comando = new SqlCommand("SP_Trabajador_Listar", sqlCnx);
            //    sqlCnx.Open();
            //    Resultado = comando.ExecuteReader();
            //    Tabla.Load(Resultado);
            //    return Tabla;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;

            //}
            //finally
            //{
            //    if (sqlCnx.State == ConnectionState.Open)
            //        sqlCnx.Close();
            //}


            DataTable datos = new DataTable();

            datos.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Dni"), new DataColumn("Rol"), new DataColumn("Clave") });

            datos.Rows.Add(1, "Rafael", "Valdez", "74892212", "Empleado", "12345");
            datos.Rows.Add(2, "Jesus", "Apaza", "74892213", "Gerente", "51234");
            datos.Rows.Add(3, "Alfons", "Elric", "74892214", "Empleado", "11525");

            return datos;
        }
        //Insertar
        public string Insertar(ClsTrabajadorEntidad ObjTrabajador)
        {
            string Rpta = "";
            //SqlConnection sqlCnx = new SqlConnection();
            //try
            //{
            //    sqlCnx = ClsConexionDatos.getInstancia().establecerConexion();
            //    SqlCommand comando = new SqlCommand("SP_Trabajador_Insertar", sqlCnx);
            //    comando.CommandType = CommandType.StoredProcedure;

            //    comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = ObjTrabajador.Nombre;
            //    comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = ObjTrabajador.Apellido;
            //    comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = ObjTrabajador.DNI;
            //    comando.Parameters.Add("@prol", SqlDbType.VarChar).Value = ObjTrabajador.Rol;
            //    comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = ObjTrabajador.Clave;

            //    sqlCnx.Open();

            //    Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar registro";
            //}
            //catch (Exception ex)
            //{
            //    Rpta = ex.Message;

            //}
            //finally
            //{
            //    if (sqlCnx.State == ConnectionState.Open)
            //        sqlCnx.Close();
            //}
            DataTable datos = new DataTable();

            datos.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Nombre"), new DataColumn("Apellido"), 
            new DataColumn("Dni"), new DataColumn("Rol"), new DataColumn("Clave") });

            datos.Rows.Add(1, "Rafael", "Valdez", "74892212", "Empleado", "12345");
            datos.Rows.Add(2, "Jesus", "Apaza", "74892213", "Gerente", "51234");
            datos.Rows.Add(3, "Alfons", "Elric", "74892214", "Empleado", "11525");


            datos.Rows.Add(4, ObjTrabajador.Nombre, ObjTrabajador.Apellido, ObjTrabajador.DNI, ObjTrabajador.Rol, ObjTrabajador.Clave);

            if (datos.Rows.Count.Equals(4))
            {
                Rpta = "Se Agrego Correctamente";
            }

            return Rpta;
        }
        //Modificar
        public string Modificar(ClsTrabajadorEntidad ObjTrabajador)
        {
            string Rpta = "";

            //SqlConnection sqlCnx = new SqlConnection();
            //try
            //{
            //    sqlCnx = ClsConexionDatos.getInstancia().establecerConexion();
            //    SqlCommand comando = new SqlCommand("SP_Trabajador_Modificar", sqlCnx);
            //    comando.CommandType = CommandType.StoredProcedure;
            //    comando.Parameters.Add("@ptrabajador_id", SqlDbType.Int).Value = ObjTrabajador.Id_Trabajador;
            //    comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = ObjTrabajador.Nombre;
            //    comando.Parameters.Add("@papellido", SqlDbType.VarChar).Value = ObjTrabajador.Apellido;
            //    comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = ObjTrabajador.DNI;
            //    comando.Parameters.Add("@prol", SqlDbType.VarChar).Value = ObjTrabajador.Rol;
            //    comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = ObjTrabajador.Clave;
            //    sqlCnx.Open();

            //    Rpta = comando.ExecuteNonQuery() == 1 ? "OK " : "No se pudo actualizar registro";
            //}
            //catch (Exception ex)
            //{
            //    Rpta = ex.Message;

            //}
            //finally
            //{
            //    if (sqlCnx.State == ConnectionState.Open)
            //        sqlCnx.Close();
            //}
            DataTable datos = new DataTable();

            datos.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Dni"), new DataColumn("Rol"), new DataColumn("Clave") });

            datos.Rows.Add(1, "Rafael", "Valdez", "74892212", "Empleado", "12345");
            datos.Rows.Add(2, "Jesus", "Apaza", "74892213", "Gerente", "51234");
            datos.Rows.Add(3, "Alfons", "Elric", "74892214", "Empleado", "11525");


            for (int i = 0; i < datos.Rows.Count; i++)
            {
                if (Convert.ToInt32(datos.Rows[i][0]).Equals(ObjTrabajador.Id_Trabajador))
                {

                    datos.Rows[i][1] = ObjTrabajador.Nombre;
                    datos.Rows[i][2] = ObjTrabajador.Apellido;
                    datos.Rows[i][3] = ObjTrabajador.DNI;
                    datos.Rows[i][4] = ObjTrabajador.Rol;
                    datos.Rows[i][5] = ObjTrabajador.Clave;

                }
            }

            if (datos.Rows[1][3].Equals(ObjTrabajador.DNI))
            {
                Rpta = "Se actualizo Correctamente";
            }

            return Rpta;


        }
        //Eliminar
        public string Eliminar(int id)
        {
            string Rpta = "";

            //SqlConnection sqlCnx = new SqlConnection();
            //try
            //{
            //    sqlCnx = ClsConexionDatos.getInstancia().establecerConexion();
            //    SqlCommand comando = new SqlCommand("SP_Trabajador_Eliminar", sqlCnx);
            //    comando.CommandType = CommandType.StoredProcedure;
            //    comando.Parameters.Add("@ptrabajador_id", SqlDbType.Int).Value = Id;
            //    sqlCnx.Open();

            //    Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar registro";
            //}
            //catch (Exception ex)
            //{
            //    Rpta = ex.Message;

            //}
            //finally
            //{
            //    if (sqlCnx.State == ConnectionState.Open)
            //        sqlCnx.Close();
            //}

            DataTable datos = new DataTable();

            datos.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Dni"), new DataColumn("Rol"), new DataColumn("Clave") });

            datos.Rows.Add(1, "Rafael", "Valdez", "74892212", "Empleado", "12345");
            datos.Rows.Add(2, "Jesus", "Apaza", "74892213", "Gerente", "51234");
            datos.Rows.Add(3, "Alfons", "Elric", "74892214", "Empleado", "11525");

            DataTable subdatos = new DataTable();
            subdatos.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Dni"), new DataColumn("Rol"), new DataColumn("Clave") });

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                if ( Convert.ToInt32(datos.Rows[i][0]).Equals(id))
                {

                    datos.Rows.Remove(datos.Rows[i]);

                }
            }

            if (datos.Rows.Count.Equals(2))
            {
                Rpta = "Se elimino Correctamente";
            }

            return Rpta;
        }


        //Buscar(ID)
        public DataTable Loguin(string dni, string clave)
        {
            //SqlDataReader Resultado;
            //DataTable Tabla = new DataTable();
            //SqlConnection sqlCnx = new SqlConnection();
            //try
            //{
            //    sqlCnx = ClsConexionDatos.getInstancia().establecerConexion();
            //    SqlCommand comando = new SqlCommand("SP_Trabajador_EncontrarID", sqlCnx);
            //    comando.CommandType = CommandType.StoredProcedure;
            //    comando.Parameters.Add("@pdni", SqlDbType.VarChar).Value = dni;
            //    comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = clave;

            //    sqlCnx.Open();
            //    Resultado = comando.ExecuteReader();
            //    Tabla.Load(Resultado);
            //    return Tabla;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;

            //}
            //finally
            //{
            //    if (sqlCnx.State == ConnectionState.Open)
            //        sqlCnx.Close();
            //}

            DataTable datos = new DataTable();

            datos.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Dni"), new DataColumn("Rol"), new DataColumn("Clave") });

            datos.Rows.Add(1, "Rafael", "Valdez", "74892212", "Empleado", "12345");
            datos.Rows.Add(2, "Jesus", "Apaza", "74892213", "Gerente", "51234");
            datos.Rows.Add(3, "Alfons", "Elric", "74892214", "Empleado", "11525");

            DataTable subdatos = new DataTable();
            subdatos.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Nombre"), new DataColumn("Apellido"), new DataColumn("Dni"), new DataColumn("Rol"), new DataColumn("Clave") });

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                if (datos.Rows[i][3].Equals(dni) && datos.Rows[i][5].Equals(clave))
                {

                    subdatos.Rows.Add(datos.Rows[i][0], datos.Rows[i][1], datos.Rows[i][2], datos.Rows[i][3], datos.Rows[i][4], datos.Rows[i][5]);

                }
            }

            return subdatos;



        }

        




    }
}
