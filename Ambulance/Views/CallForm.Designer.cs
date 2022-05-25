
namespace Ambulance.Views
{
    partial class CallForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CallListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddCallButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteCallButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CallListView1
            // 
            this.CallListView1.AutoSizeTable = false;
            this.CallListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CallListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CallListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.CallListView1.Depth = 0;
            this.CallListView1.FullRowSelect = true;
            this.CallListView1.HideSelection = false;
            this.CallListView1.Location = new System.Drawing.Point(6, 67);
            this.CallListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.CallListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CallListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.CallListView1.Name = "CallListView1";
            this.CallListView1.OwnerDraw = true;
            this.CallListView1.Size = new System.Drawing.Size(1162, 279);
            this.CallListView1.TabIndex = 0;
            this.CallListView1.UseCompatibleStateImageBehavior = false;
            this.CallListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Причина";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Номер (Тел)";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Адрес";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ФИО пациента";
            this.columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Возраст";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ФИО вызывающего";
            this.columnHeader7.Width = 230;
            // 
            // AddCallButton
            // 
            this.AddCallButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddCallButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddCallButton.Depth = 0;
            this.AddCallButton.HighEmphasis = true;
            this.AddCallButton.Icon = null;
            this.AddCallButton.Location = new System.Drawing.Point(918, 355);
            this.AddCallButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddCallButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddCallButton.Name = "AddCallButton";
            this.AddCallButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddCallButton.Size = new System.Drawing.Size(100, 36);
            this.AddCallButton.TabIndex = 1;
            this.AddCallButton.Text = "Добавить";
            this.AddCallButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddCallButton.UseAccentColor = false;
            this.AddCallButton.UseVisualStyleBackColor = true;
            this.AddCallButton.Click += new System.EventHandler(this.AddCallButton_Click);
            // 
            // DeleteCallButton
            // 
            this.DeleteCallButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteCallButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteCallButton.Depth = 0;
            this.DeleteCallButton.HighEmphasis = true;
            this.DeleteCallButton.Icon = null;
            this.DeleteCallButton.Location = new System.Drawing.Point(1053, 355);
            this.DeleteCallButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteCallButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteCallButton.Name = "DeleteCallButton";
            this.DeleteCallButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteCallButton.Size = new System.Drawing.Size(91, 36);
            this.DeleteCallButton.TabIndex = 3;
            this.DeleteCallButton.Text = "Удалить";
            this.DeleteCallButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteCallButton.UseAccentColor = false;
            this.DeleteCallButton.UseVisualStyleBackColor = true;
            this.DeleteCallButton.Click += new System.EventHandler(this.DeleteCallButton_Click);
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 414);
            this.Controls.Add(this.DeleteCallButton);
            this.Controls.Add(this.AddCallButton);
            this.Controls.Add(this.CallListView1);
            this.Name = "CallForm";
            this.Text = "Вызовы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView CallListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialButton AddCallButton;
        private MaterialSkin.Controls.MaterialButton DeleteCallButton;
    }
}