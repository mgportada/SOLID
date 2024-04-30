using System.Security.Cryptography;
using System.Text;

namespace SingleResponsibilityPrinciple.Problem
{
    public class UserService
    {
        private readonly UserRepository userRepository;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Usuario RegistrarUsuario(string nombreUsuario, string contraseña)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytesContraseña = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytesContraseña.Length; i++)
            {
                builder.Append(bytesContraseña[i].ToString("x2"));
            }
            string contraseñaEncriptada = builder.ToString();
            sha256Hash.Dispose();

            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Contraseña = contraseñaEncriptada
            };

            userRepository.GuardarUsuario(nuevoUsuario);
            return nuevoUsuario;

        }


    }
}
