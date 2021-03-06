﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using ClienteASP.ProxyMigrantes;

namespace ClienteASP.Migrantes
{
    public partial class ListaMaximoMigrantes : System.Web.UI.Page
    {
        ServicioMigrantesClient objServicioMigrantes = new ServicioMigrantesClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    cboPais.DataSource = objServicioMigrantes.ListaPaises();
                    cboPais.DataTextField = "NomPais";
                    cboPais.DataValueField = "CodPais";
                    cboPais.DataBind();

                    txtFecFin.Text = System.DateTime.Now.ToShortDateString().ToString();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error...." + ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string codPais = cboPais.SelectedValue;
                System.DateTime fi = Convert.ToDateTime(txtFecIni.Text);
                System.DateTime ff = Convert.ToDateTime(txtFecFin.Text);

                List<PaisBE> lista = objServicioMigrantes.ListaPaisesMigrantes(codPais, fi, ff).ToList();
                string[] x = new string[lista.Count];
                int[] y = new int[lista.Count];

                for (int i = 0; i < lista.Count; i++)
                {
                    x[i] = lista.ElementAt(i).NomPais;
                    y[i] = lista.ElementAt(i).CantVuelos;
                }
                
                chtPaisesOrigen.Series[0].Points.DataBindXY(x, y);
                chtPaisesOrigen.DataBind();
                chtPaisesOrigen.Series[0].Label = "#PERCENT{P0}"+System.Environment.NewLine+"(#VALY)";
                chtPaisesOrigen.Titles.Add("Cantidad de migrantes por país");

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