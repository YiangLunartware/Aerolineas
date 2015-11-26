using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyVisitas;

namespace ClienteWeb
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