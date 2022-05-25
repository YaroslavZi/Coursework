
namespace Ambulance.Views
{
    partial class MainForm
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
            this.WorkerPogButton = new MaterialSkin.Controls.MaterialButton();
            this.CallPogButton = new MaterialSkin.Controls.MaterialButton();
            this.BrigadePogButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // WorkerPogButton
            // 
            this.WorkerPogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WorkerPogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.WorkerPogButton.Depth = 0;
            this.WorkerPogButton.HighEmphasis = true;
            this.WorkerPogButton.Icon = null;
            this.WorkerPogButton.Location = new System.Drawing.Point(133, 283);
            this.WorkerPogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.WorkerPogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkerPogButton.Name = "WorkerPogButton";
            this.WorkerPogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.WorkerPogButton.Size = new System.Drawing.Size(121, 36);
            this.WorkerPogButton.TabIndex = 0;
            this.WorkerPogButton.Text = "Сотрудники";
            this.WorkerPogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.WorkerPogButton.UseAccentColor = false;
            this.WorkerPogButton.UseVisualStyleBackColor = true;
            this.WorkerPogButton.Click += new System.EventHandler(this.WorkerPogButton_Click);
            // 
            // CallPogButton
            // 
            this.CallPogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CallPogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CallPogButton.Depth = 0;
            this.CallPogButton.HighEmphasis = true;
            this.CallPogButton.Icon = null;
            this.CallPogButton.Location = new System.Drawing.Point(149, 108);
            this.CallPogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CallPogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CallPogButton.Name = "CallPogButton";
            this.CallPogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CallPogButton.Size = new System.Drawing.Size(84, 36);
            this.CallPogButton.TabIndex = 1;
            this.CallPogButton.Text = "Вызовы";
            this.CallPogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CallPogButton.UseAccentColor = false;
            this.CallPogButton.UseVisualStyleBackColor = true;
            this.CallPogButton.Click += new System.EventHandler(this.CallPogButton_Click);
            // 
            // BrigadePogButton
            // 
            this.BrigadePogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrigadePogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BrigadePogButton.Depth = 0;
            this.BrigadePogButton.HighEmphasis = true;
            this.BrigadePogButton.Icon = null;
            this.BrigadePogButton.Location = new System.Drawing.Point(146, 192);
            this.BrigadePogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BrigadePogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrigadePogButton.Name = "BrigadePogButton";
            this.BrigadePogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BrigadePogButton.Size = new System.Drawing.Size(92, 36);
            this.BrigadePogButton.TabIndex = 2;
            this.BrigadePogButton.Text = "Бригады";
            this.BrigadePogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BrigadePogButton.UseAccentColor = false;
            this.BrigadePogButton.UseVisualStyleBackColor = true;
            this.BrigadePogButton.Click += new System.EventHandler(this.BrigadePogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 405);
            this.Controls.Add(this.BrigadePogButton);
            this.Controls.Add(this.CallPogButton);
            this.Controls.Add(this.WorkerPogButton);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton WorkerPogButton;
        private MaterialSkin.Controls.MaterialButton CallPogButton;
        private MaterialSkin.Controls.MaterialButton BrigadePogButton;
    }
}