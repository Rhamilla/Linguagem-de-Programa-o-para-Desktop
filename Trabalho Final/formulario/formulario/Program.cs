using System;
using system.Windows.MessageBox.Show;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GeradorFormulario
{
    public partial class FormPrincipal:Form
    {
        private List<string> campos;

        public FormPrincipal()
        {
            InitializeComponent();
            campos = new List<string>();
        }

        private void btnAdicionarCampo_Click(object sender, EventArgs e)
        {
            string novoCampo = txtNomeCampo.Text;

            if (!string.IsNullOrWhiteSpace(novoCampo))
            {
                campos.Add(novoCampo);
                lstCampos.Items.Add(novoCampo);
                txtNomeCampo.Clear();
            }
            else
            {
                MessageBox.Show("Digite um nome para o campo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarFormulario_Click(object sender, EventArgs e)
        {
            if (campos.Count > 0)
            {
                string codigoFormulario = GerarCodigoFormulario();
                MessageBox.Show("Código do Formulário Gerado:\n\n" + codigoFormulario, "Código Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Adicione pelo menos um campo antes de gerar o formulário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GerarCodigoFormulario()
        {
            string codigo = "using System;\nusing System.Windows.Forms;\n\nnamespace FormulariosGerados\n{\n";
            codigo += $"    public partial class FormularioGerado : Form\n";
            codigo += "    {\n";

            // Adiciona os controles para cada campo
            foreach (string campo in campos)
            {
                codigo += $"        private TextBox txt{campo};\n";
            }

            codigo += "\n";
            codigo += "        public FormularioGerado()\n";
            codigo += "        {\n";
            codigo += "            InitializeComponent();\n\n";

            // Inicializa os controles
            foreach (string campo in campos)
            {
                codigo += $"            txt{campo} = new TextBox();\n";
                codigo += $"            txt{campo}.Location = new System.Drawing.Point(10, {campos.IndexOf(campo) * 30 + 10});\n";
                codigo += $"            txt{campo}.Size = new System.Drawing.Size(200, 20);\n";
                codigo += $"            txt{campo}.Name = \"txt{campo}\";\n";
                codigo += $"            txt{campo}.Text = \"{campo}\";\n";
                codigo += "            Controls.Add(txt" + campo + ");\n\n";
            }

            codigo += "        }\n";
            codigo += "    }\n";
            codigo += "}\n";

            return codigo;
        }
    }
}
