using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryMultiplication
{
    public class BitConversion
    {
        public int Number { get; set; }
        public string TxtToDisPlay { get; set; }
        public List<string> Conversion(int input)
        {
            TxtToDisPlay = " Binary Conversion  : \n\n";
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
                
                TxtToDisPlay =TxtToDisPlay + " " + "Step "+ count +": " +input + " mod 2" + " = " + (input % 2) + "\n" ;
                input = input / 2;
                count++;
            }
            
            ProduceZeroBinary(bitConversion);
            bitConversion.Reverse();
            TxtToDisPlay = TxtToDisPlay + "\n result : " + string.Join("", bitConversion) + " \n";
          
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
            return reverseCopy;
        }

        public List<String> BinaryToUnary(List<string> value)
        {

            TxtToDisPlay = "Major Step 1: replace All 1 with 0l userInput " + string.Join("", value) + "\n\n";  
            var temp = new List<string>();
            int count = 1;

            foreach (var x in value)
            {
                if (x.Equals("1"))
                {
                    temp.Add("0l");
                    TxtToDisPlay = TxtToDisPlay + "Step " + count +": " + x + " = " + "0l" + "\n";
                }
                else
                {
                   temp.Add(x);
                   TxtToDisPlay = TxtToDisPlay + "Step " + count +": " + x + " = " + x +"\n";
                }
                count++;
            }
            TxtToDisPlay = TxtToDisPlay + "\n\nMajor Step 2: Replace all l0 with 0ll  userInput = " + string.Join("", temp) + " \n\n";
       

            var temp2 = new List<string>();

            string hold ="";

            foreach (var x in string.Join("", temp))
            {
                hold = hold + x;
                if (hold.Equals("l0"))
                {
                    temp2.Add("0ll");
                    TxtToDisPlay = TxtToDisPlay + "Step " + count + ": " + hold + " = " + "0ll" + "\n";
                    hold = "";
                }
                if (hold.Equals("0") )
                {
                    temp2.Add(hold);
                    TxtToDisPlay = TxtToDisPlay + "Step " + count + ": " + hold + " = " + hold + "\n";
                    hold = "";
                }
                count++;
            }
            if (hold.Equals("l"))
            {
                temp2.Add("l");
            }
  
            var temp3 = new List<string>();
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
                    TxtToDisPlay = TxtToDisPlay + "Step " + count + ": " + hold + " = " + "0ll" + "\n";
                    temp3.Add("0ll");
                    hold = "";
                }
                if (hold.Equals("0")|| hold.Equals("ll"))
                {
                    if (hold.Equals("ll"))
                    {
                        TxtToDisPlay = TxtToDisPlay + "Step " + count + ": " + hold + " = " + hold + "\n";
                        temp3.Add("l");
                        hold = "l";
                    }
                    else
                    {
                        TxtToDisPlay = TxtToDisPlay + "Step " + count + ": " + hold + " = " + hold + "\n";
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

            TxtToDisPlay = TxtToDisPlay + "\n\nMajor Step 3 : get rid of the 0 from  userInput = " + string.Join("", temp3) + " \n\n";
            var answer = new List<string>();           
            foreach (var x in temp3)
            {
                if (x.Contains("0ll"))
                {
                    foreach (var y in x.Where(y => y.Equals('l')))
                    {
                        answer.Add("l");
                        TxtToDisPlay = TxtToDisPlay + "Step " + count + ": " + "x = l so " + "Add l To new Array result = " + string.Join("", answer) + "\n";
                    }
                }
                else if (x.Contains("l"))
                {
                    TxtToDisPlay = TxtToDisPlay + "Step " + count + ": " + "Add l To new Array result = " + string.Join("",answer) +"\n";
                    answer.Add(x);
                }
                count++;
            }

            return answer;
        }

    }
}
