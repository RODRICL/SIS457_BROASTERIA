using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebBroasteria.Models;

public partial class Categorium
{
    public int Id { get; set; }

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    public string Descripcion { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
