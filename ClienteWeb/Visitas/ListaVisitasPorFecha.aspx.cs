using System;
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
            try
            {
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                dgvVisita.DataSource = objServicioVisitas.GetVisitas_X_Fecha(fi, ff);
                dgvVisita.DataBind();

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }
    }
}