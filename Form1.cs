using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixGame
{
    public partial class MixGame : Form
    {
        bool isMoving = false;
        bool readyToChoose = false;
        bool devMode = false;
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
        int speed;
        int money;
        int profit = 50;
        int currentMixes = 0;
        int numberOfMixes;
        int roundNumber = 0;

        public MixGame()
        {
            if (!System.IO.File.Exists(@"44d7180ae5e00e9346d3badd89ad1bb3") || !System.IO.File.Exists(@"eacf867e4f019f43a04d0b2af7e3e7f4"))
            {
                System.Windows.Forms.MessageBox.Show("ERROR: MISSING_SOURCE_FILES");
                Application.Exit();
            }
            else
            {
                InitializeComponent();
                difficulty.Items.Add("Automatická");
                difficulty.Items.Add("Velmi Lehká");
                difficulty.Items.Add("Lehká");
                difficulty.Items.Add("Střední");
                difficulty.Items.Add("Těžká");
                difficulty.Items.Add("Extrémní");
                gameResults.Hide();
                resetGlassPosition(false);
                glassList = new List<PictureBox>() { glass1, glass2, glass3 };
                glassDefaultLocationList = new List<Point>() { glass1DefaultLocation, glass2DefaultLocation, glass3DefaultLocation };
                marbleDefaultLocationList = new List<Point>() { marble1DefaultLocation, marble2DefaultLocation, marble3DefaultLocation };
                marble.Visible = true;
                marble.Location = marble2DefaultLocation;
                animationFPS.Interval = 1;
                animationFPS.Start();
                colorControl.Interval = 100;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameResults.Hide();
            currentMixes = 0;
            colorControl.Stop();

            if (difficulty.Text != "Prosím, vyberte obtížnost!" && difficulty.Text != "") {
                glass1.Image = global::MixGame.Properties.Resources.GlassFilled;
                glass2.Image = global::MixGame.Properties.Resources.GlassFilled;
                glass3.Image = global::MixGame.Properties.Resources.GlassFilled;
                startButton.Text = "...";
                startButton.Enabled = false;
            }

            if (difficulty.Text == "" || difficulty.Text == "Prosím, vyberte obtížnost!")
            {
                difficulty.DropDownStyle = ComboBoxStyle.DropDown;
                difficulty.Text = "Prosím, vyberte obtížnost!";
                return;

            } else {

                switch(difficulty.Text)
                {
                    case "Automatická":
                        roundNumber += 1;
                        speed = 5 + roundNumber;
                        numberOfMixes = 3 + roundNumber;
                        break;

                    case "Velmi Lehká":
                        speed = 5;
                        numberOfMixes = 3;
                        break;
                    case "Lehká":
                        speed = 10;
                        numberOfMixes = 5;
                        break;
                    case "Střední":
                        speed = 15;
                        numberOfMixes = 10;
                        break;
                    case "Těžká":
                        speed = 20;
                        numberOfMixes = 15;
                        break;
                    case "Extrémní":
                        speed = 25;
                        numberOfMixes = 20;
                        break;
                }
                marble.Visible = false;
                marble.BringToFront();
                callPerMix();
            }
        }

        private void callPerMix()
        {

            currentMixes += 1;

            if (!isMoving)
            {
                whichToSwap();
                startMixing();
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
                readyToChoose = false;

                for (int a = 0; a < speed; a++) {

                    glassList[firstToSwap].Location = new Point(glassList[firstToSwap].Location.X + 1, glassList[firstToSwap].Location.Y);
                    glassList[secondToSwap].Location = new Point(glassList[secondToSwap].Location.X - 1, glassList[secondToSwap].Location.Y);

                    if (glassList[firstToSwap].Location == pastLocation2 || glassList[secondToSwap].Location == pastLocation1)
                    {
                        swapIndexInList();
                        isMoving = false;
                        readyToChoose = true;
                        if (currentMixes <= numberOfMixes)
                        {
                            callPerMix();
                        }
                    }
                }
                marble.Location = new Point(glass2.Location.X + 34, marble.Location.Y);
            } else {
                resetGlassPosition(true);
                if (currentMixes <= numberOfMixes)
                {
                    callPerMix();
                }
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

        private void glass1_Click(object sender, EventArgs e)
        {
            if (readyToChoose)
            {
                glass1.Image = global::MixGame.Properties.Resources.GlassEmpty;
                endgameScreen(false);
            }

        }

        private void glass2_Click(object sender, EventArgs e)
        {
            if (readyToChoose)
            {
                glass2.Image = global::MixGame.Properties.Resources.GlassEmpty;
                marble.Visible = true;
                endgameScreen(true);
            }
        }

        private void glass3_Click(object sender, EventArgs e)
        {
            if (readyToChoose)
            {
                glass3.Image = global::MixGame.Properties.Resources.GlassEmpty;
                endgameScreen(false);
            }
        }

        private bool endgameScreen(bool win)
        {

            if (win)
            {
                gameResults.Location = new Point(107, 9);
                switch (difficulty.Text)
                {
                    case "Automatická":
                        if (profit == 100)
                        {
                            profit = 100;
                        } else
                        {
                            profit = 10 * roundNumber;
                        }

                        money += profit;
                        currentMoney.Text = "$:" + money.ToString();
                        break;

                    case "Velmi Lehká":
                        profit = 100;
                        money += profit;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Lehká":
                        profit = 50;
                        money += profit;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Střední":
                        profit = 20;
                        money += profit;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Těžká":
                        profit = 10;
                        money += profit;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Extrémní":
                        profit = 1;
                        money += profit;
                        currentMoney.Text = "$:" + money.ToString();
                        break;

                    case "You *WON*...":
                        money = 666;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                }
                gameResults.Text = "Pěkně! (+" + profit.ToString() + "$)";
                gameResults.Location = new Point(180, 10);
            } else {
                gameResults.Location = new Point(210, 10);
                gameResults.Text = "Smůla! ;-;";
                switch(difficulty.Text)
                {
                    case "Automatická":
                        money -= profit / 10 * roundNumber;
                        currentMoney.Text = "$:" + money.ToString();
                        break;

                    case "Velmi Lehká":
                        money -= 10;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Lehká":
                        money -= 20;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Střední":
                        money -= 50;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Těžká":
                        money -= 100;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                    case "Extrémní":
                        money = 0;
                        currentMoney.Text = "$:" + money.ToString();
                        break;

                    case "You LOSE, muhahaha!":
                        money = -666;
                        currentMoney.Text = "$:" + money.ToString();
                        break;
                }

            }
            gameResults.Show();
            if(money <= 0)
            {
                startButton.Enabled = false;
                startButton.Text = "Končíš!";
            } else {
                    startButton.Enabled = true;
                    startButton.Text = "Mix!";
            }
            readyToChoose = false;
            colorControl.Start();
            return win;
        }
        private void difficulty_MouseHover(object sender, EventArgs e)
        {
            difficulty.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void difficulty_SelectedValueChanged(object sender, EventArgs e)
        {
            if (difficulty.Text == "Extrémní" || difficulty.Text == "Automatická")
                difficulty.Enabled = false;
        }

        private void colorControl_Tick(object sender, EventArgs e)
        {

            try
            {
                currentMoney.ForeColor = Color.FromArgb(1, money / 16, money / 4, money / 8);
            } 
            catch(ArgumentException)
            {
                currentMoney.ForeColor = Color.FromArgb(1, 255, 255, 255);
                currentMoney.BackColor = Color.FromArgb(50, 252, 11, 3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Pravidla: \r\n" + "Zvolte obtížnost a stiskněte tlačítko \"Mix!\" pro začátek hry a všechna následnující losování. \r\n"
                + "Máte na výběr z 5ti úrovní, přičemž \"Automatická\" narůstá plynule a \"Extrémní\" Vám dá pořádně zabrat! \r\n"
                + "Pokud přijdete o všechny peníze, hra pro Vás končí. \r\n" 
                + "Dále se jedná o klasické \"skořápky\", přeji hodně štěstí! \r\n" 
                + "\r\n"
                + "\r\n"
                + "|9cd1a66d0dff500d226bc8305607219e|");
        }

        private void difficulty_TextChanged(object sender, EventArgs e)
        {
            switch (difficulty.Text)
            {
                case "9cd1a66d0dff500d226bc8305607219e":
                    devMode = true;
                    difficulty.Text = "Developer mode on!";
                    break;

                case "!devMode":
                    devMode = false;
                    difficulty.Text = "Developer mode off!";
                    break;

                case "speed+":
                    if (devMode)
                    {
                        speed += 5;
                        difficulty.Text = "Speed increased!";
                    }
                    break;

                case "speed-":
                    if (devMode)
                    {
                        speed -= 5;
                        difficulty.Text = "Speed decreased!";
                    }
                    break;

                case "money+":
                    if (devMode)
                    {
                        money += 50;
                        difficulty.Text = "Money added!";
                        currentMoney.Text = "$:" + money.ToString();
                    }
                    break;

                case "money-":
                    if (devMode)
                    {
                        money -= 50;
                        difficulty.Text = "Money removed!";
                        currentMoney.Text = "$:" + money.ToString();
                    }
                    break;

                case "profit+":
                    if (devMode)
                    {
                        profit += 50;
                        difficulty.Text = "Profit increased!";
                    }
                    break;

                case "profit-":
                    if (devMode)
                    {
                        profit += 50;
                        difficulty.Text = "Profit decreased!";
                    }
                    break;

                case "rounds+":
                    if (devMode)
                    {
                        roundNumber += 1;
                        difficulty.Text = "Round added!";
                    }
                    break;

                case "rounds-":
                    if (devMode)
                    {
                        roundNumber -= 1;
                        difficulty.Text = "Round removed!";
                    }
                    break;

                case "autowin":
                    if (devMode)
                    {
                        difficulty.Text = "You *WON*...";
                        endgameScreen(true);
                    }
                    break;

                case "autoloss":
                    if (devMode)
                    {
                        difficulty.Text = "You LOSE, muhahaha!";
                        endgameScreen(false);
                    }
                    break;

                case "killkillkill":
                    if (devMode)
                    {
                        Application.Exit();
                    }
                    break;

                case "troll":
                    if (devMode)
                    {
                        MixGame.ActiveForm.ControlBox = false;
                        marble.Image = Properties.Resources.TrollFace;
                        marble.Size = new Size(209, 112);
                        marble.Location = new Point(200, 135);

                        string user = Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                        System.IO.File.Move(@"eacf867e4f019f43a04d0b2af7e3e7f4", @"eacf867e4f019f43a04d0b2af7e3e7f4.png");
                        System.IO.File.Move(@"44d7180ae5e00e9346d3badd89ad1bb3", @"44d7180ae5e00e9346d3badd89ad1bb3.wav");
                        for (int index = 0; index < 666; index++) {
                            string source = @"eacf867e4f019f43a04d0b2af7e3e7f4.png";
                            string target = user + @"\Desktop\eacf867e4f019f43a04d0b2af7e3e7f4 [" + index.ToString() + @"] .png";
                            System.IO.File.Copy(source, target);
                        }

                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = "44d7180ae5e00e9346d3badd89ad1bb3.wav";
                        player.Play();
                    }
                    break;

                case "confirm":
                    if(devMode)
                    {
                        difficulty.Items.Add("Custom");
                        difficulty.DropDownStyle = ComboBoxStyle.DropDownList;
                        difficulty.SelectedItem = "Custom";
                        difficulty.Enabled = false;
                    }
                    break;
            }
        }

        private void MixGame_FormClosing(object sender, FormClosingEventArgs e)
        { 
            try
            {
                System.IO.File.Move(@"eacf867e4f019f43a04d0b2af7e3e7f4.png", @"eacf867e4f019f43a04d0b2af7e3e7f4");
                System.IO.File.Move(@"44d7180ae5e00e9346d3badd89ad1bb3.wav", @"44d7180ae5e00e9346d3badd89ad1bb3");
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }
    }
}
