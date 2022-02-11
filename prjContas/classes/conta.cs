using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjContas.classes
{
    class conta
    {
        #region Propriedades
            public int codigo { get; set; }
            public string nome { get; set; }

            public usuario usuario { get; set; }
        #endregion

        #region Construtores
            public conta(string nome, usuario usuario)
            {
                this.nome = nome;
                this.usuario = usuario;
            }
            public conta(int codigo, string nome, usuario usuario)
            {
                this.codigo = codigo;
                this.nome = nome;
                this.usuario = usuario;
            }
        #endregion
    }
}
