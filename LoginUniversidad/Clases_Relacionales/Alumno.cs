using System;
using System.Collections.Generic;

namespace LoginUniversidad.Clases
{
    internal class Alumno
    {
        private List<Materia> materias;
        private string username;
        private string password;
        private string email;
        private string firstName;
        private string lastName;
        private DateTime fechaNac;
        public int Edad => (DateTime.Now - fechaNac).Days / 365;
        private string direccion;
        private string telefono;

        public Alumno() { }

        public Alumno(string firstname, string lastname, string username, string pswd, string emal)
        {
            this.username = username;
            password = pswd;
            email = emal;
            firstName = firstname;
            lastName = lastname;
            fechaNac = DateTime.Now;
            direccion = "";
            telefono = "";
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        internal List<Materia> Materias { get => materias; set => materias = value; }
    }
}
