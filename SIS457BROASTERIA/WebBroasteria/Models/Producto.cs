﻿using System;
using System.Collections.Generic;

namespace WebBroasteria.Models;

public partial class Producto
{
    public int Id { get; set; }

    public int IdCategoria { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Stock { get; set; }

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
