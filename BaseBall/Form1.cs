using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace BaseBall
{
    public partial class Form1 : Form
    {
        int vitessemain = 5; //diff moyenne
        double vitesseballe = 0.2; // dif moyenne

        public Form1()
        {
            InitializeComponent();

        }
        public static class Global
        {
            public static int xballe;
            public static int yballe;
            public static bool touche = false;
            public static int point=0;
            public static bool pointpris = false;

        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            
            labscore.Text = "0";


            if (EZbtn.Checked == true) //difficulté EAZY
            {
                vitessemain = 12;
                vitesseballe = 0.1;

            }else if(HDbtn.Checked == true) //difficulté HARD
             {
                vitessemain = 5;
                vitesseballe = 0.5;
            }





            Random aleatoire = new Random();
            groupBoxDiff.Enabled = false; //Empeche l'utilisateur de changer de focus pendant la partie
           
            for (int i = 10; i > 0; i--)
            {
                nbballe.Text = (i - 1).ToString();
                Global.touche = false;
                Global.pointpris = false;
                int multiplicateur = aleatoire.Next(3, 20); //
                Global.xballe = aleatoire.Next(-10, 10);    //le -10 fais que y deviens negatif 
                int acceleration = Convert.ToInt32(Math.Sqrt(Global.xballe * Global.xballe));
                Global.yballe = acceleration * multiplicateur;   // permet a ce que y soit depandant de x mais soit jamais dans le negatif qui ferait partir la balle au dessus

                balle.Location = new Point(175, 74);


                pictureBox1.Image = Image.FromFile("../../GIF/giphy.gif");
                pictureBox1.Visible = true;// GIF ANIMATION 
                await Task.Delay(4700);
                pictureBox1.Visible = false;

                if (Global.xballe != 0)
                {

                    while (balle.Top < 570) //deplacement balle
                    {
                        balle.Top = balle.Top + Convert.ToInt32(Global.yballe * vitesseballe);
                        balle.Left = balle.Left + Convert.ToInt32(Global.xballe * vitesseballe);
                        await Task.Delay(1);

                        if (balle.Top > main.Top && (balle.Left > main.Left && balle.Left < main.Left + 65))
                        {
                            Global.touche = true;


                           
                        }


                    }

                    
                }
                else  // Cas "0"
                {
                    pictureBox1.Image = Image.FromFile("../../GIF/fail.gif");   // C:/Users/maxim/Desktop/BaseBall
                    pictureBox1.Visible = true;
                    await Task.Delay(1700);
                    pictureBox1.Visible = false;

                }
              
                await Task.Delay(2500); //Temps avant nouvelle partie
                if (Global.pointpris == true)        //Systeme de point
                {
                    Global.point++;
                    labscore.Text = Global.point.ToString();
                }

            }

            groupBoxDiff.Enabled = true;
            
            if (Global.point > 5)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("../../GIF/good.gif");
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("../../GIF/bad.gif");
            }

        }
        
   

     

        private async void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.D)
            {
                main.Location = new Point((main.Location.X + vitessemain), main.Location.Y);
            }
            if (e.KeyCode == Keys.Q)
            {
                main.Location = new Point((main.Location.X - vitessemain), main.Location.Y);
            }
            if (e.KeyCode == Keys.Z && Global.touche==true)
            {
                Global.pointpris = true; // Empeche le joueur de tricher en spammant Z
                await Task.Delay(500);
                while (balle.Top > 178)
                {
                    balle.Top = balle.Top - (Convert.ToInt32(Global.yballe * vitesseballe))*2;
                    balle.Left = balle.Left - (Convert.ToInt32(Global.xballe * vitesseballe))*2;
                    await Task.Delay(1);

                }
             

            }
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
