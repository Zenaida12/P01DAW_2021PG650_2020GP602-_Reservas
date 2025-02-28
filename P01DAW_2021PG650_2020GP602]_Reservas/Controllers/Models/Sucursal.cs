namespace P01DAW_Reservas.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Administrador { get; set; } = string.Empty;
        public int NumeroEspacios { get; set; }
    }
}
