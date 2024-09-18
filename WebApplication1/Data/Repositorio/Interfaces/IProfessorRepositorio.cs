using WebApplication1.Models;

namespace WebApplication1.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {
        List<Professor> BuscarProfessor();

        void InserirProfessor(Professor professor);

        Professor BuscarIdProfessor(int id);

        void EditarProfessor(Professor professor);

        void ApagarProfessor(Professor professor);
    }
}