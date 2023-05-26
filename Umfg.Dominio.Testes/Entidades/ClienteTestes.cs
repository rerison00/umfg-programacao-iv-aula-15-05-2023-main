using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;

namespace Umfg.Dominio.Testes.Entidades
{
    [TestClass]
    public sealed class ClienteTestes
    {
        private const string _firstOwner = "Juliano Maciel";
        private const string _secondOwner = "Ruan";
        private const string _category = "Cliente";

        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_Construtor_Sucesso()
        {
            try
            {
                var cliente = new Cliente("04405125228", "TESTE");
                
                Assert.AreEqual("TESTE", cliente.Nome);
                Assert.AreEqual("04405125228", cliente.Documento);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_DocumentoNull_ThrowArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(()
                => new Cliente("321321321", "TESTE"));
        }

        [TestMethod]
        [Owner(_firstOwner)]
        [TestCategory(_category)]
        public void Cliente_NomeNull_ThrowArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(()
                => new Cliente("04405125228", "Teste"));
        }
    }
}