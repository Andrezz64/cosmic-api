using System;
using System.Collections.Generic;

namespace cosmic_api.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Sobrenome { get; set; } = null!;

    public string Emaill { get; set; } = null!;

    public Guid Guid { get; set; }

    public string Senha { get; set; } = null!;

    public virtual ICollection<Venda> Venda { get; set; } = new List<Venda>();
}
