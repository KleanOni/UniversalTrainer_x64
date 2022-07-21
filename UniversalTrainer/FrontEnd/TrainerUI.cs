using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using UniversalTrainer.BackEnd.Game;

namespace UniversalTrainer
{
    public partial class TrainerUI : Form
    {
        Mem M = new Mem();
        bool GPOpen = true; // bool Game Process Open which = true
        public TrainerUI()
        {
            InitializeComponent();
            Trainer_BGWorker.RunWorkerAsync();
        }
        #region BackgroundWorker
        private void Trainer_BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            GPOpen = M.OpenProcess("OUTRIDERS-Win64-Shipping.exe"); // Add Game .exe name here! example EldenRing.exe
            if (!GPOpen)
            {
                // If game not found, loop #ms until game is found!
                GameStatus_Label.Text = "Status: Waiting for game!";
                Thread.Sleep(500);
            }
            Thread.Sleep(100); //If game found loop at 500
            Trainer_BGWorker.ReportProgress(0);
        }

        private void Trainer_BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (GPOpen)
            {
                GameStatus_Label.Text = "Status: Hooked to OUTRIDERS-Win64-Shipping.exe!";

                // READ PROCESS MEMORY HERE EX BELOW
                int playerHP = M.ReadInt(Offsets.Health);
                HealthV_Label.Text = "Health: " +  playerHP.ToString();
            }
        }

        private void Trainer_BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Trainer_BGWorker.RunWorkerAsync();
        }
        #endregion

        private void GodMode_CB_CheckedChanged(object sender, EventArgs e)
        {
            // Most games have Health & Health Max next to each other in memory, we will use Health Max as a max value to write to our current Health.

            int playerHPM = M.ReadInt(Offsets.HealthMax);

            if (GodMode_CB.Checked)
            {
                M.WriteMemory(Offsets.Health, "int", playerHPM.ToString());
                GodMode_CB.Text = "God Mode: Enabled";
            }
            else // if (!GodMode_CB.Checked) or if (GodMode_CB.Checked = false)
            {
                GodMode_CB.Text = "God Mode: Disabled";
            }
        }
    }
}
