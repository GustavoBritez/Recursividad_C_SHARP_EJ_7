using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio7
{
    public partial class Form1 : Form
    {
        List<int> num = new List<int> { 1, 2, 3 };
        List<char> let = new List<char> { 'a', 'b', 'c' };
        List<Tuple<int, char>> listaCombinada= new List<Tuple<int, char>>();

        public Form1()
        {
            InitializeComponent();
        }
        public List<Tuple<int, char>> Aparear(List<int> num, List<char> let)
        {

            if ( 0 == num.Count)
            { 
                   return new List<Tuple<int, char>>();
            }
            //Combina elementos de ambas listas
            var tupla = Tuple.Create(num[0], let[0]);

            // Llamada recursiva con las listas reducidas
            var resultadoRecursivo = Aparear(num.GetRange(1, num.Count - 1), let.GetRange(1, let.Count - 1));

            resultadoRecursivo.Insert(0, tupla);

            return resultadoRecursivo;


        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            

            listaCombinada = Aparear(num, let);

            foreach (var tupla in listaCombinada)
            {
                txt_resultado.Text+=("(" + tupla.Item1 + ", '" + tupla.Item2 + "')")+ "   ";
            }


        }
    }
}
