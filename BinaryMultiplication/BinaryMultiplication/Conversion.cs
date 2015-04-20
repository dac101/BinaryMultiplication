using System;
using System.Collections.Generic;

namespace BinaryMultiplication
{
    public class BitConversion
    {
        public int Number { get; set; }
        public string TxtToDisPlay { get; set; }
        public List<string> Conversion(int input)
        {
            TxtToDisPlay = "Binary Conversion  : \n";
            var bitConversion = new List<string>();
            int count = 1;
            while (input >= 0)
            {
                if (input == 0)
                {
                    bitConversion.Add("0");
                    break;
                }
                bitConversion.Add(Convert.ToString(input % 2, 2));
                TxtToDisPlay =TxtToDisPlay + " " + "Step "+ count +" :" +input + " mod 2" + " = " + (input % 2) + "\n" ;
                input = input / 2;
                count++;
            }
            
            ProduceZeroBinary(bitConversion);
            bitConversion.Reverse();
            TxtToDisPlay = TxtToDisPlay + "result :" + string.Join("", bitConversion) + " \n";
          
            return bitConversion;
        }

        private static void ProduceZeroBinary(List<string> bitConversion)
        {
            if (bitConversion.ToArray().Length < 3)
            {
                bitConversion.Add("0");
                bitConversion.Add("0");
                bitConversion.Add("0");
            }
        }

        public bool CheckValueToLessThanSeven(int value)
        {
            if (value <= 7)
            {
                return true;
            }
            return false;
        }

        public List<String> ReverseListRegisterFunctionList(List<string> value )
        {
            var reverseCopy = new List<string>();
            for (var i = value.Count-1; i> -1; i--)
            {
                reverseCopy.Add((string) value.ToArray().GetValue(i));
            }
            Console.WriteLine(" " + string.Join("", reverseCopy));
            return reverseCopy;
        }

        public List<String> BinaryToUnary(List<string> value)
        {

            var temp = new List<string>();
            foreach (var x in value)
            {
                if (x.Equals("1"))
                {
                    temp.Add("0l");
                }
                else
                {
                    temp.Add(x);
                }
            }

            Console.WriteLine(string.Join("", temp));
            value = temp;
            var temp2 = new List<string>();
            string hold ="";

            foreach (var x in string.Join("", temp))
            {
                hold = hold + x;
                if (hold.Equals("l0"))
                {
                    temp2.Add("0ll");
                    hold = "";
                }
                if (hold.Equals("0") )
                {
                    temp2.Add(hold);
                    hold = "";
                }
            }
            if (hold.Equals("l"))
            {
                temp2.Add("l");
            }
            Console.WriteLine(string.Join("", temp2));
            List<string> temp3 = new List<string>();
            hold = "";
            foreach (var y in string.Join("", temp2))
            {
                if (temp2.Count == 1)
                {
                    temp3.Add("l");
                    break;
                }

                hold = hold + y;
                if (hold.Equals("l0"))
                {
                    temp3.Add("0ll");
                    hold = "";
                }
                if (hold.Equals("0")|| hold.Equals("ll"))
                {
                    if (hold.Equals("ll"))
                    {
                        temp3.Add("l");
                        hold = "l";
                    }
                    else
                    {
                        temp3.Add(hold);
                        hold = "";   
                    }

                }
            }
            if (value.Count == 3 && hold.Equals("l"))
            {
                temp3.Add("l");
                temp3.Add("l");
            }
            else if (value.Count == 3 || hold.Equals("l"))
            {
                temp3.Add("l");

            }
             List<string> answer = new List<string>();
            foreach (var x in temp3)
            {
                if (x.Contains("0ll"))
                {
                    foreach (var y in x)
                    {
                        if (y.Equals('l'))
                        {
                            answer.Add("l");
                        }
                    }
                }
                else if (x.Contains("l"))
                {
                    answer.Add(x);
                }
                
            }

            Console.WriteLine(string.Join("", answer));
            return answer;
        }

    }
}
