using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos.Enumerables
{
    public partial class frmEstrucEnum : Form
    {
        IList<string> miListaHileras = new List<string>() { "Hello", "World" };
        int contador = 0;
        IDictionary<int, string> miDiccionario = new Dictionary<int,string>();
        HashSet<string> miHash = new HashSet<string>();
        LinkedList<string> miLinkedList = new LinkedList<string>();
        string[] miVector = new string[5];

        public frmEstrucEnum()
        {
            InitializeComponent();
        }

        private void frmEstrucEnum_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miListaHileras.Add(tbAgregar.Text);
            miDiccionario.Add(contador, tbAgregar.Text);
            miHash.Add(tbAgregar.Text);
            miLinkedList.AddFirst(tbAgregar.Text);
            try
            {
                miVector[contador] = tbAgregar.Text;

            }
            catch (IndexOutOfRangeException)
            {
                tbAgregar.Text = "Error, muschos datos";
               
            }
            contador++;
            tbAgregar.Text = "";


        }

        private void cbSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cbSalida.Items.Clear();
            foreach (var item in miListaHileras)
            {
                cbSalida.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbSalida.Items.Clear();
            foreach (var item in miLinkedList)
            {
                cbSalida.Items.Add(item);
            }
        }
    }
}
