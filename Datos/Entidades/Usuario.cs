using System.ComponentModel.DataAnnotations;

namespace Restaurante.Datos.Entidades
{
    // Persona que puede ingresar al sistema
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string NombreCompleto { get; set; } = string.Empty;

        // Se guarda el hash, nunca la contraseña en texto plano
        [Required]
        [MaxLength(200)]
        public string PasswordHash { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;

        // Cada usuario pertenece a un rol
        public int RolId { get; set; }
        public Rol? Rol { get; set; }
    }
}