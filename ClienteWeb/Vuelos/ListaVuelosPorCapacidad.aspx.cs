using System;
using System.Collections.Generic;
using ClienteASP.ProxyVuelos;

namespace ClienteASP.Vuelos
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

        private void Consulta()
        {
            lblError.Text = "";

            try
            {
                int Capacidad = Convert.ToInt32(cboCapacidad.SelectedValue);
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                List<ProxyVuelos.Vuelos> lista = new List<ProxyVuelos.Vuelos>();

                dgvVuelosC.DataSource = objServicioVuelos.ListaVuelosPorCapacidad(Capacidad, fi, ff);
                dgvVuelosC.DataBind();

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

        protected void dgvVuelosC_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            dgvVuelosC.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}