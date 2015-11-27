using System;
using ClienteASP.ProxyVuelos;

namespace ClienteASP.Vuelos
{
    public partial class ListaVueloPorPrecio : System.Web.UI.Page
    {
        ServicioVuelosClient objServicioVuelos = new ServicioVuelosClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboPrecio.DataSource = objServicioVuelos.ListaPrecios();
                    cboPrecio.DataTextField = "PrecioVuelo";
                    cboPrecio.DataValueField = "PrecioVuelo";
                    cboPrecio.DataBind();
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
                Decimal PrecioVuelo = Convert.ToDecimal(cboPrecio.SelectedValue);
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                dgvVuelosP.DataSource = objServicioVuelos.ListaVueloPorPrecio(PrecioVuelo, fi, ff);
                dgvVuelosP.DataBind();

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

        protected void dgvVuelosP_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            dgvVuelosP.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}