using System;
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

                dgvVuelosF.DataSource = objServicioVuelos.ListaVueloPorFecha(fi, ff);
                dgvVuelosF.DataBind();

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