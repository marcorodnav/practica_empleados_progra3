using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Upi
{
    public partial class Insertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void idBtnInsertar_Click(object sender, EventArgs e)
        {
            string connectionStringEmpleados = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(connectionStringEmpleados);
            conexion.Open();
            SqlCommand comando = new SqlCommand("exec PROCEDIMIENTO_INSERTAR_EMPLEADO " + int.Parse(IdTextIdEmpleado.Text) +", '"+idTextNombre.Text+"', '"+idTextDireccion.Text+"'",conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            idLabelExito.Text = "Empleado creado!";
        }
    }
}