using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft.frmReportes
{
    public partial class frmSeleccionarObjeto : Form
    {
        private CategoriaWS.CategoriaWSClient categoriaDAO = new CategoriaWS.CategoriaWSClient();
        private BindingList<CategoriaWS.categoria> categorias;
        private CategoriaWS.categoria categoria;
        private UrgenciaWS.UrgenciaWSClient urgenciaDAO = new UrgenciaWS.UrgenciaWSClient();
        private BindingList<UrgenciaWS.urgencia> urgencias;
        private UrgenciaWS.urgencia urgencia;
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();
        private BindingList<AgenteWS.agente> agentes;
        private AgenteWS.agente agente;
        private EquipoWS.EquipoWSClient equipoDAO = new EquipoWS.EquipoWSClient();
        private BindingList<EquipoWS.equipo> equipos;
        private EquipoWS.equipo equipo;
        int tipoSeleccionado;

        public frmSeleccionarObjeto(int tipo)
        {
            tipoSeleccionado = tipo;
            InitializeComponent();
            switch (tipoSeleccionado)
            {
                case 1: //Para listar categorias
                    var cate = categoriaDAO.listarCategorias();
                    if (cate == null)
                    {
                        categorias = new BindingList<CategoriaWS.categoria>();
                    }
                    else
                    {
                        categorias = new BindingList<CategoriaWS.categoria>(cate);
                    }
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = categorias;
                    break;
                case 2: //Para listar urgencias
                    var urge = urgenciaDAO.listarUrgencias();
                    if (urge == null)
                    {
                        urgencias = new BindingList<UrgenciaWS.urgencia>();
                    }
                    else
                    {
                        urgencias = new BindingList<UrgenciaWS.urgencia>(urge);
                    }
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = urgencias;
                    break;
                case 3: //Para listar agentes
                    var eq = frmInicioSesion.agenteLogueado.equipo;
                    var agen = agenteDAO.listarAgentesPorEquipo(eq);
                    if (agen == null)
                    {
                        agentes = new BindingList<AgenteWS.agente>();
                    }
                    else
                    {
                        agentes = new BindingList<AgenteWS.agente>(agen);
                    }
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = agentes;
                    break;
                case 4: //Para listar equipos
                    var equi = equipoDAO.listarEquipos();
                    if (equi == null)
                    {
                        equipos = new BindingList<EquipoWS.equipo>();
                    }
                    else
                    {
                        equipos = new BindingList<EquipoWS.equipo>(equi);
                    }
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = equipos;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (tipoSeleccionado)
            {
                case 1: //Para listar categorias
                    var cate = categoriaDAO.listarCategoriasPorNombre(txtBuscar.Text);
                    if (cate == null)
                    {
                        categorias = new BindingList<CategoriaWS.categoria>();
                    }
                    else
                    {
                        categorias = new BindingList<CategoriaWS.categoria>(cate);
                    }
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = categorias;
                    break;
                case 2: //Para listar urgencias
                    var urge = urgenciaDAO.listarUrgenciasPorNombre(txtBuscar.Text);
                    if (urge == null)
                    {
                        urgencias = new BindingList<UrgenciaWS.urgencia>();
                    }
                    else
                    {
                        urgencias = new BindingList<UrgenciaWS.urgencia>(urge);
                    }
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = urgencias;
                    break;
                case 3: //Para listar agentes
                    var agen = new BindingList<AgenteWS.agente>();
                    foreach(AgenteWS.agente ag in agentes)
                    {
                        bool coincide = ag.nombre.IndexOf(txtBuscar.Text, StringComparison.OrdinalIgnoreCase) >=0 
                            || ag.apellidoPaterno.IndexOf(txtBuscar.Text, StringComparison.OrdinalIgnoreCase) >= 0 
                            || ag.apellidoMaterno.IndexOf(txtBuscar.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                        if (coincide) agen.Add(ag);
                    }
                    if (agen == null)
                    
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = agen;
                    break;
                case 4: //Para listar equipos
                    var equi = equipoDAO.listarEquiposPorNombre(txtBuscar.Text);
                    if (equi == null)
                    {
                        equipos = new BindingList<EquipoWS.equipo>();
                    }
                    else
                    {
                        equipos = new BindingList<EquipoWS.equipo>(equi);
                    }
                    dgvLista.AutoGenerateColumns = false;
                    dgvLista.DataSource = equipos;
                    break;
            }
        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (tipoSeleccionado)
            {
                case 1: //Para el nombre de la categoria
                    CategoriaWS.categoria dataCate = dgvLista.Rows[e.RowIndex].DataBoundItem as CategoriaWS.categoria;

                    dgvLista.Rows[e.RowIndex].Cells["Id"].Value = dataCate.categoriaId;
                    dgvLista.Rows[e.RowIndex].Cells["Nombre"].Value = dataCate.nombre;
                    break;
                case 2: //Para el nombre de la urgencia
                    UrgenciaWS.urgencia dataUrge = dgvLista.Rows[e.RowIndex].DataBoundItem as UrgenciaWS.urgencia;

                    dgvLista.Rows[e.RowIndex].Cells["Id"].Value = dataUrge.urgenciaId;
                    dgvLista.Rows[e.RowIndex].Cells["Nombre"].Value = dataUrge.nombre;
                    break;
                case 3: //Para el nombre de la agente
                    AgenteWS.agente dataAgen = dgvLista.Rows[e.RowIndex].DataBoundItem as AgenteWS.agente;

                    dgvLista.Rows[e.RowIndex].Cells["Id"].Value = dataAgen.agenteId;
                    dgvLista.Rows[e.RowIndex].Cells["Nombre"].Value = dataAgen.nombre + " " + dataAgen.apellidoPaterno + " " + dataAgen.apellidoMaterno;
                    break;
                case 4: //Para el nombre de la equipo
                    EquipoWS.equipo dataEqui = dgvLista.Rows[e.RowIndex].DataBoundItem as EquipoWS.equipo;

                    dgvLista.Rows[e.RowIndex].Cells["Id"].Value = dataEqui.equipoId;
                    dgvLista.Rows[e.RowIndex].Cells["Nombre"].Value = dataEqui.nombre;
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }
    }
}
