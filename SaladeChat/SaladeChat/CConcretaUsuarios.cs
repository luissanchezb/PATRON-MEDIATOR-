using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladeChat
{
    public  class CConcretaUsuarios:Usuarios
    {

        public CConcretaUsuarios(IMediator mediator, string NombreUsuario ) : base(mediator, NombreUsuario) { }

        public override void RecibirMensaje(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t{NombredeUsuario} (Mensaje Recibido) > {mensaje}");
        }

        public override void EnviarMensaje(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{NombredeUsuario} (Enviando Mensaje) > {mensaje}");
            Mediator.EnviarMensaje(this, mensaje);
        }
    }
}
