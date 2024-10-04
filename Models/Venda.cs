using System;
using System.Collections.Generic;

namespace cosmic_api.Models;

public partial class Venda
{
    public int Id { get; set; }

    public int PrudutoId { get; set; }

    public int Quantidade { get; set; }

    public DateTime Datavenda { get; set; }

    public int ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Produto Pruduto { get; set; } = null!;
}
