using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyMigrantes;

namespace ClienteWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServicioMigrantesClient objServicioMigrantes = new ServicioMigrantesClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboPais.DataSource = objServicioMigrantes.ListaPaises();
                    cboPais.DataTextField = "NomPais";
                    cboPais.DataValueField = "CodPais";
                    cboPais.DataBind();
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
                string codPais = cboPais.SelectedValue;
                string tipoRuta = rbnTipoRuta.SelectedValue;
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                if (tipoRuta.Equals("NACIONAL"))
                {
                    dgvMigrantes.DataSource = objServicioMigrantes.ListaMigrantesNacionales(codPais, fi, ff);
                    dgvMigrantes.DataBind();
                }
                else if (tipoRuta.Equals("INTERNACIONAL"))
                {
                    dgvMigrantes.DataSource = objServicioMigrantes.ListaMigrantesInternacionales(codPais, fi, ff);
                    dgvMigrantes.DataBind();
                }

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }

        protected void dgvMigrantes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            string tipoRuta = rbnTipoRuta.SelectedValue;

            e.Row.Cells[2].Visible = false;

            if (tipoRuta.Equals("NACIONAL"))
                e.Row.Cells[10].Visible = false;
            else if (tipoRuta.Equals("INTERNACIONAL"))
                e.Row.Cells[7].Visible = false;
        }
    }
}