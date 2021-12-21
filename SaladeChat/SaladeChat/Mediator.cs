using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladeChat
{
    public class Mediator:IMediator
    {
        private string _NombredeGrupo = string.Empty;
        private List<Usuarios> _Usuarios = new List<Usuarios>();

        public Mediator(string NombredeGrupo) => _NombredeGrupo = NombredeGrupo;

        public string NombredelGrupo() => _NombredeGrupo;

        public void RegistrodeUsuarios(Usuarios usuarios)
        {
          
            var usuarioencontrado = _Usuarios.Where(q => q == usuarios).Count() > 0 ? true : false;

            if (!usuarioencontrado)
            {
                _Usuarios.Add(usuarios);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{usuarios.Obtenernombredeusuario()} (Se ha unido al grupo '{_NombredeGrupo}'!)");
            }

        }

        public void EnviarMensaje(Usuarios usuarios, string mensaje)
        {
            foreach (var GrupodeUsuario in _Usuarios)
                if (GrupodeUsuario != usuarios)
                    GrupodeUsuario.RecibirMensaje(mensaje);
        }


        public void AnularRegistrodeUsuario(Usuarios usuarios)
        {
            foreach (var grupodeUsuario in _Usuarios)
            {
                if (grupodeUsuario == usuarios)
                {
                    _Usuarios.Remove(usuarios);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{usuarios.Obtenernombredeusuario()} (Ha dejado el grupo '{_NombredeGrupo}'!)");
                    break;
                }
            }
        }


    }
}
