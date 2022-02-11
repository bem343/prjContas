using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjContas.classes;

namespace prjContas
{
    public partial class frmPrincipal : Form
    {
        #region Propriedades
            private List<usuario> usuarios = null;
        #endregion

        #region Construtores
        public frmPrincipal()
            {
                InitializeComponent();
            }
        #endregion

        #region PageLoad
            private void frmPrincipal_Load(object sender, EventArgs e)
            {
                lblData.Text = "Pagamentos de " + DateTime.Now.Year;

                listaUsuario usuarios = new listaUsuario();
                this.usuarios = usuarios.listar();
                foreach (usuario usuario in this.usuarios)
                {
                    lstUsuarios.Items.Add(usuario.primeiroNome);
                }
            }
        #endregion

        #region Selecionar um usuário
            private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
            {
                string primeiroNome = usuarios[lstUsuarios.SelectedIndex].primeiroNome;
                string segundoNome = usuarios[lstUsuarios.SelectedIndex].segundoNome;
                lblNome.Text = primeiroNome + " " + segundoNome;
                gvPagamentos.Columns.Clear();
                gvPagamentos.Rows.Clear();

                string nmConta = "";
                listaPagamento pagamentos = new listaPagamento();
                foreach (pagamento pagamento in pagamentos.listar(usuarios[lstUsuarios.SelectedIndex]))
                {
                    if (nmConta != pagamento.boleto.conta.nome)
                    {
                        nmConta = pagamento.boleto.conta.nome;
                        gvPagamentos.Columns.Add(nmConta, nmConta);
                    }
                    string celula = "R$" + pagamento.valor.ToString(".00") + " - " + pagamento.dtPagamento.ToShortDateString();
                }
            }
        #endregion
    }
}
