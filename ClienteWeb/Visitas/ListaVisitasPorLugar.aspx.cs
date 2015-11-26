using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyVisitas;
using ClienteWeb.ProxyVuelos;

namespace ClienteWeb
{
    public partial class ListaVisitasPorLugar : System.Web.UI.Page
    {
        ServicioVisitasClient objServicioVisitas = new ServicioVisitasClient();
        ServicioVuelosClient objServicioVuelos = new ServicioVuelosClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboDescripcion.DataSource = objServicioVuelos.ListaVueloXDescipcion();
                    cboDescripcion.DataTextField = "DescVuelo";
                    cboDescripcion.DataValueField = "DescVuelo";
                    cboDescripcion.DataBind();
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
                string Lugar = cboDescripcion.SelectedValue;
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                dgvVisitasL.DataSource = objServicioVisitas.GetVisitas_X_LugarOrigen(Lugar, fi, ff);
                dgvVisitasL.DataBind();

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }
    }
}