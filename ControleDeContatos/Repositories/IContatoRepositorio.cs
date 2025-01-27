using ControleDeContatos.Models;

namespace ControleDeContatos.Repositories
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> BuscarContatos();
        ContatoModel Atualizar(ContatoModel contato);

        bool Apagar(int id);
    }
}
