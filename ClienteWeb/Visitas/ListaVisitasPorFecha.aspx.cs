using System;
using System.Collections.Generic;
using System.Linq;
using ClienteASP.ProxyVisitas;

namespace ClienteASP.Visitas
{
    public partial class VisitasPorFecha : System.Web.UI.Page
    {
        ServicioVisitasClient objServicioVisitas = new ServicioVisitasClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        protected void dgvVisita_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            dgvVisita.PageIndex = e.NewPageIndex;
            Consulta();
        }

        private void Consulta()
        {
            lblError.Text = "";
            try
            {
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                List<ProxyVisitas.Visitas> lista = new List<ProxyVisitas.Visitas>();
                lista = objServicioVisitas.GetVisitas_X_Fecha(fi, ff).ToList();

                dgvVisita.DataSource = lista;
                dgvVisita.DataBind();

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
    }
}