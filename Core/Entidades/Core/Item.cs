using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Item
{
    public int IdItem { get; set; }

    public int? IdEspaciosFisicos { get; set; }

    public int? IdEstadoItem { get; set; }

    public int? IdTipoItem { get; set; }

    public string? NombreItem { get; set; }

    public string? DescripcionItem { get; set; }

    public string? PathfotoItem { get; set; }

    public bool? ActivoItem { get; set; }

    public virtual ICollection<DetalleItem> DetalleItems { get; } = new List<DetalleItem>();

    public virtual EspaciosFisico? IdEspaciosFisicosNavigation { get; set; }

    public virtual EstadoItem? IdEstadoItemNavigation { get; set; }

    public virtual TipoItem? IdTipoItemNavigation { get; set; }
}
