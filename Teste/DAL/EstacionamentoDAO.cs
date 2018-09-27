using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Model;

namespace Teste.DAL
{
    class EstacionamentoDAO
    {
        private static Context ctx = Singleton.Instance.Context;

        public static Estacionamento BuscarEstacionamentoPorId(int idEstacionamento)
        {
            return ctx.Estacionamento.FirstOrDefault(x=> x.IdEstacionamento == idEstacionamento);
        }

        public static bool CadastrarEstacionamento(Estacionamento e)
        {
            try
            {
                ctx.Estacionamento.Add(e);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Estacionamento ValidarLogin(string login, string senha)
        {
            return ctx.Estacionamento.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper() && x.Senha == senha);
        }
    }
}
