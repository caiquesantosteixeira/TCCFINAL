using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCFINAL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            PreencherGrid();
        }

        public void PreencherGrid() 
        {
            var lista = new List<DadoObj>();

            lista.Add(new DadoObj("Comprimento dos Condutores da Malha de Terra sem Eletrodo", "78,43 m"));

            lista.Add(new DadoObj("Resistência de Aterramento de um Eletrodo Vertical", "22,68 (Ω)"));

            lista.Add(new DadoObj("Resistência de Aterramento do Conjunto de Eletrodos Verticais", "1,169 (Ω)"));

            lista.Add(new DadoObj("Resistência Mútua dos Cabos e Eletrodos Verticais", "0,57 (Ω)"));

            lista.Add(new DadoObj("Resistência Total da Malha", "1,010 (Ω)"));

            lista.Add(new DadoObj("Comprimento do Condutor com Hastes", "131,35 m"));

            lista.Add(new DadoObj("Tensão de Passo", "2.935,90 V"));

            lista.Add(new DadoObj("Tensão de Passo na Perif. da Malha no Comprimento da Malha", "440,49V"));

            lista.Add(new DadoObj("Tensão de Passo Existente na Periferia da Malha na Larg. da Malha", "164,66 V"));

            lista.Add(new DadoObj("Tensão de Toque", "853,05 V"));

            lista.Add(new DadoObj("Tensão de Toque Exist. na Perif. da Malha no Compr. da Malha", "94 V"));

            lista.Add(new DadoObj("Tensão de Toque na Periferia da Malha no Comprimento da Malha", "42,25 V"));

            lista.Add(new DadoObj("Corrente Máxima de Choque", "164,04 mA"));

            lista.Add(new DadoObj("Corrente de Choque Devido à Tensão de Passo na Perifieria da Malha sem Camada de Concreto", "120,01 mA"));

            lista.Add(new DadoObj("Corrente de Choque Devido à Tensão de Passo na Perifieria da Malha com Camada de Concreto Seco", "0,157 mA"));

            lista.Add(new DadoObj("Corrente de choque Devido à Tensão de Toque na Perifieria da Malha sem Camada de Concreto Seco", "68,51 mA"));

            lista.Add(new DadoObj("Corrente de choque Existente Devido à Tensão de Toque na Perifieria da Malha com Camada de Concreto Seco", "0,538 mA"));

            lista.Add(new DadoObj("Corrente Minima de Acionamento do Relé de Terra", "207,89 A"));

            lista.Add(new DadoObj("Resistividade da primeira camada", "62(Ω)"));

            lista.Add(new DadoObj("Resistividade da segunda camada", "10(Ω)"));

            //AQUI COMEÇA OS VERMELHOS

            lista.Add(new DadoObj("Seção do Condutor de Cobre nú Utilizado", "50mm²"));

            lista.Add(new DadoObj("Corrente de Curto Circuito Fase Terra", "520 A"));

            lista.Add(new DadoObj("Resistividade do Concreto Seco", "2.800 Ω"));

            lista.Add(new DadoObj("Profundide da Camada Superficial DE Concreto", "0,10 m"));

            lista.Add(new DadoObj("Comprimento de Uma Haste Utilizada", "2,40 m"));

            lista.Add(new DadoObj("Eletrodos Verticais - Hastes Utilizadas", "21 Und."));

            lista.Add(new DadoObj("Condutores principais", "09 Und."));

            lista.Add(new DadoObj("Condutores de junção", "05 Und."));

            dgvDados.DataSource = null; //Limpa o grid;
            dgvDados.DataSource = lista;

            
            foreach (DataGridViewColumn column in dgvDados.Columns)
            {
                if (column.DataPropertyName == "Dado")
                {
                    column.Width = 500;
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                  
                if (column.DataPropertyName == "Resultado")
                    column.Width = 100; 

            }

            dgvDados.RowTemplate.Height = 30;
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email enviado com sucesso!");
        }
    }
}

public class DadoObj
{
    public DadoObj(string textoDado, string textoResultado) 
    {
        Dado = textoDado;
        Resultado = textoResultado;
    }
    public string Dado{ get; set; }
    public string Resultado { get; set; }
}
