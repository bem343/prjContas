using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace prjContas.classes
{
    class listaUsuario : banco
    {
        private List<usuario> lista = new List<usuario>();
        public listaUsuario() : base() {  }
        public List<usuario> listar()
        {
            MySqlDataReader dados = null;
            string nomeSP = "buscarUsuarios";
            if (Selecionar(nomeSP, null, ref dados))
            {
                if (dados != null)
                {
                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            int codigo = int.Parse(dados["cd_usuario"].ToString());
                            string primeiroNome = dados["nm_primeiro_usuario"].ToString();
                            string segundoNome = dados["nm_segundo_usuario"].ToString();
                            string email = dados["nm_email_usuario"].ToString();
                            usuario usuario = new usuario(codigo, primeiroNome, segundoNome, email);
                            lista.Add(usuario);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
