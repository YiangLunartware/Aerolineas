using System;
using ClienteASP.ProxyVisitas;

namespace ClienteASP.Visitas
{
    public partial class RankingVisitasDestinosPeruanos : System.Web.UI.Page
    {
        ServicioVisitasClient objServicioVisitas = new ServicioVisitasClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);

                dgvVisitasD.DataSource = objServicioVisitas.RankingVisitasDestinosPeruanos(fi);
                dgvVisitasD.DataBind();

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }
    }
}