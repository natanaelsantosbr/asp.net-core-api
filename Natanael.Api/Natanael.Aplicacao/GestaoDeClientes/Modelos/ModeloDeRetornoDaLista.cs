using Natanael.Dominio.Clientes;
using System.Collections.Generic;

namespace Natanael.Aplicacao
{
    public class ModeloDeRetornoDaLista : ModeloDeRetornoPadraoDaAPI
    {
        public ModeloDeRetornoDaLista()
        {
            this.Lista = new List<ModeloDeClienteDaLista>();
        }

        public ModeloDeRetornoDaLista(bool sucesso, string mensagem)
        {
            this.Sucesso = sucesso;
            this.Mensagem = mensagem;
        }

        public ModeloDeRetornoDaLista(bool sucesso, string mensagem, List<Cliente> lista) : this()
        {
            if (lista == null)
                return;

            this.Sucesso = sucesso;
            this.Mensagem = mensagem;

            lista.ForEach(a => this.Lista.Add(new ModeloDeClienteDaLista(a)));
            
        }
        public List<ModeloDeClienteDaLista> Lista { get; protected set; }
    }
}