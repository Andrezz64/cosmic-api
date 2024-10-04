using System;
using System.Collections.Generic;

namespace cosmic_api.Models;
public partial class Core
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Hexadecimal { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
