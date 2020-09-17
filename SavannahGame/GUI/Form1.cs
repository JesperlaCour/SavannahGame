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
using Entity;
using SetupFile;
using System.Diagnostics;

namespace GUI
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        long time;
       
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btn_newLion_Click(object sender, EventArgs e)
        {
            Controller.Instance().NewLion();
            UpdateLBOX_Animals();
        }

        private void btn_newRabbit_Click(object sender, EventArgs e)
        {
            Controller.Instance().NewRabbit();
            UpdateLBOX_Animals();
        }

        private void btn_resetGame_Click(object sender, EventArgs e)
        {
            Controller.Instance().ResetGame();
        }

        private void bnt_StartGame_Click(object sender, EventArgs e)
        {

            gameTimer.Interval = 1000 / Settings.speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            stopWatch.Restart();
            //moves animals
            Controller.Instance().MoveAnimals();

            //check for animals in same area and conflicts between animals
            Controller.Instance().AnimalsSameLocation();

            //check if area has grass. If not, it has a change for growing (33%)
            Controller.Instance().GrassGrows();

            //updates list of animals alive
            UpdateLBOX_Animals();

            //updates list of incidents
            listBox_Incidents.DataSource = null;
            listBox_Incidents.DataSource = Controller.Instance().GetIncidentList();


            //update graphic
            PicBox_savannah.Invalidate();

            stopWatch.Stop();
            time = stopWatch.ElapsedMilliseconds;

            txt_speedMs.Text = time.ToString();
        }

        public void UpdateLBOX_Animals()
        {
            Lbox_animals.DataSource = null;
            Lbox_animals.DataSource = Controller.Instance().GetAnimalList();
        }

        private void PicBox_savannah_Paint(object sender, PaintEventArgs e) //paints PicBox_savannah. Graphics only related to forms. 
        {
            Graphics canvas = e.Graphics;
            
            
            for (int i = 0; i < Controller.Instance().GetAreaArray().GetLength(0); i++)
            {
                for (int j = 0; j < Controller.Instance().GetAreaArray().GetLength(1); j++)
                {
                    if (Controller.Instance().GetAreaArray()[i, j].ContainsGrass() == true)
                    {
                        canvas.FillEllipse(Brushes.Green, new Rectangle(i * 20, j * 20, 20, 20));
                    }
                }

            }
            foreach (var item in Controller.Instance().GetAnimalList())
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

        private void btn_stop_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }



        
    }
}
