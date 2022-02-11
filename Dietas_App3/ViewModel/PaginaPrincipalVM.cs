using Dietas_App3.Model;
using Dietas_App3.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Dietas_App3.ViewModel
{
    class PaginaPrincipalVM: NotifyPropertyBase

    {
        public Usuario Usuario { get; set; }
        private Boolean NuevoUsuario = true;
        public PaginaPrincipalVM()
        {
            Task<List<Usuario>> u = UsuarioDAO.GetAllAsync();
            List<Usuario> ll = u.Result;
            if (ll.Count > 0)
            {
                Usuario = ll[0];
                NuevoUsuario = false;
            }
            else
            {
                Usuario = new Usuario();
            }
            
        }
        internal Boolean AñadirUsuario()
        {
            if (NuevoUsuario)
            {
                UsuarioDAO.AñadirUsuarioAsync(Usuario).Wait();
                NuevoUsuario = false;
                return true;
            }
            else
            {
                UsuarioDAO.ModificarUsuarioAsync(Usuario).Wait();
                return false;
            }

        }
        internal void AñadirNuevoUsuario()
        {
            Usuario = new Usuario();
            UsuarioDAO.AñadirUsuarioAsync(Usuario);
            
            OnPropertyChanged("Usuario");
            NuevoUsuario = true;
        }
    }
}
