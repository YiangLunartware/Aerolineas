using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using ClienteASP.ProxyVuelos;

namespace ClienteASP.Vuelos
{
    public partial class ListaVueloPorEstado : System.Web.UI.Page
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
                bool estado = Convert.ToBoolean(rbnEstado.SelectedValue);
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                List<ProxyVuelos.Vuelos> lista = new List<ProxyVuelos.Vuelos>();

                if (estado == true)
                {
                    lista = objServicioVuelos.ListaVueloPorEstado(estado, fi, ff).ToList();
                    dgvVueloE.DataSource = lista;
                    dgvVueloE.DataBind();
                }
                else if (estado == false)
                {
                    lista = objServicioVuelos.ListaVueloPorEstado(estado, fi, ff).ToList();
                    dgvVueloE.DataSource = lista;
                    dgvVueloE.DataBind();
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

        /*protected void dgvVueloE_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.Cells[4].Text.ToLower() == "true")
            {
                e.Row.Cells[4].Text = "disponible";
            }
            else if (e.Row.Cells[4].Text.ToLower() == "false")
            {
                e.Row.Cells[4].Text = "no disponible";
            }
        }*/

        protected void dgvVueloE_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvVueloE.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}