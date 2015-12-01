using ReclamaPoaS2B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReclamaPoaS2B
{
    public partial class Reclamacoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                ddlReclamacoes.DataSource = Repositorio.getReclamacoes();
                ddlReclamacoes.DataBind();

                ddlCategoria.DataSource = Repositorio.getCategorias();
                ddlCategoria.DataTextField = "Nome";
                ddlCategoria.DataValueField = "CategoriaId";
                ddlCategoria.DataBind();

            }
        }

        protected void cmdInserir_Click(object sender, EventArgs e)
        {
            int codigo;
            int codCategoria = int.Parse(ddlCategoria.SelectedValue);

                 Reclamacao nova = new Reclamacao
                 {
                     Titulo = txtTitulo.Text,
                     CategoriaId = codCategoria

                 };
                 Repositorio.insereReclamacao(nova);
             Response.Redirect("Reclamacaos.aspx");
            
        }

    }
}