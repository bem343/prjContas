using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjContas.classes
{
    class boleto
    {
        #region Propriedades
            public int codigo { get; set; }
            public double valor { get; set; }
            public DateTime dtPagamento { get; set; }
            public DateTime hrPagamento { get; set; }

            public conta conta { get; set; }
        #endregion

        #region Construtores
            public boleto(int codigo, conta conta)
            {
                this.codigo = codigo;
                this.conta = conta;
            }
            public boleto(int codigo, double valor, DateTime dtPagamento, DateTime hrPagamento, conta conta)
            {
                this.codigo = codigo;
                this.valor = valor;
                this.dtPagamento = dtPagamento;
                this.hrPagamento = hrPagamento;
                this.conta = conta;
            }
        #endregion
    }
}
