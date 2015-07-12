using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationApp
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;
       
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.ShowDialog();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clientsPreferencialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreferredUsers child = new frmPreferredUsers();
            child.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios child = new frmUsuarios();
            child.ShowDialog();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventos child = new frmEventos();
            child.ShowDialog();
        }

        private void mejorEspectáculoDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventaDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoldTickets child = new frmSoldTickets();
            child.ShowDialog();
        }

        private void peorEspectáculoDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventReport child = new frmEventReport();
            child.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin child = new frmLogin(this);
            child.ShowDialog();
        }

        private void inicioSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin child = new frmLogin(this);
            child.ShowDialog();
        }

        private void lugarDeEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEventLocation child = new frmEventLocation();
            child.ShowDialog();
        }
    }
}
