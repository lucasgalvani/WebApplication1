using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();
        void InserirAluno(Aluno aluno);
        Aluno BuscarId(int id);
        void EditarAluno(Aluno aluno);
        void ApagarAluno(Aluno aluno);
    }
}
