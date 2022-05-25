using Ambulance.Services;
using MaterialSkin.Controls;
using System;
using Ambulance.Entities;
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
    partial class NewWorker : MaterialForm
    {

        IWorkerService _workerService = new WorkerService();
        public Worker Worker { get; set; }
        public NewWorker()
        {
            InitializeComponent();
        }
        private void SaveNewWorkerButton_Click(object sender, EventArgs e)
        {
            var id = _workerService.GetMaxId();
            Worker = new Worker
            {
                Id = id + 1,
                FirstName = NameWorkerTextBox.Text,
                LastName = SurnameWorkerTextBox.Text,
                ExpYears = StajWorkerTextBox.Text,
                Address = AdressWorkerTextBox.Text
            };
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}