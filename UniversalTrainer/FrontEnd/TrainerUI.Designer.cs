namespace UniversalTrainer
{
    partial class TrainerUI
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
            this.Trainer_BGWorker = new System.ComponentModel.BackgroundWorker();
            this.GameStatus_Label = new System.Windows.Forms.Label();
            this.HealthV_Label = new System.Windows.Forms.Label();
            this.GodMode_CB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Trainer_BGWorker
            // 
            this.Trainer_BGWorker.WorkerReportsProgress = true;
            this.Trainer_BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Trainer_BGWorker_DoWork);
            this.Trainer_BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Trainer_BGWorker_ProgressChanged);
            this.Trainer_BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Trainer_BGWorker_RunWorkerCompleted);
            // 
            // GameStatus_Label
            // 
            this.GameStatus_Label.AutoSize = true;
            this.GameStatus_Label.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStatus_Label.Location = new System.Drawing.Point(8, 7);
            this.GameStatus_Label.Name = "GameStatus_Label";
            this.GameStatus_Label.Size = new System.Drawing.Size(88, 17);
            this.GameStatus_Label.TabIndex = 0;
            this.GameStatus_Label.Text = "Game Status:";
            // 
            // HealthV_Label
            // 
            this.HealthV_Label.AutoSize = true;
            this.HealthV_Label.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthV_Label.Location = new System.Drawing.Point(8, 33);
            this.HealthV_Label.Name = "HealthV_Label";
            this.HealthV_Label.Size = new System.Drawing.Size(51, 17);
            this.HealthV_Label.TabIndex = 1;
            this.HealthV_Label.Text = "Health:";
            // 
            // GodMode_CB
            // 
            this.GodMode_CB.AutoSize = true;
            this.GodMode_CB.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GodMode_CB.Location = new System.Drawing.Point(11, 60);
            this.GodMode_CB.Name = "GodMode_CB";
            this.GodMode_CB.Size = new System.Drawing.Size(149, 21);
            this.GodMode_CB.TabIndex = 2;
            this.GodMode_CB.Text = "God Mode: Disabled";
            this.GodMode_CB.UseVisualStyleBackColor = true;
            this.GodMode_CB.CheckedChanged += new System.EventHandler(this.GodMode_CB_CheckedChanged);
            // 
            // TrainerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 93);
            this.Controls.Add(this.GodMode_CB);
            this.Controls.Add(this.HealthV_Label);
            this.Controls.Add(this.GameStatus_Label);
            this.Name = "TrainerUI";
            this.Text = "Universal External Trainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker Trainer_BGWorker;
        private System.Windows.Forms.Label GameStatus_Label;
        private System.Windows.Forms.Label HealthV_Label;
        private System.Windows.Forms.CheckBox GodMode_CB;
    }
}

