using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TableSoft.AgenteWS;

namespace TableSoft
{
    public partial class frmGestionarEquipo : Form
    {
        private EquipoWS.EquipoWSClient equipoDAO = new EquipoWS.EquipoWSClient();
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();

        private EquipoWS.equipo equipo;
        private BindingList<EquipoWS.categoria> categorias;

        private BindingList<AgenteWS.agente> agentes;

        public frmGestionarEquipo()
        {
            equipo = new EquipoWS.equipo();
            InitializeComponent();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;

            categorias = new BindingList<EquipoWS.categoria>();
            dgvListaCategorias.AutoGenerateColumns = false;
            dgvListaCategorias.DataSource = categorias;

            this.Width = 667;
            btnCancelar.Location = new System.Drawing.Point(537, 22);
        }

        public frmGestionarEquipo(EquipoWS.equipo equi)
        {
            equipo = equi;
            InitializeComponent();
            txtIDEquipo.Text = equipo.equipoId.ToString();
            txtNombre.Text = equipo.nombre;
            txtDescripcion.Text = equipo.descripcion;
            btnActualizar.Visible = true;
            btnGuardar.Visible = false;

            this.Width = 1005;
            btnCancelar.Location = new System.Drawing.Point(879, 22);

            if (equi.listaCategorias != null)
            {
                categorias = new BindingList<EquipoWS.categoria>(equi.listaCategorias.ToList());
            }
            else
            {
                categorias = new BindingList<EquipoWS.categoria>();
            }
            
            dgvListaCategorias.AutoGenerateColumns = false;
            dgvListaCategorias.DataSource = categorias;

            var equipoTemp = new AgenteWS.equipo();
            equipoTemp.equipoId = equi.equipoId;
            var listaAgentesTemp = agenteDAO.listarAgentesPorEquipo(equipoTemp);

            if(listaAgentesTemp != null)
            {
                agentes = new BindingList<AgenteWS.agente>(listaAgentesTemp);
            }
            else
            {
                agentes = new BindingList<AgenteWS.agente>();
            }


            dgvListaAgentes.AutoGenerateColumns = false;
            dgvListaAgentes.DataSource = agentes;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre del equipo.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre del equipo de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion del equipo.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion del equipo de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            
            equipo.nombre = txtNombre.Text;
            equipo.descripcion = txtDescripcion.Text;
            if(categorias != null)
            {
                equipo.listaCategorias = categorias.ToArray();
            }
            
            if (MessageBox.Show("¿Desea crear el registro?", "Crear Equipo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (equipoDAO.insertarEquipo(equipo) > 0)
                {
                    MessageBox.Show(
                    "Se ha creado el registro exitosamente",
                    "Registro exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se ha creado el registro",
                    "Registro no realizado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "No se ha creado el registro",
                "Registro no realizado",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            
            txtIDEquipo.Text = equipo.equipoId.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar el nombre del equipo.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtNombre.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "El nombre de la equipo de contener al menos una letra.",
                    "Error de nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show(
                    "Falta indicar la descripcion del equipo.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            if (Regex.Matches(txtDescripcion.Text, @"[a-zA-Z]").Count == 0)
            {
                MessageBox.Show(
                    "La descripcion del equipo de contener al menos una letra.",
                    "Error de descripcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
                return;
            }
            
            equipo.nombre = txtNombre.Text;
            equipo.descripcion = txtDescripcion.Text;
            if (categorias != null)
            {
                equipo.listaCategorias = categorias.ToArray();
            }

            if (MessageBox.Show("¿Desea actualizar el registro?", "Actualizar Equipo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (equipoDAO.actualizarEquipo(equipo) > -1)
                {
                    MessageBox.Show(
                    "Se ha actualizado el registro exitosamente",
                    "Actualización exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "No se ha realizado la actualización",
                    "Actualización no realizada",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                "No se ha realizado la actualización",
                "Actualización no realizada",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            
            this.DialogResult = DialogResult.OK;
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            var frmSelec = new frmSeleccionarCategoriaDisponible();
            if(frmSelec.ShowDialog() == DialogResult.OK)
            {
                var cat = new EquipoWS.categoria();
                cat.categoriaId = frmSelec.categoriaSeleccionada.categoriaId;
                cat.nombre = frmSelec.categoriaSeleccionada.nombre;
                cat.descripcion = frmSelec.categoriaSeleccionada.descripcion;
                cat.activo = frmSelec.categoriaSeleccionada.activo;

                categorias.Add(cat);
                dgvListaCategorias.Refresh();
            }
        }

        private void picMinus_Click(object sender, EventArgs e)
        {
            var cat = (EquipoWS.categoria)dgvListaCategorias.CurrentRow.DataBoundItem;
            categorias.Remove(cat);
        }

        private void dgvListaAgentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AgenteWS.agente data = dgvListaAgentes.Rows[e.RowIndex].DataBoundItem as AgenteWS.agente;

            dgvListaAgentes.Rows[e.RowIndex].Cells["Rol"].Value = data.rol.nombre;
        }
    }
}
