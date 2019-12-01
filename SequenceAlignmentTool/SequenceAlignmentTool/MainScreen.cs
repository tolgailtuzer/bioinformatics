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

namespace SequenceAlignmentTool
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        public struct node
        {
            public int value;
            public int i;
            public int j;
            public string cL;
        }
        private Regex regexNucleotide = new Regex(@"^[ATUGC]+$");
        private void startAlgorithm_Click(object sender, EventArgs e)
        {
            try
            {
                int match, mismatch, gapPenalty;

                if(!int.TryParse(this.match.Text, out match)) throw new Exception("Match Score must be int.");
                if (!int.TryParse(this.mismatch.Text, out mismatch)) throw new Exception("Mismatch Score must be int.");
                if (!int.TryParse(this.gapPenalty.Text, out gapPenalty)) throw new Exception("Gap Penalty Score must be int.");

                string firstSeq = sequence1.Text.ToUpper();
                string secondSeq = sequence2.Text.ToUpper();
                if (regexNucleotide.IsMatch(firstSeq) == false || regexNucleotide.IsMatch(secondSeq) == false) throw new Exception("Sequences must be nucleotide sequence.");

                bool status;               
                if (SW.Checked) status = true;
                else if (NW.Checked) status = false;
                else throw new Exception("You need to choose a method first.");

                node[,] result = new node[firstSeq.Length + 1, secondSeq.Length + 1];
                node max = new node();
                max.value = -1;
                max.i = -1;
                max.j = -1;
                for (int i = 0; i < firstSeq.Length + 1; i++)
                {
                    for (int j = 0; j < secondSeq.Length + 1; j++)
                    {
                        if (i == 0)
                        {
                            result[i, j].value = j * (status == true ? 0 : gapPenalty);
                            result[i, j].i = -1;
                            result[i, j].j = -1;
                        }
                        else if (j == 0)
                        {
                            result[i, j].value = i * (status == true ? 0 : gapPenalty);
                            result[i, j].i = -1;
                            result[i, j].j = -1;
                        }
                        else
                        {
                            int cross;
                            if (firstSeq[i - 1] == secondSeq[j - 1])
                            {
                                cross = result[i - 1, j - 1].value + match;
                            }
                            else
                            {
                                cross = result[i - 1, j - 1].value + mismatch;
                            }
                            int value = Math.Max(cross, Math.Max(result[i - 1, j].value + gapPenalty, result[i, j - 1].value + gapPenalty));
                            value = ((status == true) && (value < 0) ? 0 : value);
                            if (value == cross)
                            {
                                result[i, j].value = value;
                                result[i, j].i = i - 1;
                                result[i, j].j = j - 1;
                                result[i, j].cL = firstSeq[i - 1] + "," + secondSeq[j - 1];
                            }
                            else if (value == result[i - 1, j].value + gapPenalty)
                            {
                                result[i, j].value = value;
                                result[i, j].i = i - 1;
                                result[i, j].j = j;
                                result[i, j].cL = firstSeq[i - 1] + ",—";
                            }
                            else if (value == result[i, j - 1].value + gapPenalty)
                            {
                                result[i, j].value = value;
                                result[i, j].i = i;
                                result[i, j].j = j - 1;
                                result[i, j].cL = "—," + secondSeq[j - 1];
                            }
                            if (result[i, j].value > max.value)
                            {
                                max.value = result[i, j].value;
                                max.i = i;
                                max.j = j;
                            }
                        }
                    }
                }

                /*string txt = "";
                for (int i = 0; i < firstSeq.Length + 1; i++)
                {
                    for (int j = 0; j < secondSeq.Length + 1; j++)
                    {
                        txt+=String.Format("{0,5}",result[i, j].value) + " ";
                    }
                    txt += "\n";
                }
                label4.Text = txt;*/

                int k, l;
                if (!status)
                {
                    k = firstSeq.Length;
                    l = secondSeq.Length;
                }
                else
                {
                    k = max.i;
                    l = max.j;
                }
                string seq1Text = "", seq2Text = "";
                while (result[k, l].i != -1 && result[k, l].j != -1)
                {
                    if (status && result[k, l].value == 0) break;
                    seq1Text += result[k, l].cL.Split(',')[0];
                    seq2Text += result[k, l].cL.Split(',')[1];                    
                    int tk = result[k, l].i;
                    int tl = result[k, l].j;
                    k = tk;
                    l = tl;
                }
                seq1res.Text = ""; seq2res.Text = "";
                for (int i = seq1Text.Length - 1; i >= 0; i--)
                {
                    seq1res.Text += seq1Text[i] + " ";
                    seq2res.Text += seq2Text[i] + " ";
                }
                if (!status) score.Text = "Score:" + result[firstSeq.Length, secondSeq.Length].value;
                else score.Text = "Score:" + result[max.i, max.j].value;
                this.Width = 538;
                this.Height = 460;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }      
    }
}
