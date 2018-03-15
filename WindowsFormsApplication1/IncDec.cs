using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NumberMachine
{
    public partial class IncDec : Form
    {

    public bool increment = true;
        public IncDec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String textAndSuch = "";

            textAndSuch = textBox1.Text;
            String[] splitArray = Regex.Split(textAndSuch, @"(?=\p{L})(?=\p{N})");

            List<String> words = new List<String>();
            List<String> numbers = new List<String>();
            List<String> both = new List<String>();

            String result = "";
                bool number = false;
            foreach(char c in textAndSuch)
            {
                

                if (Char.IsNumber(c) && !number)
                {
                    words.Add(result);
                    both.Add(result);
                    result = "";
                    number = true;
                }
                if (!Char.IsNumber(c) && number)
                {
                    numbers.Add(result);
                    both.Add(result);
                    result = "";
                    number = false;
                }

                result += c;

            }

            if (number)
                numbers.Add(result);
            else
                words.Add(result);
            String stuff = "";
            for(int i = 0; i < splitArray.Length; i++)
            {
                stuff += splitArray[i] + " Element "+i;
            }
            //MessageBox.Show(stuff);

            for(int i = 0; i < numbers.Count; i++)
            {
                int j;
                int.TryParse(numbers[i],out  j);
                if (j>0)
                {
                    j = int.Parse(numbers[i]);

                    //if (!words[i].StartsWith(textBoxAfter.Text))
                        j+=increment ? (int)amountSpinner.Value: -(int)amountSpinner.Value;

                    numbers[i] = j.ToString();
                }
            }
            int count = words.Count;
            int stuxdff = numbers.Count.CompareTo(words.Count);
            if (numbers.Count.CompareTo(words.Count) >0)
            {
                count = numbers.Count;
            }
            textAndSuch = "";
            for (int i = 0; i <= count; i++)
            {
                if (i < words.Count)
                    textAndSuch += words[i];
                if(i<numbers.Count)
                    textAndSuch += numbers[i];
            }
            
            textBox1.Text = textAndSuch;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {

                textBox1.SelectAll();
                textBox1.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            increment = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            increment = true;
        }
    }
}
