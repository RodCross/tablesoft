using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoft.temp
{
    public class Usuario
    {
        String email;
        String password;
        String rol;

        public Usuario()
        {
        }

        public Usuario(string email, string password, string rol)
        {
            this.email = email;
            this.password = password;
            this.rol = rol;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
