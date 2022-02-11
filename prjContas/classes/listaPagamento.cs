using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjContas.classes
{
    class listaPagamento : banco
    {
        private List<pagamento> lista = new List<pagamento>();
        public listaPagamento() : base() {  }
        public List<pagamento> listar(usuario usuario)
        {
            MySqlDataReader dados = null;
            string nomeSP = "buscarPagamentos";
            string[,] parametros = new string[1, 2];
            parametros[0, 0] = "vUsuario";
            parametros[0, 1] = usuario.codigo.ToString();
            if (Selecionar(nomeSP, parametros, ref dados))
            {
                if (dados != null)
                {
                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            int cdBoleto = int.Parse(dados["cd_boleto"].ToString());
                            string nmConta = dados["nm_conta"].ToString();
                            int cdPagamento = int.Parse(dados["cd_pagamento"].ToString());
                            double vlPagamento = double.Parse(dados["vl_pagamento"].ToString());
                            DateTime dtPagamento = DateTime.Parse(dados["dt_pagamento"].ToString());
                            conta conta = new conta(nmConta, usuario);
                            boleto boleto = new boleto(cdBoleto, conta);
                            pagamento pagamento = new pagamento(cdPagamento, vlPagamento, dtPagamento, boleto);
                            lista.Add(pagamento);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
