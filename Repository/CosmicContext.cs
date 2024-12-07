using System;
using System.Collections.Generic;
using cosmic_api.Models;
using Microsoft.EntityFrameworkCore;

namespace cosmic_api.Repository;

public partial class CosmicContext : DbContext
{
    public CosmicContext()
    {
    }

    public CosmicContext(DbContextOptions<CosmicContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Coleco> Colecoes { get; set; }

    public virtual DbSet<Core> Cores { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venda> Vendas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=123;Database=cosmic");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorias_pkey");

            entity.ToTable("categorias", "cosmic");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(15)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("clientes_pkey");

            entity.ToTable("clientes", "cosmic");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Emaill)
                .HasMaxLength(30)
                .HasColumnName("emaill");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Nome)
                .HasMaxLength(25)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(100)
                .HasColumnName("senha");
            entity.Property(e => e.Sobrenome)
                .HasMaxLength(25)
                .HasColumnName("sobrenome");
        });

        modelBuilder.Entity<Coleco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("colecoes_pkey");

            entity.ToTable("colecoes", "cosmic");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(25)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Core>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cor_pkey");

            entity.ToTable("cores", "cosmic");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Hexadecimal)
                .HasMaxLength(15)
                .HasColumnName("hexadecimal");
            entity.Property(e => e.Nome)
                .HasMaxLength(10)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("produtos_pkey");

            entity.ToTable("produtos", "cosmic");

            entity.HasIndex(e => e.CategoriaId, "IX_produtos_categoria_id");

            entity.HasIndex(e => e.ColecaoId, "IX_produtos_colecao_id");

            entity.HasIndex(e => e.CorId, "IX_produtos_cor_id");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Categoria)
                .HasMaxLength(123)
                .HasColumnName("categoria");
            entity.Property(e => e.CategoriaId).HasColumnName("categoria_id");
            entity.Property(e => e.Colecao)
                .HasMaxLength(256)
                .HasColumnName("colecao");
            entity.Property(e => e.ColecaoId).HasColumnName("colecao_id");
            entity.Property(e => e.Cor)
                .HasMaxLength(145)
                .HasColumnName("cor");
            entity.Property(e => e.CorId).HasColumnName("cor_id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(123)
                .HasColumnName("nome");
            entity.Property(e => e.Url)
                .HasMaxLength(256)
                .HasColumnName("url");
            entity.Property(e => e.Valor)
                .HasColumnType("money")
                .HasColumnName("valor");

            entity.HasOne(d => d.CategoriaNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("categoria");

            entity.HasOne(d => d.ColecaoNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.ColecaoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("colecao");

            entity.HasOne(d => d.CorNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.CorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cor");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles", "cosmic");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(15)
                .HasColumnName("nome");
            entity.Property(e => e.Permissoes)
                .HasMaxLength(100)
                .HasColumnName("permissoes");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("usuario_pkey");

            entity.ToTable("usuarios", "cosmic");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Ativo).HasColumnName("ativo");
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .HasColumnName("cpf");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Senha)
                .HasMaxLength(100)
                .HasColumnName("senha");
        });

        modelBuilder.Entity<Venda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("venda_pkey");

            entity.ToTable("vendas", "cosmic");

            entity.HasIndex(e => e.PrudutoId, "IX_vendas_pruduto_id");

            entity.HasIndex(e => e.ClienteId, "fki_clientes");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.Datavenda)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datavenda");
            entity.Property(e => e.PrudutoId).HasColumnName("pruduto_id");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Venda)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente");

            entity.HasOne(d => d.Pruduto).WithMany(p => p.Venda)
                .HasForeignKey(d => d.PrudutoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("produto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
