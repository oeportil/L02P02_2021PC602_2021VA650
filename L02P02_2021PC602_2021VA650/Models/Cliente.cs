﻿using System;
using System.Collections.Generic;

namespace L02P02_2021PC602_2021VA650.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<PedidoEncabezado> PedidoEncabezados { get; set; } = new List<PedidoEncabezado>();
}
