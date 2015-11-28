using System;
using System.Collections.Generic;
using System.Linq;
using ClienteASP.ProxyVuelos;

namespace ClienteASP.Vuelos
{
    public partial class ConsultaVuelosDescripcion : System.Web.UI.Page
    {
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

                    this.cboDescripcion_SelectedIndexChanged(sender, e);
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
            try
            {
                string Descripcion = cboDescripcion.SelectedValue;

                List<ProxyVuelos.Vuelos> lista = new List<ProxyVuelos.Vuelos>();
                lista = objServicioVuelos.ListaVueloPorDescripcion(Descripcion).ToList();

                dgvVuelosD.DataSource =  lista;
                dgvVuelosD.DataBind();

                if (lista.Count == 0)
                {
                    lblError.Text = "No hay elementos";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
                lblError.ForeColor = System.Drawing.Color.Red;
            }

            UpdatePanel1.Update();
        }

        protected void cboDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consulta();
        }

        protected void dgvVuelosD_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            Consulta();
        }
    }
}