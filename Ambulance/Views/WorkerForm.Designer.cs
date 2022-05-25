
namespace Ambulance.Views
{
    partial class WorkerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WorkerListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddWorkerlButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteWorkerButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // WorkerListView1
            // 
            this.WorkerListView1.AutoSizeTable = false;
            this.WorkerListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WorkerListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkerListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.WorkerListView1.Depth = 0;
            this.WorkerListView1.FullRowSelect = true;
            this.WorkerListView1.HideSelection = false;
            this.WorkerListView1.Location = new System.Drawing.Point(6, 67);
            this.WorkerListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.WorkerListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.WorkerListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.WorkerListView1.Name = "WorkerListView1";
            this.WorkerListView1.OwnerDraw = true;
            this.WorkerListView1.Size = new System.Drawing.Size(732, 308);
            this.WorkerListView1.TabIndex = 0;
            this.WorkerListView1.UseCompatibleStateImageBehavior = false;
            this.WorkerListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Стаж";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес";
            this.columnHeader5.Width = 220;
            // 
            // AddWorkerlButton
            // 
            this.AddWorkerlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddWorkerlButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddWorkerlButton.Depth = 0;
            this.AddWorkerlButton.HighEmphasis = true;
            this.AddWorkerlButton.Icon = null;
            this.AddWorkerlButton.Location = new System.Drawing.Point(449, 384);
            this.AddWorkerlButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddWorkerlButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddWorkerlButton.Name = "AddWorkerlButton";
            this.AddWorkerlButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddWorkerlButton.Size = new System.Drawing.Size(100, 36);
            this.AddWorkerlButton.TabIndex = 1;
            this.AddWorkerlButton.Text = "Добавить";
            this.AddWorkerlButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddWorkerlButton.UseAccentColor = false;
            this.AddWorkerlButton.UseVisualStyleBackColor = true;
            this.AddWorkerlButton.Click += new System.EventHandler(this.AddWorkerlButton_Click);
            // 
            // DeleteWorkerButton
            // 
            this.DeleteWorkerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteWorkerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteWorkerButton.Depth = 0;
            this.DeleteWorkerButton.HighEmphasis = true;
            this.DeleteWorkerButton.Icon = null;
            this.DeleteWorkerButton.Location = new System.Drawing.Point(613, 384);
            this.DeleteWorkerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteWorkerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteWorkerButton.Name = "DeleteWorkerButton";
            this.DeleteWorkerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteWorkerButton.Size = new System.Drawing.Size(91, 36);
            this.DeleteWorkerButton.TabIndex = 3;
            this.DeleteWorkerButton.Text = "Удалить";
            this.DeleteWorkerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteWorkerButton.UseAccentColor = false;
            this.DeleteWorkerButton.UseVisualStyleBackColor = true;
            this.DeleteWorkerButton.Click += new System.EventHandler(this.DeleteWorkerButton_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.DeleteWorkerButton);
            this.Controls.Add(this.AddWorkerlButton);
            this.Controls.Add(this.WorkerListView1);
            this.Name = "WorkerForm";
            this.Text = "Сотрудники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView WorkerListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialButton AddWorkerlButton;
        private MaterialSkin.Controls.MaterialButton DeleteWorkerButton;
    }
}

