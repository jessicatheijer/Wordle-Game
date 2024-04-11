using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_06_JESSICA_T
{
    public partial class Form2 : Form
    {        
        string alphabetRow1 = "QWERTYUIOP";
        string alphabetRow2 = "ASDFGHJKL";
        string alphabetRow3 = "ZXCVBNM";
        int counter = 0;
        int counter2 = 0;
        int counterRow = 0;
        int x = 50;
        int y = 50;
        bool enter = false;
        string answer;
        string katanya;
        string[] listWords = File.ReadAllText("Wordle Word List.txt").Split(',');

        public List<Button> listButton = new List<Button>();

        public Form2()
        {
            InitializeComponent();
            Random random = new Random();
            answer = listWords[random.Next(0, listWords.Length - 1)].ToUpper();
        }

        public void UpdateButtons()
        {
            foreach (Button button in listButton)
            {
                this.Controls.Add(button);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CreateKeyboard(alphabetRow1, 0, 45, 5, 0);
            CreateKeyboard(alphabetRow2, 1, 45, 5, 30);
            CreateKeyboard(alphabetRow3, 2, 45, 5, 80);

            for (int i = 0; i < Form1.inputan; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(x, y);
                    button.Tag = counter2.ToString();
                    button.BackColor = Color.White;
                    button.Enabled = false;
                    listButton.Add(button);
                    x += 52;
                    counter2 += 1;
                }
                x = 50;
                y += 52;
                counter2 = 0;
            }
            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Size = new Size(80, 47);
            btnDelete.Location = new Point(754, 184);
            btnDelete.Click += BtnDelete_Click;
            btnDelete.BackColor = Color.White;
            this.Controls.Add(btnDelete);

            Button btnEnter = new Button();
            btnEnter.Text = "Enter";
            btnEnter.Size = new Size(80, 47);
            btnEnter.Location = new Point(322, 184);
            btnEnter.Click += BtnEnter_Click;
            btnEnter.BackColor = Color.White;
            this.Controls.Add(btnEnter);

            UpdateButtons();
        }

        private void CreateKeyboard(string rowText, int row, int buttonSize, int buttonSpacing, int nambah)
        {
            for (int i = 0; i < rowText.Length; i++)
            {
                Button btn = new Button();
                btn.Text = rowText[i].ToString();
                btn.Size = new Size(buttonSize, buttonSize);
                btn.Location = new Point(
                    i * (buttonSize + buttonSpacing) + buttonSpacing + 320 + nambah,
                    row * (buttonSize + buttonSpacing) + buttonSpacing + 80
                );
                btn.BackColor = Color.White;
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; 
            if (enter == false)
            {
                for (int s = counterRow; s < counterRow + 5; s++)
                {
                    Button button = listButton[s];
                    if (button.Tag.ToString() == counter.ToString())
                    {
                        button.Text = btn.Text;
                    }
                }
                counter += 1;
                UpdateButtons();
            }
            if (counter % 5 == 0 && counter != 0)
            {
                enter = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            enter = false;
            katanya = "";
            if (counter > 0)
            {
                counter -= 1;
            }
            for (int s = counterRow; s < counterRow + 5; s++)
            {
                Button button = listButton[s];
                if (button.Tag.ToString() == counter.ToString())
                {
                    button.Text = " ";
                }
            }
            UpdateButtons();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            int cekk = 0;
            int cekajah = 0;
            for (int s = counterRow; s < counterRow + 5; s++)
            {
                Button button = listButton[s];
                if (button.Text == "" || button.Text == " ")
                {
                    cekajah = 1;
                }
                else
                {
                    katanya += button.Text;
                }
            }

            for (int i = 0; i < listWords.Length-1; i ++)
            {
                if (katanya == listWords[i].ToUpper())
                {
                    cekk = 1;
                }
            }

            if (cekajah == 1)
            {
                MessageBox.Show("Please enter a 5 letters word before entering.");
                katanya = "";
                cekajah = 0;
            }
            else if (cekk == 0)
            {
                MessageBox.Show(katanya + " is not an English word. Try Again.");
                katanya = "";
            }
            else
            {
                for (int s = counterRow; s < counterRow + 5; s++)
                {
                    Button button = listButton[s];
                    button.BackColor = Color.LightCoral;
                }
                for (int j = 0; j < answer.Length; j++)
                {
                    if (katanya != "")
                    {
                        if (katanya[j] == answer[0] || katanya[j] == answer[1] || katanya[j] == answer[2] ||
                            katanya[j] == answer[3] || katanya[j] == answer[4])
                        {
                            for (int p = counterRow; p < counterRow + 5; p++)
                            {
                                Button button = listButton[p];
                                if (katanya[j].ToString() == button.Text)
                                {
                                    button.BackColor = Color.LightYellow;
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < answer.Length; i++)
                {
                    if (katanya != "")
                    {
                        if (katanya[i] == answer[i])
                        {
                            for (int p = counterRow; p < counterRow + 5; p++)
                            {
                                Button button = listButton[p];
                                if (katanya[i].ToString() == button.Text && i == Convert.ToInt32(button.Tag))
                                {
                                    button.BackColor = Color.LightGreen;
                                }
                            }
                        }
                    }
                }

                if (katanya == answer)
                {
                    MessageBox.Show("Congartulations! You WON");
                    this.Close();
                }
                else if (counterRow == 5*Form1.inputan-5)
                {
                    MessageBox.Show("GAME OVER! Answer: " + answer);
                    this.Close();
                }
                if (katanya != "")
                { 
                    counterRow += 5;
                    counter = 0;
                }
                katanya = "";
                enter = false;
            }
        }
    }
}
