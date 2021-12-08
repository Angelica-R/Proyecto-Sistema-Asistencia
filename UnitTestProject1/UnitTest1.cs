using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using TrabajoGrupal.Negocio;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListarEmpleadosTest ()
        {
            DataTable tabla;

            tabla= ClsTrabajadorNegocio.Listar();
            int cantidadrows = tabla.Rows.Count;

            //Assert.AreEqual(cantidadrows, 3);

            Assert.AreNotEqual(cantidadrows, 0);
        }

        [TestMethod]
        public void LoginEmpleadosTest()
        {
            DataTable tabla;


            string usuario, clave;
            usuario = "74892212";
            clave = "12345";

            
            tabla = ClsTrabajadorNegocio.Loguin(usuario,clave);

            int cantidadrows = tabla.Rows.Count;

            Assert.AreEqual(cantidadrows, 1);
            
        }

        [TestMethod]
        public void InsertarEmpleadosTest()
        {
            String Respuesta;
            String Respuesta2;

            Respuesta = ClsTrabajadorNegocio.Insertar("Fatima", "Gomez", "74892219", "Enfermera", "15155");
            Respuesta2 = ClsTrabajadorNegocio.Insertar("Rafael", "Valdez", "74892212", "Empleado", "12345");

            //Assert.AreEqual(Respuesta, "Se Agrego Correctamente");

            Assert.AreNotEqual(Respuesta2, "Se Agrego Correctamente");
        }

        [TestMethod]
        public void EliminarEmpleadosTest()
        {
            String Respuesta;

            Respuesta = ClsTrabajadorNegocio.Eliminar(2);
            
            Assert.AreEqual(Respuesta, "Se elimino Correctamente");
            


        }


        [TestMethod]
        public void ActualizarEmpleadosTest()
        {
            String Respuesta;

            Respuesta = ClsTrabajadorNegocio.Modificar(2,"Fatima", "Gomez", "74892219", "Enfermera", "15155");

            Assert.AreEqual(Respuesta, "Se actualizo Correctamente");

        }

        [TestMethod]
        public void Insertar_Detalle_AsistenciaTest()
        {
            String Respuesta;

            Respuesta = ClsHojaNegocio.Insertar(1, 4, "ASISTIO", "22:14:07");
 
            Assert.AreEqual(Respuesta, "Se Agrego Correctamente");

        }

        [TestMethod]
        public void Activar_Detalle_AsistenciaTest()
        {
            String Respuesta;

            Respuesta = ClsHojaNegocio.Asistencia_ACT(1, 2,"22:14:07");

            Assert.AreEqual(Respuesta, "Se actualizo Correctamente");

        }

        [TestMethod]
        public void Insertar_HojaTest()
        {
            String Respuesta;

            Respuesta = ClsTablaAsistenciaNegocio.Insertar("18-07-2021", "9:45:07");

            Assert.AreEqual(Respuesta, "Se Agrego Correctamente");

        }

    }
}
