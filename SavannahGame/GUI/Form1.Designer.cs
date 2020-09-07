using SetupFile;

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
            this.btn_showAnimals = new System.Windows.Forms.Button();
            this.Lbox_animals = new System.Windows.Forms.ListBox();
            this.bnt_StartGame = new System.Windows.Forms.Button();
            this.PicBox_savannah = new System.Windows.Forms.PictureBox();
            this.listBox_Incidents = new System.Windows.Forms.ListBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_newRabbit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_savannah)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newLion
            // 
            this.btn_newLion.Location = new System.Drawing.Point(36, 25);
            this.btn_newLion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newLion.Name = "btn_newLion";
            this.btn_newLion.Size = new System.Drawing.Size(75, 37);
            this.btn_newLion.TabIndex = 0;
            this.btn_newLion.Text = "New Lion";
            this.btn_newLion.UseVisualStyleBackColor = true;
            this.btn_newLion.Click += new System.EventHandler(this.btn_newLion_Click);
            // 
            // btn_showAnimals
            // 
            this.btn_showAnimals.Location = new System.Drawing.Point(36, 125);
            this.btn_showAnimals.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showAnimals.Name = "btn_showAnimals";
            this.btn_showAnimals.Size = new System.Drawing.Size(75, 37);
            this.btn_showAnimals.TabIndex = 1;
            this.btn_showAnimals.Text = "Show All";
            this.btn_showAnimals.UseVisualStyleBackColor = true;
            this.btn_showAnimals.Click += new System.EventHandler(this.btn_showAnimals_Click);
            // 
            // Lbox_animals
            // 
            this.Lbox_animals.FormattingEnabled = true;
            this.Lbox_animals.Location = new System.Drawing.Point(139, 25);
            this.Lbox_animals.Margin = new System.Windows.Forms.Padding(2);
            this.Lbox_animals.Name = "Lbox_animals";
            this.Lbox_animals.Size = new System.Drawing.Size(297, 238);
            this.Lbox_animals.TabIndex = 2;
            // 
            // bnt_StartGame
            // 
            this.bnt_StartGame.Location = new System.Drawing.Point(36, 175);
            this.bnt_StartGame.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_StartGame.Name = "bnt_StartGame";
            this.bnt_StartGame.Size = new System.Drawing.Size(75, 37);
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
            this.PicBox_savannah.Size = new System.Drawing.Size(Settings.areaSize, Settings.areaSize);
            this.PicBox_savannah.TabIndex = 5;
            this.PicBox_savannah.TabStop = false;
            this.PicBox_savannah.Paint += new System.Windows.Forms.PaintEventHandler(this.PicBox_savannah_Paint);
            // 
            // listBox_Incidents
            // 
            this.listBox_Incidents.FormattingEnabled = true;
            this.listBox_Incidents.Location = new System.Drawing.Point(36, 314);
            this.listBox_Incidents.Name = "listBox_Incidents";
            this.listBox_Incidents.Size = new System.Drawing.Size(400, 407);
            this.listBox_Incidents.TabIndex = 6;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(36, 225);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 37);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "Pause";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_newRabbit
            // 
            this.btn_newRabbit.Location = new System.Drawing.Point(36, 75);
            this.btn_newRabbit.Name = "btn_newRabbit";
            this.btn_newRabbit.Size = new System.Drawing.Size(75, 37);
            this.btn_newRabbit.TabIndex = 8;
            this.btn_newRabbit.Text = "New Rabbit";
            this.btn_newRabbit.UseVisualStyleBackColor = true;
            this.btn_newRabbit.Click += new System.EventHandler(this.btn_newRabbit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 753);
            this.Controls.Add(this.btn_newRabbit);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.listBox_Incidents);
            this.Controls.Add(this.PicBox_savannah);
            this.Controls.Add(this.bnt_StartGame);
            this.Controls.Add(this.Lbox_animals);
            this.Controls.Add(this.btn_showAnimals);
            this.Controls.Add(this.btn_newLion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_savannah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newLion;
        private System.Windows.Forms.Button btn_showAnimals;
        private System.Windows.Forms.ListBox Lbox_animals;
        private System.Windows.Forms.Button bnt_StartGame;
        private System.Windows.Forms.PictureBox PicBox_savannah;
        private System.Windows.Forms.ListBox listBox_Incidents;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_newRabbit;
    }
}

