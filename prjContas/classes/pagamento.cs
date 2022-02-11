using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjContas.classes
{
    class pagamento
    {
        #region Propriedades
            public int codigo { get; set; }
            public double valor { get; set; }
            public DateTime dtPagamento { get; set; }

            public boleto boleto { get; set; }
        #endregion

        #region Construtores
            public pagamento(int codigo, double valor, DateTime dtPagamento, boleto boleto)
            {
                this.codigo = codigo;
                this.valor = valor;
                this.dtPagamento = dtPagamento;
                this.boleto = boleto;
            }
        #endregion
    }
}
