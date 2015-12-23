using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;            
        }

        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = string.Empty;
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL d = new PessoaDAL();
                Pessoa p = d.PesquisarPorCodigo(Codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;

                    txtNome.Text = p.Nome.Trim();
                    txtEndereco.Text = p.Endereco.Trim();
                    txtEmail.Text = p.Email.Trim();                    
                }
                else 
                {
                    lblMensagem.Text = "Cliente não encontrado!";
                    txtCodigo.Text = string.Empty;
                }                                
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();

                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;

                PessoaDAL d = new PessoaDAL();
                d.Atualizar(p);

                lblMensagem.Text = "Cliente atualizado com sucesso!"; 
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL d = new PessoaDAL();
                d.Exluir(Codigo);

                lblMensagem.Text = "Cliente excluido com sucesso!";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

                pnlDados.Visible = false;  
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}