using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using senai.ifood.domain.Contracts;
using senai.ifood.repository.Context;

namespace senai.ifood.repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        private readonly IFoodContext _DBContext;

        //Adiciona o contexto no construtor
        public BaseRepository(IFoodContext ifoodcontext){
            this._DBContext = ifoodcontext;
        }

        public int Atualizar(T dados)
        {
            try
            {
                _DBContext.Set<T>().Update(dados);
                return _DBContext.SaveChanges(); //retorna numero de linhas afetadas
            }
            catch(System.Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }

        public T BuscarPorId(int id, string[] includes = null)
        {
            try
            {
                //VARRE TODOS OS CAMPOS
                //T dados = _DBContext.Set<T>().Find(id);
                
                //VARRE CHAVE PRIMARIA
                var chavePrimaria = _DBContext.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties[0];
                T dados = _DBContext.Set<T>().FirstOrDefault(e=>EF.Property<int>(e,chavePrimaria.Name) == id);
                return dados;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Deletar(T dados)
        {
            throw new System.NotImplementedException();
        }

        public int Inserir(T dados)
        {
            try
            {
                _DBContext.Set<T>().Add(dados);
                return _DBContext.SaveChanges();
            }
            catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<T> Listar(string[] includes = null)
        {
            try
            {
                var query = _DBContext.Set<T>().AsQueryable();

                if(includes == null) return query.ToList();

                foreach(var item in includes)
                {
                    query = query.Include(item);
                }

                return query.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}