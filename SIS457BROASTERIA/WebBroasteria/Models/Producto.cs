﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebBroasteria.Models;

public partial class Producto
{
    public int Id { get; set; }

    public int IdCategoria { get; set; }

    [Required(ErrorMessage = "El codigo es obligatorio.")]
    public string Codigo { get; set; } = null!;

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "La descripción es obligatoria.")]
    public string Descripcion { get; set; } = null!;

    [Required(ErrorMessage = "El stock de obligatorio.")]
    public int Stock { get; set; }

    [Required(ErrorMessage = "El precio de venta es obligatorio.")]
    public decimal? PrecioVenta { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual ICollection<HistorialCompra> HistorialCompras { get; set; } = new List<HistorialCompra>();

    public virtual ICollection<HistorialVentum> HistorialVenta { get; set; } = new List<HistorialVentum>();

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
}
