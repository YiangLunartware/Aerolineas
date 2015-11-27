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

        private void Consulta()
        {
            lblError.Text = "";
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

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        protected void dgvVisitasD_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            dgvVisitasD.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}