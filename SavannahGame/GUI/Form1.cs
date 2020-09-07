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

namespace GUI
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            savannah = new Savannah();
            InitializeComponent();
        }
        Savannah savannah;

        private void btn_newLion_Click(object sender, EventArgs e)
        {
            savannah.NewLion();
        }

        private void btn_newRabbit_Click(object sender, EventArgs e)
        {
            savannah.NewRabbit();
        }

        private void btn_showAnimals_Click(object sender, EventArgs e)
        {
            Lbox_animals.DataSource = null;
            Lbox_animals.DataSource = savannah.animalList;
        }

        private void bnt_StartGame_Click(object sender, EventArgs e)
        {

            gameTimer.Interval = 1000 / Settings.speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //moves animals
            savannah.MoveAnimals();

            //check for animals in same area and conflicts between animals
            savannah.AnimalsSameLocation();

            //check if area has grass. If not, it has a change for growing (33%)
            savannah.GrassGrows();

            //updates list of animals alive
            Lbox_animals.DataSource = null;
            Lbox_animals.DataSource = savannah.animalList;

            //updates list of incidents
            listBox_Incidents.DataSource = null;
            listBox_Incidents.DataSource = savannah.IncidentsList;


            //update graphic
            PicBox_savannah.Invalidate();
        }

        private void PicBox_savannah_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            
            for (int i = 0; i < savannah.areaArray.GetLength(0); i++)
            {
                for (int j = 0; j < savannah.areaArray.GetLength(1); j++)
                {
                    if (savannah.areaArray[i, j].ContainsGrass() == true)
                    {
                        canvas.FillEllipse(Brushes.Green, new Rectangle(i * 20, j * 20, 20, 20));
                    }

                }

            }
            foreach (var item in savannah.animalList)
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
