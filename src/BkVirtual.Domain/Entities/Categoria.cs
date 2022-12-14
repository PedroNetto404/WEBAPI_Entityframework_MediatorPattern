using BkVirtual.Core.Domain;

namespace BkVirtual.Domain.Entities;

public class Categoria : Entity
{
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public bool Ativo { get; private set; }

    // Relações entity
    public IEnumerable<Produto>? Produtos { get; set; }

    public Categoria(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
        Ativo = true;
        Validar();
    }

    public void Ativar() => Ativo = true;
    public void Desativar() => Ativo = false;
    public void AlterarNome(string novoNome) => Nome = novoNome;
    public void AlterarDescricao(string novaDescricao) => Descricao = novaDescricao;

    public sealed override void Validar()
    {
        if (string.IsNullOrWhiteSpace(Nome))
            throw new DomainException("Categoria inválida");
        
        if (string.IsNullOrWhiteSpace(Descricao))
            throw new DomainException("Categoria inválida");
    }
}