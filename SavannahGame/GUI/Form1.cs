using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Common;
//using Common.SetupFile;
using System.Diagnostics;
using System.Threading;


namespace GUI
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch = new Stopwatch();
        private long time;
       
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btn_newLion_Click(object sender, EventArgs e)
        {
            Game_Controller.Instance().NewAnimal(animalType.lion);
            UpdateLBOX_Animals();
        }

        private void btn_newRabbit_Click(object sender, EventArgs e)
        {
            Game_Controller.Instance().NewAnimal(animalType.rabbit);
            UpdateLBOX_Animals();
        }

        private void btn_resetGame_Click(object sender, EventArgs e)
        {
            Game_Controller.Instance().ResetGame();
        }

        private void bnt_StartGame_Click(object sender, EventArgs e)
        {

            gameTimer.Interval = 1000 / Game_Controller.Instance().GetGameSpeed();
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            stopWatch.Restart();

            Game_Controller.Instance().AnimalIteration();


            //updates list of animals alive
            UpdateLBOX_Animals();


            //updates list of incidents
            UpdateLBOX_Incidents();

           // Task.WaitAll(task1);

            //update graphic

            PicBox_savannah.Invalidate();
            
            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;

            txt_speedMs.Text = time.ToString();
        }

        private void UpdateLBOX_Animals()
        {
             Lbox_animals.DataSource = null;
             Lbox_animals.DataSource = Game_Controller.Instance().GetAnimalList();
        }

        private void UpdateLBOX_Incidents()
        {
            listBox_Incidents.DataSource = null;
            listBox_Incidents.DataSource = Game_Controller.Instance().GetIncidentList();
        }

        private void PicBox_savannah_Paint(object sender, PaintEventArgs e) //paints PicBox_savannah. Graphics only related to forms. 
        {
            Graphics canvas = e.Graphics;
            
            
            for (int i = 0; i < Game_Controller.Instance().GetAreaArray().GetLength(0); i++)
            {
                for (int j = 0; j < Game_Controller.Instance().GetAreaArray().GetLength(1); j++)
                {
                    if (Game_Controller.Instance().GetAreaArray()[i, j].ContainsGrass() == true)
                    {
                        canvas.FillEllipse(Brushes.Green, new Rectangle(i * 20, j * 20, 20, 20));
                    }
                }

            }
            foreach (var item in Game_Controller.Instance().GetAnimalList())
            {
                if (item.type == animalType.lion)
                {
                    if (item.gender == gender.male)
                        canvas.FillEllipse(Brushes.Orange, new Rectangle(item.locationX * 20, item.locationY * 20, 20, 20));
                    else
                        canvas.FillEllipse(Brushes.Yellow, new Rectangle(item.locationX * 20, item.locationY * 20, 20, 20));
                }
                else
                    canvas.FillEllipse(Brushes.White, new Rectangle(item.locationX * 20, item.locationY * 20, 15, 15));
            }
            
        }

        private string GetFilePath_DialogBox()
        {
            SaveFileDialog SavePath = new SaveFileDialog();
            SavePath.Title = "Savannah Game - Gem spillets historik";
            SavePath.FileName = "History " + DateTime.Now.ToShortDateString();
            SavePath.OverwritePrompt = true;
            SavePath.InitialDirectory = "c:\\";
            SavePath.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (SavePath.ShowDialog() == DialogResult.OK)
            {
                return SavePath.FileName;
            }
            else
                throw new Exception();

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void btn_SaveGame_Click(object sender, EventArgs e)
        {
            try
            {
                gameTimer.Stop();
                Game_Controller.Instance().SaveGameHistory(GetFilePath_DialogBox());
            }
            catch (Exception)
            {
                MessageBox.Show("Historie IKKE gemt");
            }
            
        }

        private void track_GameSpeed_Scroll(object sender, EventArgs e)
        {
            Game_Controller.Instance().SetGameSpeed(track_GameSpeed.Value);
            gameTimer.Interval = 1000 / Game_Controller.Instance().GetGameSpeed();
        }

        private void track_GrassGrow_Scroll(object sender, EventArgs e)
        {
            Game_Controller.Instance().SetGrassGrowSpeed(track_GrassGrow.Value);
        }
    }
}
