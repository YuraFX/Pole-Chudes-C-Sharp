//  Foobar is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Foobar is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

namespace Pole_Chudes_Beta_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pbGameLogo1 = new System.Windows.Forms.PictureBox();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameLogo1
            // 
            this.pbGameLogo1.Image = global::Pole_Chudes_Beta_1.Properties.Resources.lg;
            this.pbGameLogo1.Location = new System.Drawing.Point(12, 12);
            this.pbGameLogo1.Name = "pbGameLogo1";
            this.pbGameLogo1.Size = new System.Drawing.Size(258, 80);
            this.pbGameLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameLogo1.TabIndex = 0;
            this.pbGameLogo1.TabStop = false;
            // 
            // lblOne
            // 
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOne.Image = global::Pole_Chudes_Beta_1.Properties.Resources.lgpb1;
            this.lblOne.Location = new System.Drawing.Point(12, 95);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(258, 50);
            this.lblOne.TabIndex = 1;
            this.lblOne.Text = "Компьютерная игра \"Поле чудес\" версии Beta 1.";
            this.lblOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTwo
            // 
            this.lblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTwo.Image = global::Pole_Chudes_Beta_1.Properties.Resources.lgpb1;
            this.lblTwo.Location = new System.Drawing.Point(12, 136);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(260, 75);
            this.lblTwo.TabIndex = 3;
            this.lblTwo.Text = "Авторы оригинала: Самара-Диалог. Автор ремейка: Конышев Юрий aka Yura_FX. Игра на" +
    "писана с нуля на языке C#.";
            this.lblTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Pole_Chudes_Beta_1.Properties.Resources.lgpb;
            this.ClientSize = new System.Drawing.Size(282, 219);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.pbGameLogo1);
            this.Controls.Add(this.lblOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameLogo1;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
    }
}