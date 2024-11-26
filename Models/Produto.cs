using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace cosmic_api.Models;

public partial class Produto
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal Valor { get; set; }

    public int CategoriaId { get; set; }

    public int ColecaoId { get; set; }

    public int CorId { get; set; }
     [JsonIgnore]
    public virtual Categoria Categoria { get; set; } = null!;
     [JsonIgnore]
    public virtual Coleco Colecao { get; set; } = null!;
     [JsonIgnore]
    public virtual Core Cor { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Venda> Venda { get; set; } = new List<Venda>();
}
