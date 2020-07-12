using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableSoft
{
    public partial class frmLogin : Form
    {
        // Para el formulario
        private bool passwordShown = false;
        private bool canLogin = false;
        private readonly float[] fontSize = { 6.75F, 8.25F, 9F, 9.75F, 11.25F };
        private int currentSizeEmail, currentSizePassword;
        private bool emailFocused = true, passwordFocused = false;
        private bool boxesDown = false;
        private bool loginError = false;
        private int currentError;
        private enum ErrorType
        {
            InvalidEmail,
            InvalidPassword
        };

        // Para conectarse a la base de datos
        private PersonaWS.PersonaWSClient personaDAO = new PersonaWS.PersonaWSClient();
        private AgenteWS.AgenteWSClient agenteDAO = new AgenteWS.AgenteWSClient();
        private EmpleadoWS.EmpleadoWSClient empleadoDAO = new EmpleadoWS.EmpleadoWSClient();
        public static AgenteWS.agente agenteLogueado;
        public static EmpleadoWS.empleado empleadoLogueado;

        public frmLogin()
        {
            InitializeComponent();
            MakePicPanelTransparent();
        }

        // FUNCIONES PARA EL FORMULARIO

        private void MakePicPanelTransparent()
        {
            pnlMov2.Parent = picCia;
            pnlMov2.Location = new Point(0, 0);
            pnlMov2.BackColor = Color.Transparent;
        }

        private void HideBoxes()
        {
            pnlBoxes.Visible = false;
        }

        private void ShowBoxes()
        {
            pnlBoxes.Visible = true;
        }

        private void ShowLoadingIcon()
        {
            picLoading.Visible = true;
        }

        private void HideLoadingIcon()
        {
            picLoading.Visible = false;
        }

        private void ClearEmail()
        {
            txtEmail.Text = "";
        }

        private void ClearPassword()
        {
            txtPassword.Text = "";
        }

        private void MoveBoxesDown()
        {
            pnlEmail.Location = new Point(pnlEmail.Location.X, pnlEmail.Location.Y + 68);
            pnlPassword.Location = new Point(pnlPassword.Location.X, pnlPassword.Location.Y + 68);
            picLogin.Location = new Point(picLogin.Location.X, picLogin.Location.Y + 68);
            boxesDown = true;
        }

        private void MoveBoxesUp()
        {
            pnlEmail.Location = new Point(pnlEmail.Location.X, pnlEmail.Location.Y - 68);
            pnlPassword.Location = new Point(pnlPassword.Location.X, pnlPassword.Location.Y - 68);
            picLogin.Location = new Point(picLogin.Location.X, picLogin.Location.Y - 68);
            boxesDown = false;
        }

        private void ShowInvalidEmailErrorMessage()
        {
            lblError.Visible = true;
            lblError.Text = "Tus credenciales de inicio de sesión\nno coinciden con ninguna cuenta\nen nuestro sistema.";
        }

        private void ShowInvalidPasswordErrorMessage()
        {
            lblError.Visible = true;
            lblError.Text = "La contraseña ingresada para el\ncorreo electrónico brindado\nes incorrecta.";
        }

        private void HideErrorMessage()
        {
            lblError.Visible = false;
        }

        private void SetErrorBoxes()
        {
            if (!boxesDown)
            {
                MoveBoxesDown();
            }

            if (currentError == (int)ErrorType.InvalidEmail)
            {
                ShowInvalidEmailErrorMessage();
            }
            else if (currentError == (int)ErrorType.InvalidPassword)
            {
                ShowInvalidPasswordErrorMessage();
            }

            picEmailBox.Image = Properties.Resources.LoginBoxError;
            txtEmail.BackColor = Color.FromArgb(244, 227, 245);
            lblEmail.BackColor = Color.FromArgb(244, 227, 245);

            picPasswordBox.Image = Properties.Resources.LoginBoxError;
            txtPassword.BackColor = Color.FromArgb(244, 227, 245);
            lblPassword.BackColor = Color.FromArgb(244, 227, 245);
            if (currentError == (int)ErrorType.InvalidPassword)
            {
                picTogglePassword.BackColor = Color.FromArgb(244, 227, 245);
            }
        }

        private void EnableLogin()
        {
            picLogin.Image = Properties.Resources.LoginEnabled;
            picLogin.Cursor = Cursors.Hand;
            canLogin = true;
        }

        private void WaitLoading()
        {
            Thread.Sleep(1000);
        }

        private void DisableLogin()
        {
            picLogin.Image = Properties.Resources.LoginDisabled;
            picLogin.Cursor = Cursors.Default;
            canLogin = false;
        }

        private void RestartTogglePassword()
        {
            txtPassword.PasswordChar = '•';
            picTogglePassword.Image = Properties.Resources.PasswordHidden;
            passwordShown = false;
        }

        // INICIOS DE SESION

        private void AbrirInicioEmpleado()
        {
            frmInicioEmpleado frm = new frmInicioEmpleado();

            frm.FormClosing += delegate
            {
                Show();
            };

            frm.Show();
        }

        private void AbrirInicioAgente()
        {
            frmInicioAgente frm = new frmInicioAgente();

            frm.FormClosing += delegate
            {
                Show();
            };

            frm.Show();
        }

        private void AbrirInicioSupervisor()
        {
            frmInicioSupervisor frm = new frmInicioSupervisor();

            frm.FormClosing += delegate
            {
                Show();
            };

            frm.Show();
        }

        private void AbrirInicioAdmin()
        {
            frmInicioAdmin frm = new frmInicioAdmin();

            frm.FormClosing += delegate
            {
                Show();
            };

            frm.Show();
        }

        // EVENTOS

        private void pnlMov_MouseDown(object sender, MouseEventArgs e)
        {
            if (!loginError)
            {
                ActiveControl = null;
            }
            Movimiento.MoverVentana(Handle, e.Button);
        }

        private void picEmailBox_MouseEnter(object sender, System.EventArgs e)
        {
            lblEmail.ForeColor = Color.FromArgb(126, 126, 126);

            if (!txtEmail.Focused && !emailFocused && !loginError)
            {
                picEmailBox.Image = Properties.Resources.LoginBoxEnter;
                txtEmail.BackColor = Color.FromArgb(231, 231, 231);
                lblEmail.BackColor = Color.FromArgb(231, 231, 231);
            }
        }

        private void picPasswordBox_MouseEnter(object sender, System.EventArgs e)
        {
            lblPassword.ForeColor = Color.FromArgb(126, 126, 126);

            if (!txtPassword.Focused && !passwordFocused && !loginError)
            {
                picPasswordBox.Image = Properties.Resources.LoginBoxEnter;
                txtPassword.BackColor = Color.FromArgb(231, 231, 231);
                lblPassword.BackColor = Color.FromArgb(231, 231, 231);
            }
        }

        private void picEmailBox_MouseLeave(object sender, System.EventArgs e)
        {
            lblEmail.ForeColor = Color.FromArgb(153, 153, 153);

            if (!txtEmail.Focused && !emailFocused && !loginError)
            {
                picEmailBox.Image = Properties.Resources.LoginBox;
                txtEmail.BackColor = Color.FromArgb(237, 237, 237);
                lblEmail.BackColor = Color.FromArgb(237, 237, 237);
            }
        }

        private void picPasswordBox_MouseLeave(object sender, System.EventArgs e)
        {
            lblPassword.ForeColor = Color.FromArgb(153, 153, 153);

            if (!txtPassword.Focused && !passwordFocused && !loginError)
            {
                picPasswordBox.Image = Properties.Resources.LoginBox;
                txtPassword.BackColor = Color.FromArgb(237, 237, 237);
                lblPassword.BackColor = Color.FromArgb(237, 237, 237);
            }
        }

        private void picEmailBox_Click(object sender, System.EventArgs e)
        {
            txtEmail.Select();
        }

        private void picPasswordBox_Click(object sender, System.EventArgs e)
        {
            txtPassword.Select();
        }

        private void txtEmail_TextChanged(object sender, System.EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    EnableLogin();
                }
            }
            else
            {
                DisableLogin();
            }
        }

        private void txtPassword_TextChanged(object sender, System.EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                if (txtEmail.Text != "")
                {
                    EnableLogin();
                }
            }
            else
            {
                DisableLogin();
            }
        }

        private void picLogin_MouseEnter(object sender, System.EventArgs e)
        {
            if (canLogin)
            {
                picLogin.Image = Properties.Resources.LoginEnabledEnter;
            }
        }

        private void picLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (canLogin)
            {
                picLogin.Image = Properties.Resources.LoginEnabledDown;
            }
        }

        private void picLogin_MouseLeave(object sender, System.EventArgs e)
        {
            if (canLogin)
            {
                picLogin.Image = Properties.Resources.LoginEnabled;
            }
        }

        private void picLogin_MouseUp(object sender, MouseEventArgs e)
        {
            if (canLogin)
            {
                picLogin.Image = Properties.Resources.LoginEnabledEnter;
            }
        }

        private void txtEmail_Enter(object sender, System.EventArgs e)
        {
            emailFocused = true;

            if (MouseButtons == MouseButtons.None)
            {
                txtEmail.SelectAll();
            }

            if (loginError && currentError == (int)ErrorType.InvalidPassword)
            {
                loginError = false;
                picTogglePassword.BackColor = Color.Transparent;
            }

            picEmailBox.Image = Properties.Resources.LoginBoxDown;
            txtEmail.BackColor = Color.FromArgb(249, 249, 249);
            lblEmail.BackColor = Color.FromArgb(249, 249, 249);
            currentSizeEmail = fontSize.Length - 1;
            tmrEmailEnter.Enabled = true;
        }

        private void txtEmail_Leave(object sender, System.EventArgs e)
        {
            emailFocused = false;

            picEmailBox.Image = Properties.Resources.LoginBox;
            txtEmail.BackColor = Color.FromArgb(237, 237, 237);
            lblEmail.BackColor = Color.FromArgb(237, 237, 237);
            lblEmail.ForeColor = Color.FromArgb(153, 153, 153);

            if (txtEmail.Text == "")
            {
                currentSizeEmail = 0;
                tmrEmailLeave.Enabled = true;
            }
        }

        private void txtPassword_Enter(object sender, System.EventArgs e)
        {
            passwordFocused = true;

            if (MouseButtons == MouseButtons.None)
            {
                txtPassword.SelectAll();
            }

            if (loginError && currentError == (int)ErrorType.InvalidEmail)
            {
                loginError = false;
            }

            picPasswordBox.Image = Properties.Resources.LoginBoxDown;
            txtPassword.BackColor = Color.FromArgb(249, 249, 249);
            lblPassword.BackColor = Color.FromArgb(249, 249, 249);
            picTogglePassword.Visible = true;
            currentSizePassword = fontSize.Length - 1;
            tmrPasswordEnter.Enabled = true;
        }

        private void txtPassword_Leave(object sender, System.EventArgs e)
        {
            passwordFocused = false;

            picPasswordBox.Image = Properties.Resources.LoginBox;
            txtPassword.BackColor = Color.FromArgb(237, 237, 237);
            lblPassword.BackColor = Color.FromArgb(237, 237, 237);
            lblPassword.ForeColor = Color.FromArgb(153, 153, 153);
            picTogglePassword.Visible = false;

            if (txtPassword.Text == "")
            {
                currentSizePassword = 0;
                tmrPasswordLeave.Enabled = true;
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && canLogin)
            {
                picLogin_Click(null, null);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private async void picLogin_Click(object sender, System.EventArgs e)
        {
            // INICIAR SESION

            if (canLogin)
            {
                HideBoxes();
                ShowLoadingIcon();
                await Task.Run(() => WaitLoading());

                if (personaDAO.verificarCorreo(txtEmail.Text) == -1)
                {
                    loginError = true;
                    currentError = (int)ErrorType.InvalidEmail;
                    ClearPassword();
                    txtPassword_Leave(null, null);
                    txtEmail.Select();
                    RestartTogglePassword();
                    SetErrorBoxes();
                    HideLoadingIcon();
                    ShowBoxes();
                }
                else
                {
                    PersonaWS.persona user = personaDAO.verificarPersona(txtEmail.Text, txtPassword.Text);

                    if (user != null)
                    {
                        loginError = false;

                        if (user.tipo == 'E')
                        {
                            empleadoLogueado = empleadoDAO.buscarEmpleadoPorCodigo(user.codigo);
                            AbrirInicioEmpleado();
                        }
                        else if (user.tipo == 'A')
                        {
                            agenteLogueado = agenteDAO.buscarAgentePorCodigo(user.codigo);
                            if (agenteLogueado.rol.nombre.Contains("AGENTE"))
                            {
                                AbrirInicioAgente();
                            }
                            else if (agenteLogueado.rol.nombre.Contains("SUPERVISOR"))
                            {
                                AbrirInicioSupervisor();
                            }
                            else if (agenteLogueado.rol.nombre.Contains("ADMIN"))
                            {
                                AbrirInicioAdmin();
                            }
                        }

                        Hide();
                        if (boxesDown)
                        {
                            MoveBoxesUp();
                            HideErrorMessage();
                        }
                        ClearEmail();
                        ClearPassword();
                        txtPassword_Leave(null, null);
                        txtEmail.Select();
                        RestartTogglePassword();
                        ShowBoxes();
                    }
                    else
                    {
                        loginError = true;
                        currentError = (int)ErrorType.InvalidPassword;
                        ClearPassword();
                        txtPassword.Select();
                        SetErrorBoxes();
                        RestartTogglePassword();
                        HideLoadingIcon();
                        ShowBoxes();
                        txtPassword.Select();
                    }
                }
            }
        }

        private void picClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void picClose_MouseEnter(object sender, System.EventArgs e)
        {
            picClose.Image = Properties.Resources.CloseEnter;
        }

        private void picClose_MouseDown(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.CloseDown;
        }

        private void picClose_MouseLeave(object sender, System.EventArgs e)
        {
            picClose.Image = Properties.Resources.Close;
        }

        private void picClose_MouseUp(object sender, MouseEventArgs e)
        {
            picClose.Image = Properties.Resources.CloseEnter;
        }

        private void tmrEmailEnter_Tick(object sender, System.EventArgs e)
        {
            Point loc = lblEmail.Location;

            if (loc == new Point(8, 6))
            {
                tmrEmailEnter.Enabled = false;
                return;
            }

            lblEmail.Font = new Font("Gill Sans MT", fontSize[--currentSizeEmail], FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(loc.X - 2, loc.Y - 2);
        }

        private void tmrPasswordEnter_Tick(object sender, System.EventArgs e)
        {
            Point loc = lblPassword.Location;

            if (loc == new Point(8, 6))
            {
                tmrPasswordEnter.Enabled = false;
                return;
            }

            lblPassword.Font = new Font("Gill Sans MT", fontSize[--currentSizePassword], FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(loc.X - 2, loc.Y - 2);
        }

        private void tmrEmailLeave_Tick(object sender, System.EventArgs e)
        {
            Point loc = lblEmail.Location;

            if (loc == new Point(16, 14))
            {
                tmrEmailLeave.Enabled = false;
                return;
            }

            lblEmail.Font = new Font("Gill Sans MT", fontSize[++currentSizeEmail], FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(loc.X + 2, loc.Y + 2);
        }

        private void tmrPasswordLeave_Tick(object sender, System.EventArgs e)
        {
            Point loc = lblPassword.Location;

            if (loc == new Point(16, 14))
            {
                tmrPasswordLeave.Enabled = false;
                return;
            }

            lblPassword.Font = new Font("Gill Sans MT", fontSize[++currentSizePassword], FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(loc.X + 2, loc.Y + 2);
        }

        private void lblForgot_MouseEnter(object sender, System.EventArgs e)
        {
            lblForgot.ForeColor = Color.Black;
        }

        private void lblForgot_MouseLeave(object sender, System.EventArgs e)
        {
            lblForgot.ForeColor = Color.FromArgb(178, 178, 178);
        }

        private void lblForgot_Click(object sender, System.EventArgs e)
        {
            frmRecuperarPassword frm = new frmRecuperarPassword
            {
                StartPosition = FormStartPosition.Manual,
                Location = Location
            };

            frm.FormClosing += delegate
            {
                Show();
            };

            frm.Show();
            Hide();
            if (boxesDown)
            {
                MoveBoxesUp();
                HideErrorMessage();
            }
            loginError = false;
            ClearEmail();
            ClearPassword();
            txtEmail_Enter(null, null);
            txtPassword_Leave(null, null);
            txtEmail.Select();
        }

        private void OnOuterMouseDown(object sender, MouseEventArgs e)
        {
            if (!loginError)
            {
                ActiveControl = null;
            }
        }

        private void picTogglePassword_Click(object sender, System.EventArgs e)
        {
            if (passwordShown) {
                txtPassword.PasswordChar = '•';
                picTogglePassword.Image = Properties.Resources.PasswordHidden;
                passwordShown = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                picTogglePassword.Image = Properties.Resources.PasswordShown;
                passwordShown = true;
            }
        }
    }
}
