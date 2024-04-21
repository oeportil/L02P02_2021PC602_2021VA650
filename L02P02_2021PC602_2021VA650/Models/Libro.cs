﻿using System;
using System.Collections.Generic;

namespace L02P02_2021PC602_2021VA650.Models;

public partial class Libro
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? UrlImagen { get; set; }

    public int? IdAutor { get; set; }

    public int? IdCategoria { get; set; }

    public decimal? Precio { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<ComentariosLibro> ComentariosLibros { get; set; } = new List<ComentariosLibro>();

    public virtual Autore? IdAutorNavigation { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; } = new List<PedidoDetalle>();
}
