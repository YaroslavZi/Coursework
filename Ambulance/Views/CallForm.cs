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
    public partial class CallForm : MaterialForm
    {
        private readonly ICallService _callService = new CallService();
        public CallForm()
        {
            InitializeComponent();
            FillCallList();
        }
        private void FillCallList()
        {
            CallListView1.Items.Clear();

            var calls = _callService.GetCalls();

            foreach (var call in calls)
            {
                var lvi = new ListViewItem(new[]
                {
                    call.Id.ToString(),
                    call.Situation, call.Number,
                    call.Adress, call.PatientName,
                    call.PatientAge, call.CallName
                });
                CallListView1.Items.Add(lvi);
            }
        }
        private void AddCallButton_Click(object sender, EventArgs e)
        {
            var newCall = new NewCall();

            if (newCall.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            var newnewCall = newCall.Call;
            _callService.AddCall(newnewCall);
            FillCallList();
        }
        private void DeleteCallButton_Click(object sender, EventArgs e)
        {
            if (CallListView1.SelectedIndices.Count == 0)
            {
                return;
            }
            var idx = CallListView1.SelectedIndices[0];
            var callId = _callService.GetCalls()
                .ElementAt(idx)
                .Id;
                    _callService.RemoveCall(callId);
                    FillCallList();
                }

            }

        }