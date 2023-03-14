using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPolimorfismoCS
{
    internal class ContactoEmpleado : Persona
    {

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");

            }
        }
        public string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public ContactoEmpleado() : base()
        {
            telefono = string.Empty;
            correo = string.Empty;
        }
        public ContactoEmpleado(string nombre, DateTime? fechaN, string telefono, string correo) : base(nombre, fechaN)
        {
            this.telefono = telefono;
            this.correo = correo;
        }
        public override string ToString()
        {
            return base.ToString() + " " + telefono + " " + correo;
        }
    }
}
