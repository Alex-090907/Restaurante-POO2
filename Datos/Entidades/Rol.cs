using System.ComponentModel.DataAnnotations;

namespace Restaurante.Datos.Entidades
{
    // Rol que se asigna a los usuarios
    public class Rol
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Descripcion { get; set; }

        public bool Activo { get; set; } = true;

        // Un rol tiene muchos usuarios
        public List<Usuario> Usuarios { get; set; } = new();
    }
}