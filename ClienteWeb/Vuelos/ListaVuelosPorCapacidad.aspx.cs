using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyVuelos;

namespace ClienteWeb
{
    public partial class ListaVuelosPorCapacidad : System.Web.UI.Page
    {
        ServicioVuelosClient objServicioVuelos = new ServicioVuelosClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboCapacidad.DataSource = objServicioVuelos.ListaAvionCapacidad();
                    cboCapacidad.DataTextField = "Capacidad";
                    cboCapacidad.DataValueField = "Capacidad";
                    cboCapacidad.DataBind();
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
                int Capacidad = Convert.ToInt32(cboCapacidad.SelectedValue);
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                dgvVuelosC.DataSource = objServicioVuelos.ListaVuelosPorCapacidad(Capacidad, fi, ff);
                dgvVuelosC.DataBind();

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }
    }
}