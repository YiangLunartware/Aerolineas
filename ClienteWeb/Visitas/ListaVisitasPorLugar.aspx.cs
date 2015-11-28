using System;
using System.Collections.Generic;
using System.Linq;
using ClienteASP.ProxyVisitas;
using ClienteASP.ProxyVuelos;

namespace ClienteASP.Visitas
{
    public partial class ListaVisitasPorLugar : System.Web.UI.Page
    {
        ServicioVisitasClient objServicioVisitas = new ServicioVisitasClient();
        ServicioVuelosClient objServicioVuelos = new ServicioVuelosClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboDescripcion.DataSource = objServicioVuelos.ListaVueloXDescipcion();
                    cboDescripcion.DataTextField = "DescVuelo";
                    cboDescripcion.DataValueField = "DescVuelo";
                    cboDescripcion.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }

        private void Consulta()
        {
            lblError.Text = "";
            try
            {
                string Lugar = cboDescripcion.SelectedValue;
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                List<ProxyVisitas.Visitas> lista = new List<ProxyVisitas.Visitas>();
                lista = objServicioVisitas.GetVisitas_X_LugarOrigen(Lugar, fi, ff).ToList();

                dgvVisitasL.DataSource = lista;
                dgvVisitasL.DataBind();
                
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

        protected void dgvVisitasL_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            dgvVisitasL.PageIndex = e.NewPageIndex;
            Consulta();
        }
    }
}