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

namespace JukesCantorAndKimuraModels
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        private Regex regex = new Regex(@"^[atugc]+$");
        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                res1label.Visible = false;
                res1textbox.Visible = false;
                res2label.Visible = false;
                res2textbox.Visible = false;
                string seq1 = sequnce1.Text.ToLower();
                string seq2 = sequence2.Text.ToLower();
                
                if (seq1.Length != seq2.Length) throw new Exception("Sequence lengths must be equal.");
                if (regex.IsMatch(seq1) == false || regex.IsMatch(seq2) == false) throw new Exception("Sequences must be nucleotide sequence.");
                if (jukescantor.Checked && !kimura.Checked)
                {
                    double resJ = Methods.JukesCantor(seq1, seq2);
                    if (resJ != -1)
                    {
                        this.Height = 305;
                        res1label.Text = "Jukes Cantor: ";
                        res1label.Visible = true;
                        res1textbox.Visible = true;
                        res1textbox.Text = resJ.ToString();
                    }
                }

                else if (kimura.Checked && !jukescantor.Checked)
                {
                    double resK = Methods.Kimura(seq1, seq2);
                    if (resK != -1)
                    {
                        this.Height = 305;
                        res1label.Text = "Kimura: ";
                        res1label.Visible = true;
                        res1textbox.Visible = true;
                        res1textbox.Text = resK.ToString();
                    }
                }
                else if(kimura.Checked && jukescantor.Checked)
                {
                    double resJ = Methods.JukesCantor(seq1, seq2);
                    if (resJ != -1)
                    {
                        this.Height = 340;
                        res1label.Text = "Jukes Cantor: ";
                        res1label.Visible = true;                       
                        res1textbox.Visible = true;
                        res1textbox.Text = resJ.ToString();
                    }
                    double resK = Methods.Kimura(seq1, seq2);
                    if (resK != -1)
                    {
                        this.Height = 340;
                        res2label.Text = "Kimura: ";
                        res2label.Visible = true;
                        res2textbox.Visible = true;
                        res2textbox.Text = resK.ToString();
                    }
                }
                if (!jukescantor.Checked && !kimura.Checked) throw new Exception("You need to choose a method.");
                jukescantor.Checked = false;
                kimura.Checked = false;
                sequnce1.Clear();
                sequence2.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Height = 270;
            }
            
        }
    }
}
