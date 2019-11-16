using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioinformaticsTranslateTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void translate_Click(object sender, EventArgs e)
        {
            string input = sequence1.Text;
            input = Regex.Replace(input, @"[^a-zA-Z]", "");
            input = input.ToUpper();
            try
            {
                if (selection1.SelectedItem.Equals(selection2.SelectedItem)) MessageBox.Show("Please choose different sequence types.");
                else if (selection1.SelectedItem.Equals("Amino Acid") && selection2.SelectedItem.Equals("Protein")) MessageBox.Show("Please choose different sequence types.");
                else
                {
                    string chs = selection1.SelectedItem.ToString() + " to " + selection2.SelectedItem.ToString();
                    switch (chs)
                    {
                        case "DNA to Amino Acid": label1.Text = "DNA Sequence"; label2.Text = "Amino Acid Sequence"; sequence2.Text = Operations.DNAtoAmino(input); break;
                        case "DNA to Protein": label1.Text = "DNA Sequence"; label2.Text = "Protein Sequence"; sequence2.Text = Operations.DNAtoProtein(input); break;
                        case "Amino Acid to DNA": label1.Text = "Amino Acid Sequence"; label2.Text = "DNA Sequence"; sequence2.Text = Operations.AminotoDNA(input); break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please choose sequence types.");
            }

        }

        private void swap_Click(object sender, EventArgs e)
        {
            string temp = sequence1.Text;
            sequence1.Text = sequence2.Text;
            sequence2.Text = temp;
            temp = label1.Text;
            label1.Text = label2.Text;
            label2.Text = temp;

        }

        private void clear1_Click(object sender, EventArgs e)
        {
            sequence1.Clear();
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            sequence2.Clear();
        }
    }
}
