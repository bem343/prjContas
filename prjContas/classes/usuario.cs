using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjContas.classes
{
    class usuario
    {
        #region Propriedades
            public int codigo { get; private set; }
            public string primeiroNome { get; set; }
            public string segundoNome { get; set; }
            public string email { get; private set; }
        #endregion

        #region Contrutores
            public usuario(int codigo, string primeiroNome, string segundoNome, string email)
            {
                this.codigo = codigo;
                this.primeiroNome = primeiroNome;
                this.segundoNome = segundoNome;
                this.email = email;
            }
        #endregion
    }
}
