namespace P01DAW_Reservas.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty; // Cliente o Empleado
    }
}
