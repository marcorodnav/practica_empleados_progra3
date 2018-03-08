using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Upi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void idBotonLogin_Click(object sender, EventArgs e)
        {
            string connectionStringEmpleados = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(connectionStringEmpleados);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from usuario where usaurio ='"+idTextUsuario.Text+"' and clave='"+idTextClave.Text+"'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                idLabelUsuarioExiste.Text = "El usuario " + registro["usaurio"] + " si existe";
            } else
            {
                idLabelUsuarioExiste.Text = "El usuario " + idTextUsuario.Text + " no existe";
            }
            conexion.Close();
            
        }
    }
}