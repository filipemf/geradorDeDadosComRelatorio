using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GeradorComRelatorio
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dadosDataSet.Dados' table. You can move, or remove it, as needed.
            this.dadosTableAdapter.Fill(this.dadosDataSet.Dados);
            this.reportViewer1.RefreshReport();


            //chart1.Series["setor"].XValueMember = "setor";
            //chart1.Series["setor"].YValueMembers = "setor";

            //chart1.DataSource = dadosDataSet.Dados;
            //chart1.DataBind();

            
        }

        private void dadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dadosDataSet);

        }

        private void dadosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dadosDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Series["setor"].XValueMember = "setor";
            //chart1.Series["setor"].YValueMembers = "setor";
            //chart1.DataSource = dadosDataSet.Dados;
            //chart1.DataBind();
        }

    }
}
