using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDDD.Dominio.Interfaces
{
    public interface IBase<T> where T : class
    {
        void Atualizar(T obj);
        void Adicionar(T obj);
        T RecuperarPorId(Guid id);
        void Excluir(T obj);
        IList<T> Listar();
    }
}
