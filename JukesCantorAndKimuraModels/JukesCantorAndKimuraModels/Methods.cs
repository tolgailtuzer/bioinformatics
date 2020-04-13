using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JukesCantorAndKimuraModels
{
    class Methods
    {
        private static Dictionary<char, string> checker = new Dictionary<char, string> {
                                                                                        {'a',"purine"},
                                                                                        {'g',"purine"},
                                                                                        {'t',"pyrimidine"},
                                                                                        {'u',"pyrimidine"},
                                                                                        {'c',"pyrimidine"},
                                                                                       };
        private static Dictionary<string, string> checker2 = new Dictionary<string, string> {
                                                                                        {"purine-purine","transition"},
                                                                                        {"pyrimidine-pyrimidine","transition"},
                                                                                        {"purine-pyrimidine","transversion"},
                                                                                        {"pyrimidine-purine","transversion"}
                                                                                        };

        public static double JukesCantor(string s1, string s2)
        {
            try
            {
                double p = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i]) p++;
                }
                p /= s1.Length;
                
                double K = -(3.0/4.0) * (Math.Log(1 - (4.0/3.0 * p)));
                if (p < 0 || p > 0.75) throw new Exception("Jukes-Cantor | p value must be in [0,0.75] range");
                if (K is Double.NaN) throw new Exception("Jukes-Cantor | NaN Error");
                if (Double.IsInfinity(K)) throw new Exception("Jukes-Cantor | Infinity Error");
                return K;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        public static double Kimura(string s1, string s2)
        {
            try
            {
                double P = 0, Q = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i]!=s2[i])
                    {
                        string info = checker[s1[i]] + "-" + checker[s2[i]];
                        if (checker2[info].Equals("transition")) P++;
                        else if (checker2[info].Equals("transversion")) Q++;
                    }
                    
                }
                P /= s1.Length;
                Q /= s1.Length;
                double K = (0.5 * Math.Log(1 / (1 - (2 * P) - Q))) + (0.25 * Math.Log(1 / (1 - (2 * Q))));
                if (P < 0 || P > 0.75) throw new Exception("Kimura | P value must be in [0,0.75] range");
                if (Q < 0 || Q > 0.75) throw new Exception("Kimura | Q value must be in [0,0.75] range");
                if (K is Double.NaN) throw new Exception("Kimura | NaN Error");
                if (Double.IsInfinity(K)) throw new Exception("Kimura | Infinity Error");
                return K;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }
    }
}
