using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUniversidad
{
    internal class User
    {
        private string username;
        private string password;
        private string email;
        private string firstName;
        private string lastName;
        private DateTime fechaNac;
        private string direccion;
        private string telefono;

        public User() {}

        public User(string username, string pswd, string emal, string firstname, string lastname, DateTime fNac, string adress, string tel)
        {
            this.username = username;
            this.password = pswd;
            this.email = emal;  
            this.firstName = firstname;
            this.lastName = lastname;
            this.fechaNac = fNac;
            this.direccion = adress;
            this.telefono = tel;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
