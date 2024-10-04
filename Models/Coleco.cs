using System;
using System.Collections.Generic;
using cosmic_api.Models;

namespace cosmic_api.Models;

public partial class Coleco
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
