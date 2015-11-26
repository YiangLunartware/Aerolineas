using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyMigrantes;

namespace ClienteWeb
{
    public partial class Consulta : System.Web.UI.Page
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
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }

            UpdatePanel1.Update();
        }
    }
}