using System;
using System.Collections.Generic;

namespace cosmic_api.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public Guid Guid { get; set; }

    public int RoleId { get; set; }

    public string Cpf { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public bool Ativo { get; set; }
}
