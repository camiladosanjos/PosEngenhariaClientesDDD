using ClientesDDD.Dominio.Entidades;
using ClientesDDD.Infra.Dados.Repositorio;
using System;
using System.Collections.Generic;
using ClientesDDD.Dominio.Interfaces;
using System.Text;

namespace ClientesDDD.Infra.Dados.Config
{
    public class ClienteApp : IClienteApp
    {
        ICliente _clienteInterface;

        public ClienteApp(ICliente clienteInterface)
        {
            _clienteInterface = clienteInterface;
        }

        public void Adicionar(Cliente obj)
        {
            _clienteInterface.Adicionar(obj);
        }

        public void Atualizar(Cliente obj)
        {
            _clienteInterface.Atualizar(obj);
        }

        public void Excluir(Cliente obj)
        {
            _clienteInterface.Excluir(obj);
        }

        public IList<Cliente> Listar()
        {
            return _clienteInterface.Listar();
        }

        public Cliente RecuperarPorId(Guid id)
        {
            return _clienteInterface.RecuperarPorId(id);
        }
    }
}
