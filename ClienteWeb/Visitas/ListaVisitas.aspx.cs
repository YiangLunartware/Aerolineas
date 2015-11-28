using System;
using System.Collections.Generic;
using System.Linq;
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
                List<ProxyVisitas.Visitas> lista = objServicioVisitas.AllVisitas().ToList();

                dgvVisitas.DataSource = lista;
                dgvVisitas.DataBind();

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

        protected void dgvVisitas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvVisitas.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}