using System;
using System.Web.UI.WebControls;
using ClienteASP.ProxyVisitas;

namespace ClienteASP.Visitas
{
    public partial class ListaVisitas : System.Web.UI.Page
    {
        ServicioVisitasClient objServicioVisitas = new ServicioVisitasClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Consulta()
        {
            lblError.Text = "";
            try
            {
                dgvVisitas.DataSource = objServicioVisitas.AllVisitas();
                dgvVisitas.DataBind();

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

        protected void dgvVisitas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvVisitas.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}