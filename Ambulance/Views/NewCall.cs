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
    partial class NewCall : MaterialForm
    {
        ICallService _callService = new CallService();
        IBrigadeService _brigadeService = new BrigadeService();
        public Call Call { get; set; }
        public NewCall()
        {
            InitializeComponent();
        }
        private void SaveNewCallButton_Click(object sender, EventArgs e)
        {
            var id = _callService.GetMaxId();
            Call = new Call
            {
                Id = id + 1,
                Situation = materialTextBox1.Text,
                Number = materialTextBox2.Text,
                Adress = materialTextBox3.Text,
                PatientName = materialTextBox4.Text,
                PatientAge = materialTextBox5.Text,
                CallName = materialTextBox6.Text
            };
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
