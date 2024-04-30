namespace SingleResponsibilityPrinciple.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository repository = new UserRepository();

            UserService userManager = new UserService(repository);

            var nuevoUsuario = userManager.RegistrarUsuario("usuario1", "contraseña123");
            Console.WriteLine($"Usuario registrado: {nuevoUsuario.NombreUsuario}");
        }
    }
}