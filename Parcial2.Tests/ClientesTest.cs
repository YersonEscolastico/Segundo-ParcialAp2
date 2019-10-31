using System;
using System.Collections.Generic;
using BLL;
using DAL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parcial2.Tests
{
    [TestClass()]
    public class ClientesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            Clientes c = new Clientes();
            c.ClienteId = 1;
            c.Nombres = "Juan Perez";
            c.Balance = 200;

            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>(new DAL.Contexto());
            Assert.IsTrue(repositorio.Guardar(new Clientes()));
        }

        [TestMethod()]

        public void GetList()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>(new Contexto());
            Assert.IsNotNull(repositorio.GetList(a => true));
        }
        [TestMethod()]

        public void Buscar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>(new Contexto());
            Assert.IsNotNull(repositorio.Buscar(1));
        }
        [TestMethod()]

        public void Modificar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>(new Contexto());
            Clientes clientes = new Clientes();
            clientes.ClienteId = 1;
            clientes.Nombres = "Juan Perez";
            clientes.Balance = 100;

            Assert.IsTrue(repositorio.Modificar(clientes));
        }
        [TestMethod()]

        public void Eliminar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>(new Contexto());
            Assert.IsNotNull(repositorio.Eliminar(1));
        }
    }
}
