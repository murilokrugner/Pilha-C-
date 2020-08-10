using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Trabalho
{
    public partial class FrmPrincipal : Form
    {
        Stack stack = new Stack();
        string data;
        Array pointer;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btEmpilhar_Click(object sender, EventArgs e)
        {
            if (TextStack.Text == "")
            {
                MessageBox.Show("Porfavor, digite um número para empilhar!");
                return;
            }
            else
            {
                data = TextStack.Text;
                
                TextStack.Clear();

                stack.Push(data);

                pointer = stack.ToArray();

                listView.Items.Clear();

                foreach (string i in pointer)
                {                    
                    listView.Items.Add(i.ToString());
                    listView.Items.Add("\n");
                    
                }                
            }

            TextStack.Focus();

        }

        private void btDesempilhar_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("A pilha está vazia");
                return;
            }
            
            stack.Pop();

            pointer = stack.ToArray();

            listView.Items.Clear();

            foreach (string i in pointer)
            {
                listView.Items.Add(i.ToString());
                listView.Items.Add("\n");

            }

            TextStack.Focus();
        }

        private void btTamanhoPilha_Click(object sender, EventArgs e)
        {
            int lengnt = stack.Count;
            MessageBox.Show("Tamanho da pilha: " + lengnt.ToString() + " elementos");

            TextStack.Focus();
        }

        private void btMostrarTopo_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                MessageBox.Show("Valor do topo da pilha: " + stack.Peek().ToString());

                TextStack.Focus();
            }
            else
            {
                MessageBox.Show("A pilha está vazia, empilhe algum número!");
            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            stack.Clear();
            listView.Items.Clear();
           
            MessageBox.Show("PILHA DESTRUIDA!");

            TextStack.Focus();
        }
    }
}
