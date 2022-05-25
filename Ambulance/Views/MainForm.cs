using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance.Views
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void WorkerPogButton_Click(object sender, EventArgs e)
        {
            WorkerForm worker = new WorkerForm();
            this.Hide();
            worker.ShowDialog();
            this.Show();
        }
        private void CallPogButton_Click(object sender, EventArgs e)
        {
            CallForm call = new CallForm();
            this.Hide();
            call.ShowDialog();
            this.Show();
        }
        private void BrigadePogButton_Click(object sender, EventArgs e)
        {
            BrigadeForm brigade = new BrigadeForm();
            this.Hide();
            brigade.ShowDialog();
            this.Show();
        }
    }
}