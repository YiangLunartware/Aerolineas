using System;
using ClienteASP.ProxyVisitas;

namespace ClienteASP.Visitas
{
    public partial class ListaVisitas : System.Web.UI.Page
    {
        ServicioVisitasClient objServicioVisitas = new ServicioVisitasClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
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
    }
}