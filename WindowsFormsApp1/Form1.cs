using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Train train = new Train();

        private void HerbivorL_Click(object sender, EventArgs e)
        {
            train.AddAnimalsToList(Diet.Herbivor, Weight.Large);
            lbAnimalsToBeAdded.Items.Add($"{Diet.Herbivor} | {Weight.Large}");
        }

        private void btnHerbivorM_Click(object sender, EventArgs e)
        {
            train.AddAnimalsToList(Diet.Herbivor, Weight.Medium);
            lbAnimalsToBeAdded.Items.Add($"{Diet.Herbivor} | {Weight.Medium}");
        }

        private void btnHerbivorS_Click(object sender, EventArgs e)
        {
            train.AddAnimalsToList(Diet.Herbivor, Weight.Small);
            lbAnimalsToBeAdded.Items.Add($"{Diet.Herbivor} | {Weight.Small}");
        }

        private void btnCarnivorL_Click(object sender, EventArgs e)
        {
            train.AddAnimalsToList(Diet.Carnivor, Weight.Large);
            lbAnimalsToBeAdded.Items.Add($"{Diet.Carnivor} | {Weight.Large}");
        }

        private void btnCarnivorM_Click(object sender, EventArgs e)
        {
            train.AddAnimalsToList(Diet.Carnivor, Weight.Medium);
            lbAnimalsToBeAdded.Items.Add($"{Diet.Carnivor} | {Weight.Medium}");
        }

        private void btnCarnivorS_Click(object sender, EventArgs e)
        {
            train.AddAnimalsToList(Diet.Carnivor, Weight.Small);
            lbAnimalsToBeAdded.Items.Add($"{Diet.Carnivor} | {Weight.Small}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbAnimalsToBeAdded.Items.Clear();
            train.FillTrain();
        }
    }
}
