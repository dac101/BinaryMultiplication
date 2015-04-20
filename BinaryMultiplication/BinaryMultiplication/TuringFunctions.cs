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

         TxtToDisPlay = TxtToDisPlay + "Multiplication : ";   
         foreach (var x in valueY)
         { 
               foreach (var y in valueX)
               {
                   answer.Add(y);

               }   
             TxtToDisPlay = TxtToDisPlay + " + " + string.Join("",valueY);    
      
           }
           TxtToDisPlay = TxtToDisPlay + "\n" + " Result : " + string.Join("", answer) +  "\n Count :"+ answer.Count;
           return answer.Count;


       }

       public List<string> GetLastTwoValue(List<string> items)
       {
       
           List<string> result = new List<string>(); 
           result.Add(items.Last());
           result.Add((string) items.ToArray().GetValue(items.Count - 2));
           return result;
       }
    }
}
