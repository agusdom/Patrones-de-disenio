using Iterator.Ejemplo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _iterator = _collection.CreateIterator();
            InitializeComponent();
        }

        private Collection _collection = new ConcreteCollection();
        private IteratorEjemplo _iterator;

        private void Listar()
        {
            listBox1.Items.Clear();
            _iterator.First(); 
            Item i =_iterator.CurrentItem();
            if (i != null) listBox1.Items.Add(i);
            while (!_iterator.IsDone())
            {
                _iterator.Siguiente();
                listBox1 .Items.Add(_iterator.CurrentItem());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _item = new Item(textBox1.Text);
            _collection.Agregar(_item);

            Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _iterator.First();
            txtPrimero.Text = _iterator.CurrentItem().Nombre;
            txtActual.Text = _iterator.CurrentItem().Nombre; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_iterator.IsDone() == false)
            {
                _iterator.Siguiente();
                txtActual.Text = _iterator.CurrentItem().Nombre;
            }
        }
    }
}
