using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioinformaticsTranslateTool
{
    class Operations
    {
        public static Dictionary<string, string> DNAtoProteinVal = new Dictionary<string, string>{  { "TTT" , "F"}, {"CTT" , "L"}, {"ATT" , "I"}, {"GTT" , "V"},
                                                                                                    { "TTC" , "F"}, {"CTC" , "L"}, {"ATC" , "I"}, {"GTC" , "V"},
                                                                                                    { "TTA" , "L"}, {"CTA" , "L"}, {"ATA" , "I"}, {"GTA" , "V"},
                                                                                                    { "TTG" , "L"}, {"CTG" , "L"}, {"ATG" , "M"}, {"GTG" , "V"},
                                                                                                    { "TCT" , "S"}, {"CCT" , "P"}, {"ACT" , "T"}, {"GCT" , "A"},
                                                                                                    { "TCC" , "S"}, {"CCC" , "P"}, {"ACC" , "T"}, {"GCC" , "A"},
                                                                                                    { "TCA" , "S"}, {"CCA" , "P"}, {"ACA" , "T"}, {"GCA" , "A"},
                                                                                                    { "TCG" , "S"}, {"CCG" , "P"}, {"ACG" , "T"}, {"GCG" , "A"},
                                                                                                    { "TAT" , "Y"}, {"CAT" , "H"}, {"AAT" , "N"}, {"GAT" , "D"},
                                                                                                    { "TAC" , "Y"}, {"CAC" , "H"}, {"AAC" , "N"}, {"GAC" , "D"},
                                                                                                    { "TAA" , "-"}, {"CAA" , "Q"}, {"AAA" , "K"}, {"GAA" , "E"},
                                                                                                    { "TAG" , "-"}, {"CAG" , "Q"}, {"AAG" , "K"}, {"GAG" , "E"},
                                                                                                    { "TGT" , "C"}, {"CGT" , "R"}, {"AGT" , "S"}, {"GGT" , "G"},
                                                                                                    { "TGC" , "C"}, {"CGC" , "R"}, {"AGC" , "S"}, {"GGC" , "G"},
                                                                                                    { "TGA" , "-"}, {"CGA" , "R"}, {"AGA" , "R"}, {"GGA" , "G"},
                                                                                                    { "TGG" , "W"}, {"CGG" , "R"}, {"AGG" , "R"}, {"GGG" , "G"}};


        public static Dictionary<string, string> ProteintoDNAVal = new Dictionary<string, string>{ { "F" , "TTT"}, {"L" , "CTT"}, {"I" , "ATT"}, {"V" , "GTT"},
                                                                                                   { "S" , "TCT"}, {"P" , "CCT"}, {"T" , "ACT"}, {"A" , "GCT"},
                                                                                                   { "Y" , "TAT"}, {"H" , "CAT"}, {"N" , "AAT"}, {"D" , "GAT"},
                                                                                                   { "C" , "TGC"}, {"R" , "CGC"}, {"G" , "GGC"}, {"E" , "GAA"},
                                                                                                   { "W" , "TGG"}, {"M" , "ATG"}, {"Q" , "CAA"}, {"K" , "AAA"}};
        public static string DNAtoAmino(string input)
        {
            string nInput, result = "";
            try
            {
                for (int i = 0; i < input.Length - 2; i += 3)
                {
                    nInput = input[i] + "" + input[i + 1] + "" + input[i + 2];
                    result += DNAtoProteinVal[nInput];
                }
                if (result == "") result = "Wrong sequence type.";
                return result;
            }
            catch (Exception e)
            {
                return "Wrong sequence type.";
            }
        }

        public static string DNAtoProtein(string input)
        {
            string nInput, result = "", temp = "";
            bool isStop = false;
            try
            {
                for (int i = 0; i < input.Length - 2; i++)
                {
                    nInput = input[i] + "" + input[i + 1] + "" + input[i + 2];
                    if (DNAtoProteinVal[nInput] == "M")
                    {
                        temp = "";
                        isStop = false;
                        temp += "[" + DNAtoProteinVal[nInput];
                        for (i = i + 3; i < input.Length - 2; i += 3)
                        {
                            nInput = input[i] + "" + input[i + 1] + "" + input[i + 2];
                            if (DNAtoProteinVal[nInput] == "-")
                            {
                                isStop = true;
                                temp += "]";
                                break;
                            }
                            temp += DNAtoProteinVal[nInput];
                        }
                        if (isStop) result += temp;
                    }

                }

                if (result == "") result = "Wrong sequence type.";
                return result;
            }
            catch (Exception e)
            {
                return "Wrong sequence type.";
            }
        }

        public static string AminotoDNA(string input)
        {
            string nInput, result = "";
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    nInput = Convert.ToString(input[i]);

                    result += ProteintoDNAVal[nInput];
                }

                if (result == "") result = "Wrong sequence type.";
                return result.ToLower();
            }
            catch (Exception e)
            {
                return "Wrong sequence type.";
            }
        }
    }
}
