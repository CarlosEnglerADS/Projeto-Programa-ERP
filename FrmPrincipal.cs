using System.Security.Policy;

namespace ProgramaErp
{
    public partial class FrmPrincipal : Form
    {


        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private bool maximizado = false;

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            // Obt�m a data e hora atual
            DateTime dataHoraAtual = DateTime.Now;

            // Obt�m a informa��o da cultura do sistema
            var cultureInfo = System.Globalization.CultureInfo.CurrentCulture;

            // Obt�m o nome do pa�s/regi�o (DisplayName)
            string paisRegiao = cultureInfo.DisplayName;

            // Define o texto do Label para exibir o nome do pa�s/regi�o e a data/hora
            LblLocalDataHora.Text = $"DATA: {dataHoraAtual.ToString().ToUpper()} \n" +
                                    $"EDIOMA E PA�S: {paisRegiao.ToUpper()}";
        }



        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GraficoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripComboBox3_Click(object sender, EventArgs e)
        {

        }

        private void DemissoesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formul�rio atual
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza o formul�rio
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {

            if (!maximizado)
            {
                // Se o formul�rio n�o estiver maximizado, maximiza-o
                this.WindowState = FormWindowState.Maximized;
                maximizado = true;
            }
            else
            {
                // Se o formul�rio estiver maximizado, restaura o tamanho original
                this.WindowState = FormWindowState.Normal;
                maximizado = false;
            }
        }

        private void VendasAVistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LblLocalDataHora_Click(object sender, EventArgs e)
        {

        }
    }
}

