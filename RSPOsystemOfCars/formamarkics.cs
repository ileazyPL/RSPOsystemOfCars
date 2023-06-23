using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSPOsystemOfCars
{
    public partial class formamarkics : Form
    {
        public formamarkics()
        {
            InitializeComponent();
        }

        private void avtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rSPOusersDataSet);

        }

        private void formamarkics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.rSPOusersDataSet.Avto);

        }

        private void avtoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {


        }
    }
}
