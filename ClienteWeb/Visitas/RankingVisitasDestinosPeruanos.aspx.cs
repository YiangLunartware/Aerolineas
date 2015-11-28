using System;
using System.Collections.Generic;
using System.Linq;
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

                List<ProxyVisitas.Visitas> lista = new List<ProxyVisitas.Visitas>();
                lista = objServicioVisitas.RankingVisitasDestinosPeruanos(fi).ToList();

                dgvVisitasD.DataSource = lista;
                dgvVisitasD.DataBind();

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

        protected void dgvVisitasD_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            dgvVisitasD.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}