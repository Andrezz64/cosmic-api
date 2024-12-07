using System;
using System.Collections.Generic;

namespace cosmic_api.Models;

public partial class Produto
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal Valor { get; set; }

    public int CategoriaId { get; set; }

    public int ColecaoId { get; set; }

    public int CorId { get; set; }

    public string? Url { get; set; }

    public string? Colecao { get; set; }

    public string? Cor { get; set; }

    public string? Nome { get; set; }

    public string? Categoria { get; set; }

    public virtual Categoria CategoriaNavigation { get; set; } = null!;

    public virtual Coleco ColecaoNavigation { get; set; } = null!;

    public virtual Core CorNavigation { get; set; } = null!;

    public virtual ICollection<Venda> Venda { get; set; } = new List<Venda>();
}
