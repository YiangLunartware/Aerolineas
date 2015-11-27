using System;
using System.Collections.Generic;
using ClienteASP.ProxyMigrantes;

namespace ClienteASP.Migrantes
{
    public partial class ConsultaMaximoMigrantes : System.Web.UI.Page
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

                    this.cboPais_SelectedIndexChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }

        protected void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string codPais = cboPais.SelectedValue;
                List<PaisBE> lista = new List<PaisBE>();
                PaisBE pais = objServicioMigrantes.ConsultaMaximoMigrantesNacionalidad(codPais);
                lista.Add(pais);

                dtvPais.DataSource = lista;
                dtvPais.DataBind();

                if (lista.Count == 0)
                {
                    lblError.Text = "No hay elementos";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }

            UpdatePanel1.Update();
        }
    }
}