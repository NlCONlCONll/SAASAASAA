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
        public int atkchose;
        public Random random = new Random();
        public static Yuushadono example;
        public int minigame2count = 0;
        public int minigame3count = 0;
        public int count3 = 0;
        public int count2 = 0;
        public battlephase()
            
        {
            example = new Yuushadono();
            enemyexample = new Enemy();
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
            InitializeComponent();
        }
        
        

        

        private void Form1_Load(object sender, EventArgs e)
        {
            minigame3button.Hide();
            minigametimer2.Interval = 1000;
            minigametimer2.Tick += minigame2;
            minigametimer3.Interval = 5000;
            minigametimer3.Tick += minigame3;
            label2.Hide();
            textBox1.Hide();
            herotimer1.Start();
            herotimer1.Tick += wait1;
            herotimer1.Interval = 1000;
            herotimer2.Interval = 1000;
            herotimer3.Interval = 1000;
            herotimer4.Interval = 1000;
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
            enemyhealth1.Maximum = Convert.ToInt32(enemyexample.enemyhealth);
            enemyhealth1.Value = Convert.ToInt32(enemyexample.enemyhealth);
            enemyhealth1.Minimum = 0;
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;

        }
        private void enemyaction (object enemy1, EventArgs enemy1event)
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
        private void wait1 (object hero1, EventArgs hero1event)
        {
            if (speedbar1.Value < 100) speedbar1.Value += Convert.ToInt32(example.speed);
            else action1(hero1, hero1event);
        }
        private void wait2 (object hero2, EventArgs hero2event)
        {
            if (Speedbar2.Value < 100) speedbar1.Value += Convert.ToInt32(example.speed);
            
        }
        private void wait3 (object hero3, EventArgs hero3event)
        {
            if (Speedbar3.Value < 100) Speedbar3.Value += Convert.ToInt32(example.speed);

        }
        private void wait4 (object hero4, EventArgs hero4event)
        {
            if (Speedbar4.Value < 100) Speedbar4.Value += Convert.ToInt32(example.speed);
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
            
                enemyexample.enemyhealth -= example.attack * 4;
            
            speedbar1.Value = 0;
            Attackbutton1.Enabled = false;
            Skillbutton1.Enabled = false;
            Itembutton1.Enabled = false;
            enemyhealth1.Value = (enemyexample.enemyhealth);
            herotimer1.Start();
        }

        private void Skillbutton1_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            label1.Text = "";
        }

        private void Skillbutton2_Click(object sender, EventArgs e)
        {
            label2.Show();
            minigametimer2.Start();

        }
        private void minigame2 (object sender, EventArgs e)
        {
         
            if (minigame2count < 12) minigame2count++;
            else
            {
                label2.Hide();
                if (count2 > 100)
                {
                    enemyexample.enemyhealth -= example.attack * 10;
                }
                else Healthbar2.Value -= Healthbar2.Value;
            }
            minigame2count = 0;
            count2 = 0;
        }

        private void Attackbutton2_Click(object sender, EventArgs e)
        {
            enemyexample.enemyhealth -= example.attack * 4;

            Speedbar2.Value = 0;
            Attackbutton2.Enabled = false;
            Skillbutton2.Enabled = false;
            Itembutton2.Enabled = false;
            enemyhealth1.Value = (enemyexample.enemyhealth);
            herotimer2.Start();
        }

        private void Attackbutton3_Click(object sender, EventArgs e)
        {
            enemyexample.enemyhealth -= example.attack * 4;

            Speedbar3.Value = 0;
            Attackbutton3.Enabled = false;
            Skillbutton3.Enabled = false;
            Itemsbutton3.Enabled = false;
            enemyhealth1.Value = (enemyexample.enemyhealth);
            herotimer3.Start();
        }

        private void Attackbutton4_Click(object sender, EventArgs e)
        {
            enemyexample.enemyhealth -= example.attack * 4;

            Speedbar4.Value = 0;
            Attackbutton4.Enabled = false;
            Skillbutton4.Enabled = false;
            Itemsbutton4.Enabled = false;
            enemyhealth1.Value = (enemyexample.enemyhealth);
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
            minigame3button.Location{ }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count3++;
            minigametimer3.Interval -= 200;
        }
    }
}
    
    

