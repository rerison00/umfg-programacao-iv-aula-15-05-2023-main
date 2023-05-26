using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Dominio.Entidades
{
    public sealed class Cliente
    {
        public string Documento { get; private set; }
        public string Nome { get; private set; }

        public Cliente(string documento, string nome)
        {
            if (string.IsNullOrEmpty(documento))
            {
                throw new ArgumentNullException(nameof(documento), "O documento não pode ser vazio.");
            }

            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException(nameof(nome), "O nome não pode ser vazio.");
            }

            Documento = documento;
            Nome = nome;
        }
    }


}