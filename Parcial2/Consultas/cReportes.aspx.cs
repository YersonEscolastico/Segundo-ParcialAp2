using BLL;
using DAL;
using Entidades;
using Microsoft.Reporting.WebForms;
using Parcial2.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial2.Consultas
{
    public partial class cReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
            if (!Page.IsPostBack)
            {
                DesdeFecha.Text = DateTime.Today.ToString("dd-MM-yyyy");
                HastaFecha.Text = DateTime.Today.ToString("dd-MM-yyyy");


            }

        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"~\Reportes\Trans.aspx");
        }

        protected void ConsultarButton_Click(object sender, EventArgs e)
        {

            Expression<Func<Transacciones, bool>> filtros = x => true;
            RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();

            DateTime Desde = Utilitarios.Utils.ToDateTime(DesdeFecha.Text);
            DateTime Hasta = Utilitarios.Utils.ToDateTime(HastaFecha.Text);

            int id;
            id = Utilitarios.Utils.ToInt(CriterioTextBox.Text);

            if (CheckBoxFecha.Checked == true)
            {
                switch (FiltroDropDown.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        filtros = c => c.TransaccionId == id;
                        break;
                    case 2:
                        filtros = c => c.Tipo.Contains(CriterioTextBox.Text);
                        break;

                    case 3:
                        filtros = c => c.Monto == id;
                        break;
                }
            }
            else
            {
                switch (FiltroDropDown.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        filtros = c => c.TransaccionId == id;
                        break;
                    case 2:
                        filtros = c => c.Tipo.Contains(CriterioTextBox.Text);
                        break;
                    case 3:
                        filtros = c => c.Monto == id;
                        break;
                }
            }
            Grid.DataSource = repositorio.GetList(filtros);
            Grid.DataBind();
        }
    }
}