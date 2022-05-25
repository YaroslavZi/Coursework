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
    public partial class BrigadeForm : MaterialForm
    {
        private readonly IBrigadeService _brigadeService = new BrigadeService();
        public BrigadeForm()
        {
            InitializeComponent();
            FillBrigadeList();
        }
        private void FillBrigadeList()
        {
            BrigadeListView1.Items.Clear();

            var brigades = _brigadeService.GetBrigades();

            foreach (var brigade in brigades)
            {
                var lvi = new ListViewItem(new[]
                {
                    brigade.Id.ToString(),
                    brigade.Type, brigade.Rayon,
                    brigade.Adress, brigade.Amount
                });

                BrigadeListView1.Items.Add(lvi);
            }
        }
        private void AddBrigadeButton_Click(object sender, EventArgs e)
        {
            var newBrigade = new NewBrigade();

            if (newBrigade.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newnewBrigade = newBrigade.Brigade;
            _brigadeService.AddBrigade(newnewBrigade);
            FillBrigadeList();
        }
        private void DeleteBrigadeButton_Click(object sender, EventArgs e)
        {
            if (BrigadeListView1.SelectedIndices.Count == 0)
            {
                return;
            }
            var idx = BrigadeListView1.SelectedIndices[0];
            var brigadeId = _brigadeService.GetBrigades()
                .ElementAt(idx)
                .Id;
            _brigadeService.RemoveBrigade(brigadeId);
            FillBrigadeList();
        }
    }
}