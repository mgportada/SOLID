namespace SingleResponsibilityPrinciple.Problem
{
    public class UserRepository
    {

        private List<Usuario> usuarios = new List<Usuario>();

        public void GuardarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public Usuario BuscarUsuarioPorNombre(string nombreUsuario)
        {
            return usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }

        public bool ExisteUsuario(string nombreUsuario)
        {
            return usuarios.Any(u => u.NombreUsuario == nombreUsuario);
        }
    }
}
