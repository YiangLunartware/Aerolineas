using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyMigrantes;

namespace ClienteWeb
{
    public partial class ListaMigrantesPaisFechas : System.Web.UI.Page
    {
        ServicioMigrantesClient objServicioMigrantes = new ServicioMigrantesClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboPaisOrigen.DataSource = objServicioMigrantes.ListaPaises();
                    cboPaisOrigen.DataTextField = "NomPais";
                    cboPaisOrigen.DataValueField = "CodPais";
                    cboPaisOrigen.DataBind();

                    cboPaisDestino.DataSource = objServicioMigrantes.ListaPaises();
                    cboPaisDestino.DataTextField = "NomPais";
                    cboPaisDestino.DataValueField = "CodPais";
                    cboPaisDestino.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string codPaisOrigen = cboPaisOrigen.SelectedValue;
                string codPaisDestino = cboPaisDestino.SelectedValue;
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);
                dgvMigrantes.DataSource = objServicioMigrantes.ListaMigrantesPaisesFechas(codPaisOrigen,codPaisDestino, fi, ff);
                dgvMigrantes.DataBind();

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }

            UpdatePanel1.Update();
        }

        protected void dgvMigrantes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[2].Visible = false;
            e.Row.Cells[7].Visible = false;
            e.Row.Cells[10].Visible = false;
        }
    }
}