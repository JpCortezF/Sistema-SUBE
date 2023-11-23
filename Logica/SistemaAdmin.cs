using Biblioteca_DataBase;
using Biblioteca_Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class SistemaAdmin
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>();
        List<Administrador> admins = new List<Administrador>();
        DataBase<Administrador> data = new DataBase<Administrador>();
        Administrador admin = new Administrador();

        public Administrador cargarAdmin(string email, string dni)
        {
            string query1 = "SELECT * FROM admins WHERE dni = @dni AND email = @email";
            parameters.Add("@dni", dni);
            parameters.Add("@email", email);         
            admins = data.Select(query1, parameters, admin.Map);
            admin = admins.FirstOrDefault();

            return admin;
        }
    }
}
