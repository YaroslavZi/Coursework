using Ambulance.Services;
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
using Ambulance.Entities;

namespace Ambulance.Views
{
    partial class NewBrigade : MaterialForm
    {
        IBrigadeService _brigadeService = new BrigadeService();
        public Brigade Brigade { get; set; }
        public NewBrigade()
        {
            InitializeComponent();
        }
        private void BrigadeNewButton_Click(object sender, EventArgs e)
        {
            var id = _brigadeService.GetMaxId();
            Brigade = new Brigade
            {
                Id = id + 1,
                Type = materialTextBox1.Text,
                Rayon = materialTextBox2.Text,
                Adress = materialTextBox3.Text,
                Amount = materialTextBox4.Text
            };
        DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}