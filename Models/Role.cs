using System;
using System.Collections.Generic;

namespace cosmic_api.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Permissoes { get; set; } = null!;
}
