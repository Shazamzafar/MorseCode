//Name:      Shazam Zafar
//Class:     C#
//Date:      04/14/2019


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StringProcessing_ProjectMorseCode_Zafar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creating two dimensional string array
        string[,] MorseCode = new string[40, 2];
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader Morse_Reader = File.OpenText("MorseCode.txt");
            string[] Split_Morse = new string[2];
            string eachMorse = "";
            int row = 0;

            //read in the morse code text file into the MorseCode two dim string array
            while (!Morse_Reader.EndOfStream)
            {
                eachMorse = Morse_Reader.ReadLine();
                Split_Morse = eachMorse.Split(',');
                for (int col = 0; col < 2; col++)
                {
                    MorseCode[row, col] = Split_Morse[col];
                }
                row++;
            }
        }
        private void Convert_Button_Click(object sender, EventArgs e)
        {
            string UserText = User_TextBox.Text.ToUpper();

            if (User_TextBox.Text != "")
            {
                //clear listbox to add new morse code
                MorseCode_ListBox.Items.Clear();
                //convert the users string into morse code and add to listbox
                foreach (char ch in UserText)
                {
                    if (ch.ToString().Contains("A"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[0, 1]);
                    }
                    else if (ch.ToString().Contains("B"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[1, 1]);
                    }
                    else if (ch.ToString().Contains("C"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[2, 1]);
                    }
                    else if (ch.ToString().Contains("D"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[3, 1]);
                    }
                    else if (ch.ToString().Contains("E"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[4, 1]);
                    }
                    else if (ch.ToString().Contains("F"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[5, 1]);
                    }
                    else if (ch.ToString().Contains("G"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[6, 1]);
                    }
                    else if (ch.ToString().Contains("H"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[7, 1]);
                    }
                    else if (ch.ToString().Contains("I"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[8, 1]);
                    }
                    else if (ch.ToString().Contains("J"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[9, 1]);
                    }
                    else if (ch.ToString().Contains("K"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[10, 1]);
                    }
                    else if (ch.ToString().Contains("L"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[11, 1]);
                    }
                    else if (ch.ToString().Contains("M"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[12, 1]);
                    }
                    else if (ch.ToString().Contains("N"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[13, 1]);
                    }
                    else if (ch.ToString().Contains("O"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[14, 1]);
                    }
                    else if (ch.ToString().Contains("P"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[15, 1]);
                    }
                    else if (ch.ToString().Contains("Q"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[16, 1]);
                    }
                    else if (ch.ToString().Contains("R"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[17, 1]);
                    }
                    else if (ch.ToString().Contains("S"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[18, 1]);
                    }
                    else if (ch.ToString().Contains("T"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[19, 1]);
                    }
                    else if (ch.ToString().Contains("U"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[20, 1]);
                    }
                    else if (ch.ToString().Contains("V"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[21, 1]);
                    }
                    else if (ch.ToString().Contains("W"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[22, 1]);
                    }
                    else if (ch.ToString().Contains("X"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[23, 1]);
                    }
                    else if (ch.ToString().Contains("Y"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[24, 1]);
                    }
                    else if (ch.ToString().Contains("Z"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[25, 1]);
                    }
                    else if (ch.ToString().Contains("0"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[26, 1]);
                    }
                    else if (ch.ToString().Contains("1"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[27, 1]);
                    }
                    else if (ch.ToString().Contains("2"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[28, 1]);
                    }
                    else if (ch.ToString().Contains("3"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[29, 1]);
                    }
                    else if (ch.ToString().Contains("4"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[30, 1]);
                    }
                    else if (ch.ToString().Contains("5"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[31, 1]);
                    }
                    else if (ch.ToString().Contains("6"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[32, 1]);
                    }
                    else if (ch.ToString().Contains("7"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[33, 1]);
                    }
                    else if (ch.ToString().Contains("8"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[34, 1]);
                    }
                    else if (ch.ToString().Contains("9"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[35, 1]);
                    }
                    else if (ch.ToString().Contains(" "))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[36, 1]);
                    }
                    else if (ch.ToString().Contains(","))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[37, 1]);
                    }
                    else if (ch.ToString().Contains("."))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[38, 1]);
                    }
                    else if (ch.ToString().Contains("?"))
                    {
                        MorseCode_ListBox.Items.Add(MorseCode[39, 1]);
                    }
                    else
                    {
                        MorseCode_ListBox.Items.Add(ch.ToString()); //this displays the character entered if no morse code for that character is found.
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a something to be convereted into morse code.");
            }
        }
    }
}


    
