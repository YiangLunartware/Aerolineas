using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using ClienteASP.ProxyMigrantes;

namespace ClienteASP.Migrantes
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

        private void Consulta()
        {
            lblError.Text = "";
            dgvMigrantesInternac.DataSource = null;
            dgvMigrantesNacionales.DataSource = null;
            dgvMigrantesInternac.DataBind();
            dgvMigrantesNacionales.DataBind();

            try
            {
                string codPais = cboPais.SelectedValue;
                string tipoRuta = rbnTipoRuta.SelectedValue;
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);
                List<MigranteBE> lista = new List<MigranteBE>();

                if (tipoRuta.Equals("NACIONAL"))
                {
                    lista = objServicioMigrantes.ListaMigrantesNacionales(codPais, fi, ff).ToList();
                    dgvMigrantesNacionales.DataSource = lista;
                    dgvMigrantesNacionales.DataBind();
                }
                else if (tipoRuta.Equals("INTERNACIONAL"))
                {
                    lista = objServicioMigrantes.ListaMigrantesInternacionales(codPais, fi, ff).ToList();
                    dgvMigrantesInternac.DataSource = lista;
                    dgvMigrantesInternac.DataBind();
                }

                if (lista.Count == 0)
                {
                    lblError.Text = "No hay elementos";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        protected void dgvMigrantesNacionales_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvMigrantesNacionales.PageIndex = e.NewPageIndex;
            Consulta();
        }

        protected void dgvMigrantesInternac_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvMigrantesInternac.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}