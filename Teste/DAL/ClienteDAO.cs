using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.DAL
{
    class ClienteDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool CadastrarCliente(Cliente c)
        {
            try
            {
                ctx.Cliente.Add(c);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
                return false;
            }
        }

        public static List<Cliente> RetornarCliente(int IdEstacionamento)
        {
            return ctx.Cliente.Where(x=> x.IdEstacionamento == IdEstacionamento).ToList();
        }

        internal static Cliente BuscarClientePorId(int idCliente, int IdEstacionamento)
        {
            // transforma todos os clientes em 'x' e compara com o parametro que eu espero, no caso, idCliente
            return ctx.Cliente.FirstOrDefault(x => x.IdCliente == idCliente && x.IdEstacionamento == IdEstacionamento);
          
        }

        // fazer o excluir
        public static bool ExcluirCliente(int idCliente, int IdEstacionamento)
        {
            try
            {
                Cliente cliente = BuscarClientePorId(idCliente, IdEstacionamento);
                ctx.Cliente.Remove(cliente);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool EditarCliente(Cliente clienteEditado)
        {

            try
            {
                
                // informando para o Entity que isso vai ser modificado de acordo com os parametros enviados
                ctx.Entry(clienteEditado).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
    }
}
