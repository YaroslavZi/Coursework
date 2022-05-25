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

namespace Ambulance.Views 
{
    public partial class WorkerForm : MaterialForm
    {
        private readonly IWorkerService _workerService = new WorkerService();

        public WorkerForm()
        {
            InitializeComponent();
            FillWorkerList();
        }
        private void FillWorkerList()
        {
            WorkerListView1.Items.Clear();

            var workers = _workerService.GetWorkers();

            foreach (var worker in workers)
            {
                var lvi = new ListViewItem(new[]
                {
                    worker.Id.ToString(),
                    worker.FirstName, worker.LastName,
                    worker.ExpYears, worker.Address
                });

                WorkerListView1.Items.Add(lvi);
            }
        }
         void AddWorkerlButton_Click(object sender, EventArgs e)
        {
            var newWorker = new NewWorker();

            if (newWorker.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newnewWorker = newWorker.Worker;
            _workerService.AddWorker(newnewWorker);
            FillWorkerList();
        }
        private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {

            if (WorkerListView1.SelectedIndices.Count == 0)
            {
                return;
            }

            var idx = WorkerListView1.SelectedIndices[0];

            var workerId = _workerService.GetWorkers()
                .ElementAt(idx)
                .Id;

            _workerService.RemoveWorker(workerId);
              FillWorkerList();
        }
    }
}