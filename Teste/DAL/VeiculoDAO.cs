using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.DAL
{
    class VeiculoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static bool CadastrarVeiculo(Veiculo v)
        {
            try
            {
                ctx.Veiculo.Add(v);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Veiculo> RetornarVeiculo()
        {
            return ctx.Veiculo.ToList();
        }

        internal static Veiculo BuscarVeiculoPorId(int idVeiculo)
        {
            // transforma todos os veiculos em 'x' e compara com o parametro que eu espero, no caso, idVeiculo
            return ctx.Veiculo.FirstOrDefault(x => x.IdVeiculo == idVeiculo);

        }

        // fazer o excluir
        public static bool ExcluirVeiculo(int idVeiculo)
        {
            try
            {
                Veiculo veiculo = BuscarVeiculoPorId(idVeiculo);
                ctx.Veiculo.Remove(veiculo);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void ExcluirVeiculosPorClienteID(int clienteID)
        {
            var veiculos = ctx.Veiculo.Where(v => v.IdCliente == clienteID);

            foreach (Veiculo veic in veiculos)
            {
                ctx.Veiculo.Remove(veic);
            }

            ctx.SaveChanges();
        }



        public static bool EditarVeiculo(Veiculo veiculoEditado)
        {

            try
            {

                // informando para o Entity que isso vai ser modificado de acordo com os parametros enviados
                ctx.Entry(veiculoEditado).State = EntityState.Modified;
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
