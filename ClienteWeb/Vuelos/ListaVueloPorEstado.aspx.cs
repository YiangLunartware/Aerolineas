using System;
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

                if (estado == true)
                {
                    dgvVueloE.DataSource = objServicioVuelos.ListaVueloPorEstado(estado, fi, ff);
                    dgvVueloE.DataBind();
                }
                else if (estado == false)
                {
                    dgvVueloE.DataSource = objServicioVuelos.ListaVueloPorEstado(estado, fi, ff);
                    dgvVueloE.DataBind();
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