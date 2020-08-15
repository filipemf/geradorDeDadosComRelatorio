using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace GeradorComRelatorio
{
    public partial class Form1 : Form
    {

        RichTextBox nomeCompleto = new RichTextBox();
        RichTextBox fone = new RichTextBox();
        RichTextBox salarioBase = new RichTextBox();
        RichTextBox setores = new RichTextBox();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dados;Integrated Security=True;";

        public class Safety
        {
            public string nomeCompleto { get; set; }
            public string fone { get; set; }
            public string setores { get; set; }
            public decimal salarioBase { get; set; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void dadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dadosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dadosDataSet.Dados' table. You can move, or remove it, as needed.
            this.dadosTableAdapter.Fill(this.dadosDataSet.Dados);
            dadosDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dadosDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dadosDataGridView.GridColor = Color.White;

            dadosDataGridView.EnableHeadersVisualStyles = false;

        }

        private void SelectAllData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string cmdText = "SELECT * FROM Dados";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }


        private void TruncateAllData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string cmdText = "TRUNCATE TABLE Dados";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }

        }

        public void GerarNomes()
        {
            Random rnd = new Random();
            int quantidade = int.Parse(textBox1.Text);
            if (textBox1.Text == "")
            {
                quantidade = 10;
            }
       

            RichTextBox filho = new RichTextBox();
            RichTextBox filhoTemp = new RichTextBox();
            filhoTemp.LoadFile("../Database/nomes_filho.txt", RichTextBoxStreamType.PlainText);
            string filho_temp = filhoTemp.Text;
            string[] nomes_filho = filho_temp.Split('\n');
            List<string> lista_filho = new List<string>();

            RichTextBox sobrenomesR = new RichTextBox();
            sobrenomesR.LoadFile("../Database/sobrenomes1.txt", RichTextBoxStreamType.PlainText);
            string sobrenomes = sobrenomesR.Text;
            string[] sobrenomes_separados = sobrenomes.Split('\n');
 

            RichTextBox sobrenomes2R = new RichTextBox();
            sobrenomes2R.LoadFile("../Database/sobrenomes2.txt", RichTextBoxStreamType.PlainText);
            string sobrenomes2 = sobrenomes2R.Text;
            string[] sobrenomes2_separados = sobrenomes2.Split('\n');


            for (int i = 0; i < quantidade; i++)
            {

                int start4 = rnd.Next(0, nomes_filho.Length);

                int start5 = rnd.Next(0, sobrenomes_separados.Length);
                //int start7 = rnd.Next(0, sobrenomes_separados.Length);

                int start6 = rnd.Next(0, sobrenomes2_separados.Length);
                //int start8 = rnd.Next(0, sobrenomes2_separados.Length);

                lista_filho.Add(nomes_filho[start4] + " " + sobrenomes_separados[start5] + " " + sobrenomes2_separados[start6]);

            }

            int tamanho1 = lista_filho.Count;


            for (int j = 0; j < tamanho1; j++)
            {
                nomeCompleto.AppendText(lista_filho[j] + '\n');

            }
            lista_filho.Clear();

        }

        private void GerarDados()
        {

            nomeCompleto.Clear();
            fone.Clear();
            setores.Clear();
            salarioBase.Clear();

            GerarNomes();
            Random rnd = new Random();
            int quantidade = int.Parse(textBox1.Text);
            if (textBox1.Text == "")
            {
                quantidade = 10;
            }


            //Gerar números de celulares
            List<string> lista_celulares = new List<string>();
            for (int p = 0; p < quantidade; p++)
            {
                lista_celulares.Add("9");
                for (int j = 0; j < 8; j++)
                {
                    int numero_da_vez = rnd.Next(0, 9);
                    lista_celulares.Add(numero_da_vez.ToString());

                }
                int tamanho4 = lista_celulares.Count;
                for (int l = 0; l < tamanho4; l++)
                {
                    fone.AppendText(lista_celulares[l]);
                }
                lista_celulares.Clear();
                fone.AppendText("\n");
            }
            //Fim

            //Gerar setores
            List<string> lista_de_setores = new List<string>();
            lista_de_setores.Add("304");
            lista_de_setores.Add("022");
            lista_de_setores.Add("992");
            lista_de_setores.Add("130");
            lista_de_setores.Add("110");
            lista_de_setores.Add("001");
            lista_de_setores.Add("101");

            for (int i = 0; i < quantidade; i++)
            {
                List<string> lista_setoresFinal = new List<string>();

                int setorDaVez = rnd.Next(0, lista_de_setores.Count);

                lista_setoresFinal.Add(lista_de_setores[setorDaVez]);

                int tamanho = lista_setoresFinal.Count;
                for (int j = 0; j < tamanho; j++)
                {
                    setores.AppendText(lista_setoresFinal[j]);

                }
                lista_setoresFinal.Clear();
                setores.AppendText("\n");
            }
            //FIm

            //Gerar salarios
            List<string> lista_salarios = new List<string>();
            Random rndDecimal = new Random();
            for (int p = 0; p < quantidade; p++)
            {
                for (int j = 0; j < 1; j++)
                {
                    int valores = rnd.Next(1000, 15000);
                    lista_salarios.Add(valores.ToString());

                    lista_salarios.Add(",");

                    int valoresDecimais = rnd.Next(0, 99);
                    lista_salarios.Add(valoresDecimais.ToString());

                }
                int tamanho3 = lista_salarios.Count;
                for (int l = 0; l < tamanho3; l++)
                {
                    salarioBase.AppendText(lista_salarios[l]);
                }
                lista_salarios.Clear();
                salarioBase.AppendText("\n");
            }
            //Fim

        }


        //Gerar insert
        public void Cadastro()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            Safety Capsula = new Safety();
            int quantidade = int.Parse(textBox1.Text);
            if (textBox1.Text == "")
            {
                quantidade = 10;
            }


            string nomes = nomeCompleto.Text;
            nomeCompleto.Clear();
            string[] nomesFinais = nomes.Split('\n');

            string setoresIncompletos = setores.Text;
            setores.Clear();
            string[] setoresFinais = setoresIncompletos.Split('\n');

            string telefoneIncompleto = fone.Text;
            fone.Clear();
            string[] telefoneFinal = telefoneIncompleto.Split('\n');

            string salarioIncompleto = salarioBase.Text;
            salarioBase.Clear();
            string[] salarioFinal = salarioIncompleto.Split('\n');

            for (int i = 0; i < quantidade; i++)
            {
                Capsula.nomeCompleto = nomesFinais[i];
                Capsula.setores = setoresFinais[i];
                Capsula.fone = telefoneFinal[i];
                Capsula.salarioBase = decimal.Parse(salarioFinal[i]);

                SqlCommand cmd = new SqlCommand("INSERT INTO Dados (nome, setor, fone, salarioBase) VALUES (@nome, @setor, @fone, @salarioBase)", conn);
                cmd.Parameters.AddWithValue("@nome", Capsula.nomeCompleto);
                cmd.Parameters.AddWithValue("@setor", Capsula.setores);
                cmd.Parameters.AddWithValue("@fone", Capsula.fone);
                cmd.Parameters.AddWithValue("@salarioBase", Capsula.salarioBase);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }
            SelectAllData();
            textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerarDados();
            Cadastro();
            this.dadosTableAdapter.Fill(this.dadosDataSet.Dados);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TruncateAllData();
            this.dadosTableAdapter.Fill(this.dadosDataSet.Dados);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
