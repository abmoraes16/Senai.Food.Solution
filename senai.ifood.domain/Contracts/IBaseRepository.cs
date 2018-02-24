using System.Collections.Generic;

namespace senai.ifood.domain.Contracts
{
    //INTERFACE, onde T é uma classe
    public interface IBaseRepository<T> where T : class
    {
        //= null <- se não passar nada também funciona
        IEnumerable<T> Listar(string[] includes = null); 
        int Atualizar(T dados);
        int Inserir(T dados);
        int Deletar(T dados);
        T BuscarPorId(int id,string[] includes = null);
    }
}