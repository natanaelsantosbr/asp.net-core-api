using Natanael.Dominio.Clientes;

namespace Natanael.Aplicacao
{
    public class ModeloDeEdicaoDeCliente
    {
        public ModeloDeEdicaoDeCliente(Cliente cliente)
        {
            if (cliente == null)
                return;

            this.Id = cliente.Id;
            this.Nome = cliente.Nome;
            this.Email = cliente.Email;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}