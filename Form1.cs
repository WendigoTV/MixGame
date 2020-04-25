using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixGame
{
    public partial class Form1 : Form
    {
        bool isMoving = false;
        public static readonly Point marble1DefaultLocation = new Point(45, 145);
        public static readonly Point marble2DefaultLocation = new Point(263, 145);
        public static readonly Point marble3DefaultLocation = new Point(478, 145);
        public static readonly Point glass1DefaultLocation = new Point(11, 65);
        public static readonly Point glass2DefaultLocation = new Point(227, 65);
        public static readonly Point glass3DefaultLocation = new Point(441, 65);
        Point pastLocation1;
        Point pastLocation2;
        public List<PictureBox> glassList;
        public List<Point> glassDefaultLocationList;
        public List<Point> marbleDefaultLocationList;
        Random rnd = new Random();
        int marbleLoc;
        int firstToSwap;
        int secondToSwap;
        int speed = 5;

        public Form1()
        {
            InitializeComponent();
            resetGlassPosition(false);
            glassList = new List<PictureBox>() { glass1, glass2, glass3 };
            glassDefaultLocationList = new List<Point>() { glass1DefaultLocation, glass2DefaultLocation, glass3DefaultLocation };
            marbleDefaultLocationList = new List<Point>() { marble1DefaultLocation, marble2DefaultLocation, marble3DefaultLocation };
            marble.Visible = true;
            marble.Location = marble2DefaultLocation;
            animationFPS.Interval = 1;
            animationFPS.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (speed < 5 || speed > 25)
            {
                return;

            } else { 

            if (!isMoving)
            {
                marble.Visible = false;
                marble.BringToFront();
                whichToSwap();
                startMixing();
                }
            }
        }


        private void startMixing()
        {

            marbleLoc = rnd.Next(0, 3);

            switch (marbleLoc)
            {
                case 1:
                    marble.Location = marble1DefaultLocation;
                    break;
                case 2:
                    marble.Location = marble2DefaultLocation;
                    break;
                case 3:
                    marble.Location = marble3DefaultLocation;
                    break;
            }

            whichToSwap();

            pastLocation1 = glassList[firstToSwap].Location;
            pastLocation2 = glassList[secondToSwap].Location;
            
            isMoving = true;


        }

        private void resetGlassPosition(bool afterSwap)
        {
            if (afterSwap == false)
            {
                glass1.Location = glass1DefaultLocation;
                glass2.Location = glass2DefaultLocation;
                glass3.Location = glass3DefaultLocation;

            } else {
                glassList[firstToSwap].Location = glassDefaultLocationList[firstToSwap];
                glassList[secondToSwap].Location = glassDefaultLocationList[secondToSwap];
            }
        }

        private void animationFPS_Tick(object sender, EventArgs e)
        {
            if (isMoving)
            {
                for (int a = 0; a < speed; a++) {

                    glassList[firstToSwap].Location = new Point(glassList[firstToSwap].Location.X + 1, glassList[firstToSwap].Location.Y);
                    glassList[secondToSwap].Location = new Point(glassList[secondToSwap].Location.X - 1, glassList[secondToSwap].Location.Y);

                    if (glassList[firstToSwap].Location == pastLocation2 || glassList[secondToSwap].Location == pastLocation1)
                    {
                        swapIndexInList();
                        isMoving = false;
                    }
                }
            } else {
                resetGlassPosition(true);
            }
        }

        private void whichToSwap()
        {
            do
            {
                firstToSwap = rnd.Next(0, 2);
                secondToSwap = rnd.Next(1, 3);

            } while (firstToSwap == secondToSwap);
        }

        private void swapIndexInList()
        {
            PictureBox tmp = glassList[firstToSwap];
            glassList[firstToSwap] = glassList[secondToSwap];
            glassList[secondToSwap] = tmp;
        }
    }
}
