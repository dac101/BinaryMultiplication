using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryMultiplication
{
   public class TuringFunctions
    {
       public string TxtToDisPlay { get; set; }
       public int BinaryMultipication(List<string> valueX, List<string> valueY)
       {  

         List<string> answer = new List<string>();
         int count = 0;

         TxtToDisPlay =  " Multiplication : X = " + string.Join("", valueX) + " Y = " + string.Join("", valueY) + "  \n\n Add X together based on the amount of Y";   
         foreach (var x in valueY)
         {
             answer.AddRange(valueX);
             TxtToDisPlay = TxtToDisPlay + " + " + string.Join("",valueX);
         }
           TxtToDisPlay = TxtToDisPlay + "\n\n" + " Result : " + string.Join("", answer) + "\n Decimal :" + answer.Count + "\n\n binary :" + Convert.ToString(answer.Count, 2); 
         return answer.Count;
       }

       public List<string> GetLastTwoValue(List<string> items)
       {
       
           var result = new List<string>(); 
           result.Add(items.Last());
           result.Add((string) items.ToArray().GetValue(items.Count - 2));
           return result;
       }
    }
}
