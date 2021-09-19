namespace Wc3UnrealAntiCheat
{
    partial class WarcraftUnrealCheatDetector
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.MapOpenButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.CheatPicture = new System.Windows.Forms.PictureBox();
            this.DeepScanSelected = new System.Windows.Forms.PictureBox();
            this.CheatLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.MapOpenButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheatPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeepScanSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // MapOpenButton
            // 
            this.MapOpenButton.BackColor = System.Drawing.Color.Transparent;
            this.MapOpenButton.Image = global::Wc3UnrealAntiCheat.Properties.Resources.OpenMapDef;
            this.MapOpenButton.Location = new System.Drawing.Point(140, 42);
            this.MapOpenButton.Name = "MapOpenButton";
            this.MapOpenButton.Size = new System.Drawing.Size(147, 32);
            this.MapOpenButton.TabIndex = 0;
            this.MapOpenButton.TabStop = false;
            this.MapOpenButton.Click += new System.EventHandler(this.MapOpenButton_Click);
            this.MapOpenButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapOpenButton_MouseDown);
            this.MapOpenButton.MouseEnter += new System.EventHandler(this.MapOpenButton_MouseEnter);
            this.MapOpenButton.MouseLeave += new System.EventHandler(this.MapOpenButton_MouseLeave);
            this.MapOpenButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapOpenButton_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = global::Wc3UnrealAntiCheat.Properties.Resources.CloseDef;
            this.CloseButton.Location = new System.Drawing.Point(243, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(44, 33);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // CheatPicture
            // 
            this.CheatPicture.BackColor = System.Drawing.Color.Transparent;
            this.CheatPicture.Location = new System.Drawing.Point(18, 80);
            this.CheatPicture.Name = "CheatPicture";
            this.CheatPicture.Size = new System.Drawing.Size(270, 26);
            this.CheatPicture.TabIndex = 2;
            this.CheatPicture.TabStop = false;
            // 
            // DeepScanSelected
            // 
            this.DeepScanSelected.BackColor = System.Drawing.Color.Transparent;
            this.DeepScanSelected.Image = global::Wc3UnrealAntiCheat.Properties.Resources.DeepChecked;
            this.DeepScanSelected.Location = new System.Drawing.Point(18, 42);
            this.DeepScanSelected.Name = "DeepScanSelected";
            this.DeepScanSelected.Size = new System.Drawing.Size(120, 32);
            this.DeepScanSelected.TabIndex = 3;
            this.DeepScanSelected.TabStop = false;
            this.DeepScanSelected.Click += new System.EventHandler(this.DeepScanSelected_Click);
            this.DeepScanSelected.MouseEnter += new System.EventHandler(this.DeepScanSelected_MouseEnter);
            this.DeepScanSelected.MouseLeave += new System.EventHandler(this.DeepScanSelected_MouseLeave);
            // 
            // CheatLabel
            // 
            this.CheatLabel.AutoSize = true;
            this.CheatLabel.BackColor = System.Drawing.Color.Transparent;
            this.CheatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheatLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.CheatLabel.Location = new System.Drawing.Point(56, 78);
            this.CheatLabel.Name = "CheatLabel";
            this.CheatLabel.Size = new System.Drawing.Size(0, 25);
            this.CheatLabel.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Cyan;
            this.progressBar1.Location = new System.Drawing.Point(19, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(268, 10);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // WarcraftUnrealCheatDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Wc3UnrealAntiCheat.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(300, 125);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CheatLabel);
            this.Controls.Add(this.DeepScanSelected);
            this.Controls.Add(this.CheatPicture);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MapOpenButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WarcraftUnrealCheatDetector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warcraft Cheat Pack\'s Detector!";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
            ((System.ComponentModel.ISupportInitialize)(this.MapOpenButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheatPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeepScanSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MapOpenButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox CheatPicture;
        private System.Windows.Forms.PictureBox DeepScanSelected;
        private System.Windows.Forms.Label CheatLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

