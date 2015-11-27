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
        
        protected void cboDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Descripcion = cboDescripcion.SelectedValue;

                dgvVuelosD.DataSource = objServicioVuelos.ListaVueloPorDescripcion(Descripcion);
                dgvVuelosD.DataBind();

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }
    }
}