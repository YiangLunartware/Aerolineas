using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyVuelos;

namespace ClienteWeb
{
    public partial class ListaVueloPorEstado : System.Web.UI.Page
    {
        ServicioVuelosClient objServicioVuelos = new ServicioVuelosClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
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

        protected void dgvVueloE_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.Cells[4].Text.ToLower() == "true")
            {
                e.Row.Cells[4].Text = "disponible";
            }
            else if (e.Row.Cells[4].Text.ToLower() == "false")
            {
                e.Row.Cells[4].Text = "no disponible";
            }
        }
    }
}