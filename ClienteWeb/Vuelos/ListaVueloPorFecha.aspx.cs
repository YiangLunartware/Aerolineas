﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWeb.ProxyVuelos;

namespace ClienteWeb
{
    public partial class ListaVueloPorFecha : System.Web.UI.Page
    {
        ServicioVuelosClient objServicioVuelos = new ServicioVuelosClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                dgvVuelosF.DataSource = objServicioVuelos.ListaVueloPorFecha(fi, ff);
                dgvVuelosF.DataBind();

                UpdatePanel1.Update();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }
    }
}