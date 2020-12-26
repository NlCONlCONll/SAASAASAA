using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Battle_System
{
    public partial class battlephase : Form
    {
            
        
        public Enemy enemyexample;
        public Enemy enemyexample2;
        public Enemy enemyexample3;
        public int atkchose;
        public Random random = new Random();
        public static Yuushadono example;
        public int minigame1count = 0;
        public int minigame2count = 0;
        public int minigame3count = 0;
        public int count3 = 0;
        public int count2 = 0;
        public battlephase()
            
        {
            example = new Yuushadono();
            enemyexample = new Enemy();
            enemyexample2 = new Enemy();
            enemyexample3 = new Enemy();
            example.luck = 25;
            example.attack = 12;
            example.defend = 2;
            example.lvl = 1;
            example.health = 100 + ((example.lvl - 1) * 8);
            example.speed = 10;
            example.number = 0;
            enemyexample.enemyhealth = 200;
            enemyexample.enemydef = 1;
            enemyexample.enemylvl = 1;
            enemyexample.enemydamage = 8;
            enemyexample2.enemyhealth = 200;
            enemyexample2.enemydef = 1;
            enemyexample2.enemylvl = 1;
            enemyexample2.enemydamage = 8;
            enemyexample3.enemyhealth = 200;
            enemyexample3.enemydef = 1;
            enemyexample3.enemylvl = 1;
            enemyexample3.enemydamage = 8;
            InitializeComponent();
        }
        
        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            minigametimer1.Interval = 1000;
            minigametimer1.Tick += minigame1;
            minigame3button.Hide();
            minigametimer2.Interval = 1000;
            minigametimer2.Tick += minigame2;
            minigametimer3.Interval = 5000;
            minigametimer3.Tick += minigame3;
            label2.Hide();
            textBox1.Hide();
            herotimer1.Tick += wait1;
            herotimer2.Tick += wait2;
            herotimer3.Tick += wait3;
            herotimer4.Tick += wait4;
            herotimer1.Interval = 1000;
            herotimer2.Interval = 1000;
            herotimer3.Interval = 1000;
            herotimer4.Interval = 1000;
            herotimer1.Start();
            herotimer2.Start();
            herotimer3.Start();
            herotimer4.Start();
            globaltimer.Interval = 1000;
            globaltimer.Start();
            globaltimer.Tick += enemyaction;
            speedbar1.Value = 0;
            speedbar1.Minimum = 0;
            speedbar1.Maximum = 100;
            HealthBar1.Maximum = Convert.ToInt32(example.health);
            Healthbar2.Maximum = Convert.ToInt32(example.health);
            Healthbar3.Maximum = Convert.ToInt32(example.health);
            Healthbar4.Maximum = Convert.ToInt32(example.health);
            HealthBar1.Minimum = 0;
            Healthbar2.Minimum = 0;
            Healthbar3.Minimum = 0;
            Healthbar4.Minimum = 0;
            HealthBar1.Value = Convert.ToInt32(example.health);
            Healthbar2.Value = Convert.ToInt32(example.health);
            Healthbar3.Value = Convert.ToInt32(example.health);
            Healthbar4.Value = Convert.ToInt32(example.health);
            enemyhealth2.Maximum = Convert.ToInt32(enemyexample.enemyhealth);
            enemyhealth2.Value = Convert.ToInt32(enemyexample.enemyhealth);
            enemyhealth2.Minimum = 0;
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;

        }
        private void enemyaction (object enemy1, EventArgs enemy1event)
        {
            if (enemyhealth1.Value > 0)
            {
                if (enemyexample.enemyspeed < 100) enemyexample.enemyspeed += 7;
                else
                {
                    enemyexample.enemyspeed = 0;
                    enemyexample.enemychoice = 0;

                    example.health -= enemyexample.enemydamage;
                    HealthBar1.Value = example.health;
                }
            }
            if (enemyhealth2.Value > 0)
            {
                if (enemyexample2.enemyspeed < 100) enemyexample2.enemyspeed += 4;
                else
                {
                    enemyexample2.enemyspeed = 0;
                    enemyexample2.enemychoice = 0;

                    example.health -= enemyexample.enemydamage;
                    HealthBar1.Value = example.health;
                }
            }
            if (enemyhealth3.Value > 0)
            {
                if (enemyexample3.enemyspeed < 100) enemyexample3.enemyspeed += 10;
                else
                {
                    enemyexample3.enemyspeed = 0;
                    enemyexample3.enemychoice = 0;

                    example.health -= enemyexample3.enemydamage;
                    HealthBar1.Value = example.health;
                }
            }
        }
       
        private void wait1 (object hero1, EventArgs hero1event)
        {
            if (speedbar1.Value < 100) speedbar1.Value += Convert.ToInt32(example.speed);
            else action1(hero1, hero1event);
        }
        private void wait2 (object hero2, EventArgs hero2event)
        {
            if (Speedbar2.Value < 100) speedbar1.Value += Convert.ToInt32(example.speed);
            else action2(hero2, hero2event);
        }
        private void wait3 (object hero3, EventArgs hero3event)
        {
            if (Speedbar3.Value < 100) Speedbar3.Value += Convert.ToInt32(example.speed);
            else action3(hero3, hero3event);
        }
        private void wait4 (object hero4, EventArgs hero4event)
        {
            if (Speedbar4.Value < 100) Speedbar4.Value += Convert.ToInt32(example.speed);
            else action4(hero4, hero4event);
        }
        private void action1 (object hero1, EventArgs hero1event)
        {
            herotimer1.Stop();
            Attackbutton1.Enabled = true;
            Skillbutton1.Enabled = true;
            Itembutton1.Enabled = true;
        }
        private void action2 (object hero2, EventArgs hero2event)
        {
            herotimer2.Stop();
            Attackbutton2.Enabled = true;
            Skillbutton2.Enabled = true;
            Itembutton2.Enabled = true;
        }
        private void action3 (object hero3, EventArgs hero3event)
        {
            herotimer3.Stop();
            Attackbutton3.Enabled = true;
            Skillbutton3.Enabled = true;
            Itemsbutton3.Enabled = true;
        }
        private void action4 (object hero4, EventArgs hero4event)
        {
            herotimer4.Stop();
            Attackbutton4.Enabled = true;
            Skillbutton4.Enabled = true;
            Itemsbutton4.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            atkchose = 2;
        }

        private void Attackbutton1_Click(object sender, EventArgs e)
        {

            if (atkchose == 1) enemyexample.enemyhealth -= example.attack * 3;
            if (atkchose == 2) enemyexample2.enemyhealth -= example.attack * 3;
            if (atkchose == 3) enemyexample3.enemyhealth -= example.attack * 3;

            speedbar1.Value = 0;
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;
            healthupdate();
            herotimer1.Start();
        }

        private void Skillbutton1_Click(object sender, EventArgs e)
        {
            speedbar1.Value = 0;
            textBox1.Show();
            label1.Text = "";
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;
            minigametimer1.Start();
        }
        private void minigame1(object player1, EventArgs player)
        {
            if (minigame1count != 20)
            {
                minigame1count++;
            }
            else
            {
                label1.Hide();
                if (label1.Text == textBox1.Text)
                {
                    if (atkchose == 1) enemyexample.enemyhealth -= 70;
                    if (atkchose == 2) enemyexample2.enemyhealth -= 70;
                    if (atkchose == 3) enemyexample3.enemyhealth -= 70;
                    herotimer1.Start();
                }
                else HealthBar1.Value -= HealthBar1.Value;
                healthupdate();
                herotimer1.Start();
                minigametimer1.Stop();
            }
            
        }

        private void Skillbutton2_Click(object sender, EventArgs e)
        {
            label2.Show();
            minigametimer2.Start();
            Attackbutton2.Enabled = false;
            Skillbutton2.Enabled = false;
            Itembutton2.Enabled = false;

        }
        private void minigame2 (object sender, EventArgs e)
        {
         
            if (minigame2count < 20) minigame2count++;
            else
            {
                label2.Hide();
                if (count2 > 100)
                {
                    if (atkchose == 1) enemyexample.enemyhealth -= example.attack * 10;
                    if (atkchose == 2) enemyexample2.enemyhealth -= example.attack * 10;
                    if (atkchose == 3) enemyexample3.enemyhealth -= example.attack * 10;
                    herotimer2.Start();
                }
                else Healthbar2.Value -= Healthbar2.Value;
                minigame2count = 0;
                count2 = 0;
                minigametimer2.Stop();
                healthupdate();
            }
            
            
        }

        private void Attackbutton2_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemyexample.enemyhealth -= example.attack * 3;
            if (atkchose == 2) enemyexample2.enemyhealth -= example.attack * 3;
            if (atkchose == 3) enemyexample3.enemyhealth -= example.attack * 3;

            Speedbar2.Value = 0;
            Attackbutton2.Enabled = false;
            Skillbutton2.Enabled = false;
            Itembutton2.Enabled = false;
            healthupdate();
            herotimer2.Start();
        }

        private void Attackbutton3_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemyexample.enemyhealth -= example.attack * 3;
            if (atkchose == 2) enemyexample2.enemyhealth -= example.attack * 3;
            if (atkchose == 3) enemyexample3.enemyhealth -= example.attack * 3;

            Speedbar3.Value = 0;
            Attackbutton3.Enabled = false;
            Skillbutton3.Enabled = false;
            Itemsbutton3.Enabled = false;
            healthupdate();
            herotimer3.Start();
        }

        private void Attackbutton4_Click(object sender, EventArgs e)
        {
            if (atkchose == 1) enemyexample.enemyhealth -= example.attack * 3;
            if (atkchose == 2) enemyexample2.enemyhealth -= example.attack * 3;
            if (atkchose == 3) enemyexample3.enemyhealth -= example.attack * 3;

            Speedbar4.Value = 0;
            Attackbutton4.Enabled = false;
            Skillbutton4.Enabled = false;
            Itemsbutton4.Enabled = false;
            healthupdate();
            herotimer4.Start();
        }

        private void Skillbutton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) count2++;
        }

        private void Skillbutton3_Click(object sender, EventArgs e)
        {
            minigame3button.Show();
            minigametimer3.Start();
        }
        private void minigame3 (object sender, EventArgs e)
        {
            
            if (minigame3count < 20) minigame3count++;
            else
            {
                if (count3 >= 25)
                {
                    if (atkchose == 1) enemyexample.enemyhealth -= example.attack * 9;
                    if (atkchose == 2) enemyexample2.enemyhealth -= example.attack * 9;
                    if (atkchose == 3) enemyexample3.enemyhealth -= example.attack * 9;
                    herotimer3.Start();
                }
                else Healthbar3.Value -= Healthbar3.Value; 
                healthupdate();
                minigametimer3.Stop();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int random1 = random.Next(0, 126);
            int random2 = random.Next(0,850);
            count3++;
            minigametimer3.Interval -= 200;
            minigame3button.Location = new System.Drawing.Point(random2, random1);
        }

        private void enemypic1_Click(object sender, EventArgs e)
        {
            atkchose = 1;
        }

        private void enemypic3_Click(object sender, EventArgs e)
        {
            atkchose = 3;
        }
        private void healthupdate()
        {
            enemyhealth1.Value = enemyexample.enemyhealth;
            enemyhealth2.Value = enemyexample2.enemyhealth;
            enemyhealth3.Value = enemyexample3.enemyhealth;
            
        }
    }
}
    
    

