using System;
using System.Collections.Generic;
using System.Linq;
using ClienteASP.ProxyVuelos;

namespace ClienteASP.Vuelos
{
    public partial class ListaVueloPorFecha : System.Web.UI.Page
    {
        ServicioVuelosClient objServicioVuelos = new ServicioVuelosClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void Consulta()
        {
            lblError.Text = "";
            try
            {
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                List<ProxyVuelos.Vuelos> lista = new List<ProxyVuelos.Vuelos>();
                lista = objServicioVuelos.ListaVueloPorFecha(fi, ff).ToList();

                dgvVuelosF.DataSource = lista;
                dgvVuelosF.DataBind();

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

        protected void dgvVuelosF_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            dgvVuelosF.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}