using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDDD.Infra.Dados.Repositorio
{
    public interface IAppBase<T> where T : class
    {
        void Adicionar(T obj);
        void Excluir(T obj);
        void Atualizar(T obj);
        T RecuperarPorId(Guid id);
        IList<T> Listar();

    }
}
