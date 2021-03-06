﻿

using Common.SetupFile;

namespace GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_newLion = new System.Windows.Forms.Button();
            this.btn_resetGame = new System.Windows.Forms.Button();
            this.Lbox_animals = new System.Windows.Forms.ListBox();
            this.bnt_StartGame = new System.Windows.Forms.Button();
            this.PicBox_savannah = new System.Windows.Forms.PictureBox();
            this.listBox_Incidents = new System.Windows.Forms.ListBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_newRabbit = new System.Windows.Forms.Button();
            this.txt_speedMs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SaveGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.track_GrassGrow = new System.Windows.Forms.TrackBar();
            this.lbl_GameSpeed = new System.Windows.Forms.Label();
            this.lbl_GrassGrow = new System.Windows.Forms.Label();
            this.track_GameSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_savannah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_GrassGrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_GameSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newLion
            // 
            this.btn_newLion.Location = new System.Drawing.Point(36, 25);
            this.btn_newLion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newLion.Name = "btn_newLion";
            this.btn_newLion.Size = new System.Drawing.Size(75, 38);
            this.btn_newLion.TabIndex = 0;
            this.btn_newLion.Text = "New Lion";
            this.btn_newLion.UseVisualStyleBackColor = true;
            this.btn_newLion.Click += new System.EventHandler(this.btn_newLion_Click);
            // 
            // btn_resetGame
            // 
            this.btn_resetGame.Location = new System.Drawing.Point(36, 213);
            this.btn_resetGame.Margin = new System.Windows.Forms.Padding(2);
            this.btn_resetGame.Name = "btn_resetGame";
            this.btn_resetGame.Size = new System.Drawing.Size(75, 38);
            this.btn_resetGame.TabIndex = 1;
            this.btn_resetGame.Text = "Reset";
            this.btn_resetGame.UseVisualStyleBackColor = true;
            this.btn_resetGame.Click += new System.EventHandler(this.btn_resetGame_Click);
            // 
            // Lbox_animals
            // 
            this.Lbox_animals.FormattingEnabled = true;
            this.Lbox_animals.Location = new System.Drawing.Point(139, 25);
            this.Lbox_animals.Margin = new System.Windows.Forms.Padding(2);
            this.Lbox_animals.Name = "Lbox_animals";
            this.Lbox_animals.Size = new System.Drawing.Size(297, 277);
            this.Lbox_animals.TabIndex = 2;
            // 
            // bnt_StartGame
            // 
            this.bnt_StartGame.Location = new System.Drawing.Point(36, 119);
            this.bnt_StartGame.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_StartGame.Name = "bnt_StartGame";
            this.bnt_StartGame.Size = new System.Drawing.Size(75, 38);
            this.bnt_StartGame.TabIndex = 3;
            this.bnt_StartGame.Text = "Start";
            this.bnt_StartGame.UseVisualStyleBackColor = true;
            this.bnt_StartGame.Click += new System.EventHandler(this.bnt_StartGame_Click);
            // 
            // PicBox_savannah
            // 
            this.PicBox_savannah.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PicBox_savannah.Location = new System.Drawing.Point(468, 25);
            this.PicBox_savannah.Name = "PicBox_savannah";
            this.PicBox_savannah.Size = new System.Drawing.Size(400, 400);
            this.PicBox_savannah.TabIndex = 5;
            this.PicBox_savannah.TabStop = false;
            this.PicBox_savannah.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBox_savannah_Paint);
            // 
            // listBox_Incidents
            // 
            this.listBox_Incidents.FormattingEnabled = true;
            this.listBox_Incidents.Location = new System.Drawing.Point(36, 353);
            this.listBox_Incidents.Name = "listBox_Incidents";
            this.listBox_Incidents.Size = new System.Drawing.Size(400, 368);
            this.listBox_Incidents.TabIndex = 6;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(36, 166);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 38);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Pause";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_newRabbit
            // 
            this.btn_newRabbit.Location = new System.Drawing.Point(36, 72);
            this.btn_newRabbit.Name = "btn_newRabbit";
            this.btn_newRabbit.Size = new System.Drawing.Size(75, 38);
            this.btn_newRabbit.TabIndex = 8;
            this.btn_newRabbit.Text = "New Rabbit";
            this.btn_newRabbit.UseVisualStyleBackColor = true;
            this.btn_newRabbit.Click += new System.EventHandler(this.btn_newRabbit_Click);
            // 
            // txt_speedMs
            // 
            this.txt_speedMs.Location = new System.Drawing.Point(468, 474);
            this.txt_speedMs.Name = "txt_speedMs";
            this.txt_speedMs.Size = new System.Drawing.Size(100, 20);
            this.txt_speedMs.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Iteration speed in ms";
            // 
            // btn_SaveGame
            // 
            this.btn_SaveGame.Location = new System.Drawing.Point(36, 260);
            this.btn_SaveGame.Name = "btn_SaveGame";
            this.btn_SaveGame.Size = new System.Drawing.Size(75, 38);
            this.btn_SaveGame.TabIndex = 11;
            this.btn_SaveGame.Text = "Gem historik";
            this.btn_SaveGame.UseVisualStyleBackColor = true;
            this.btn_SaveGame.Click += new System.EventHandler(this.btn_SaveGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Historik";
            // 
            // track_GrassGrow
            // 
            this.track_GrassGrow.LargeChange = 1;
            this.track_GrassGrow.Location = new System.Drawing.Point(471, 629);
            this.track_GrassGrow.Minimum = 1;
            this.track_GrassGrow.Name = "track_GrassGrow";
            this.track_GrassGrow.Size = new System.Drawing.Size(163, 45);
            this.track_GrassGrow.TabIndex = 14;
            this.track_GrassGrow.Value = 1;
            this.track_GrassGrow.Scroll += new System.EventHandler(this.track_GrassGrow_Scroll);
            // 
            // lbl_GameSpeed
            // 
            this.lbl_GameSpeed.AutoSize = true;
            this.lbl_GameSpeed.Location = new System.Drawing.Point(471, 518);
            this.lbl_GameSpeed.Name = "lbl_GameSpeed";
            this.lbl_GameSpeed.Size = new System.Drawing.Size(69, 13);
            this.lbl_GameSpeed.TabIndex = 15;
            this.lbl_GameSpeed.Text = "Game Speed";
            // 
            // lbl_GrassGrow
            // 
            this.lbl_GrassGrow.AutoSize = true;
            this.lbl_GrassGrow.Location = new System.Drawing.Point(474, 610);
            this.lbl_GrassGrow.Name = "lbl_GrassGrow";
            this.lbl_GrassGrow.Size = new System.Drawing.Size(96, 13);
            this.lbl_GrassGrow.TabIndex = 16;
            this.lbl_GrassGrow.Text = "Grass Grow Speed";
            // 
            // track_GameSpeed
            // 
            this.track_GameSpeed.LargeChange = 2;
            this.track_GameSpeed.Location = new System.Drawing.Point(471, 537);
            this.track_GameSpeed.Maximum = 20;
            this.track_GameSpeed.Minimum = 1;
            this.track_GameSpeed.Name = "track_GameSpeed";
            this.track_GameSpeed.Size = new System.Drawing.Size(163, 45);
            this.track_GameSpeed.TabIndex = 13;
            this.track_GameSpeed.TickFrequency = 2;
            this.track_GameSpeed.Value = Settings.Instance().gameSpeed;
            this.track_GameSpeed.Scroll += new System.EventHandler(this.track_GameSpeed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 753);
            this.Controls.Add(this.lbl_GrassGrow);
            this.Controls.Add(this.lbl_GameSpeed);
            this.Controls.Add(this.track_GrassGrow);
            this.Controls.Add(this.track_GameSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SaveGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_speedMs);
            this.Controls.Add(this.btn_newRabbit);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.listBox_Incidents);
            this.Controls.Add(this.PicBox_savannah);
            this.Controls.Add(this.bnt_StartGame);
            this.Controls.Add(this.Lbox_animals);
            this.Controls.Add(this.btn_resetGame);
            this.Controls.Add(this.btn_newLion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_savannah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_GrassGrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_GameSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newLion;
        private System.Windows.Forms.Button btn_resetGame;
        private System.Windows.Forms.ListBox Lbox_animals;
        private System.Windows.Forms.Button bnt_StartGame;
        private System.Windows.Forms.PictureBox PicBox_savannah;
        private System.Windows.Forms.ListBox listBox_Incidents;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_newRabbit;
        private System.Windows.Forms.TextBox txt_speedMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar track_GameSpeed;
        private System.Windows.Forms.TrackBar track_GrassGrow;
        private System.Windows.Forms.Label lbl_GameSpeed;
        private System.Windows.Forms.Label lbl_GrassGrow;
    }
}

