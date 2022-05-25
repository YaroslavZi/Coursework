
namespace Ambulance.Views
{
    partial class BrigadeForm
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
            this.BrigadeListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddBrigadeButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteBrigadeButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // BrigadeListView1
            // 
            this.BrigadeListView1.AutoSizeTable = false;
            this.BrigadeListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BrigadeListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrigadeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.BrigadeListView1.Depth = 0;
            this.BrigadeListView1.FullRowSelect = true;
            this.BrigadeListView1.HideSelection = false;
            this.BrigadeListView1.Location = new System.Drawing.Point(6, 67);
            this.BrigadeListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.BrigadeListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BrigadeListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.BrigadeListView1.Name = "BrigadeListView1";
            this.BrigadeListView1.OwnerDraw = true;
            this.BrigadeListView1.Size = new System.Drawing.Size(808, 262);
            this.BrigadeListView1.TabIndex = 0;
            this.BrigadeListView1.UseCompatibleStateImageBehavior = false;
            this.BrigadeListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Назначение";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Район";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Адрес отдела";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Кол-во человек";
            this.columnHeader5.Width = 160;
            // 
            // AddBrigadeButton
            // 
            this.AddBrigadeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBrigadeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddBrigadeButton.Depth = 0;
            this.AddBrigadeButton.HighEmphasis = true;
            this.AddBrigadeButton.Icon = null;
            this.AddBrigadeButton.Location = new System.Drawing.Point(535, 338);
            this.AddBrigadeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddBrigadeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBrigadeButton.Name = "AddBrigadeButton";
            this.AddBrigadeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddBrigadeButton.Size = new System.Drawing.Size(100, 36);
            this.AddBrigadeButton.TabIndex = 1;
            this.AddBrigadeButton.Text = "Добавить";
            this.AddBrigadeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddBrigadeButton.UseAccentColor = false;
            this.AddBrigadeButton.UseVisualStyleBackColor = true;
            this.AddBrigadeButton.Click += new System.EventHandler(this.AddBrigadeButton_Click);
            // 
            // DeleteBrigadeButton
            // 
            this.DeleteBrigadeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteBrigadeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteBrigadeButton.Depth = 0;
            this.DeleteBrigadeButton.HighEmphasis = true;
            this.DeleteBrigadeButton.Icon = null;
            this.DeleteBrigadeButton.Location = new System.Drawing.Point(694, 338);
            this.DeleteBrigadeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteBrigadeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteBrigadeButton.Name = "DeleteBrigadeButton";
            this.DeleteBrigadeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteBrigadeButton.Size = new System.Drawing.Size(91, 36);
            this.DeleteBrigadeButton.TabIndex = 3;
            this.DeleteBrigadeButton.Text = "Удалить";
            this.DeleteBrigadeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteBrigadeButton.UseAccentColor = false;
            this.DeleteBrigadeButton.UseVisualStyleBackColor = true;
            this.DeleteBrigadeButton.Click += new System.EventHandler(this.DeleteBrigadeButton_Click);
            // 
            // BrigadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 384);
            this.Controls.Add(this.DeleteBrigadeButton);
            this.Controls.Add(this.AddBrigadeButton);
            this.Controls.Add(this.BrigadeListView1);
            this.Name = "BrigadeForm";
            this.Text = "Бригады";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView BrigadeListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialButton AddBrigadeButton;
        private MaterialSkin.Controls.MaterialButton DeleteBrigadeButton;
    }
}