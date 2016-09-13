using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4Daniel
{
    
    public partial class Form1 : Form
    {
        public  List<Robot> listOfRobots= new List<Robot>();
        public Form1()
        {
            InitializeComponent();
            Robot robot1 = new FlyingRobot("Gundam", Job.War);
            robot1.distance = RandomDistance();
            listOfRobots.Add(robot1);

            Robot robot2 = new SwimmerRobot("Tengen", Job.War);
            robot1.distance = RandomDistance();
            listOfRobots.Add(robot2);

            Robot robot3 = new TerrestrialRobot("Yamato", Job.Work);
            robot3.distance = RandomDistance();
            listOfRobots.Add(robot3);

            Robot robot4 = new UndergroundRobot("Candance", Job.Work);
            robot4.distance = RandomDistance();
            listOfRobots.Add(robot4);

        }

        private void valea_button_Click(object sender, EventArgs e)
        {
            

            foreach (Robot robot in listOfRobots)
            {
                textBox1.Text += robot.Move();
                textBox1.Text += Environment.NewLine;
            }
        }

        public int RandomWeapon()
        {
            Random randomWeaponId = new Random();
            int idWeapon = randomWeaponId.Next(0, 3);
            return idWeapon;
        }

       

        public  int RandomDistance()
        {
            Random randomDistanceNumber = new Random();
            int distance = randomDistanceNumber.Next(20, 50);
            return distance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                

        }

        private void getReady_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Robot robot in listOfRobots)
            {
                if(robot.job == Job.Work)
                {
                    robot.weapon = ((WorkWeapon)RandomWeapon()).ToString();
                } else
                {
                    robot.weapon = ((WarWeapon)RandomWeapon()).ToString();
                }

                textBox1.Text += robot.GetReady();
                textBox1.Text += Environment.NewLine;
            }
        }

        private void work_button_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach(Robot robot in listOfRobots)
            {
                textBox1.Text += robot.Work();
                textBox1.Text += Environment.NewLine;
            }
        }
    }

   
}
