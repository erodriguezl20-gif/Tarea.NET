using System.ComponentModel.DataAnnotations;
namespace ApiClientes.Models
{
    public class Cliente
    {
        [Key]
        public int Id_cliente { get; set; }

        [Required]
        public string CUI { get; set; } = string.Empty;

        [Required]
        public string NIT { get; set; } = string.Empty;

        [Required]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        public string Direccion { get; set; } = string.Empty;

        [Required]
        public string Telefono { get; set; } = string.Empty;

        [Required]
        public DateTime Fecha_Nacimiento { get; set; }
    }
}