using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
   public class parachuteMan
   {
      public string display(int which)
      {
         string[] parachute = { 
@"
  
   ____     
  /____\       
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^", @"
        
  /____\       
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^", @" 
         
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^", @"
      
   \ /
    O
   /|\
   / \

^^^^^^^^^^", @"

    x
   /|\
   / \

^^^^^^^^^^"
      };

         string changedParachute = parachute[0];

         if (which == 1)
         {

         }
         else if (which == 2)  
         {
           
         }
         else if (which == 3)  
         {
            
         }
         else if (which == 4)  
         {
         
         }
         
         
         return changedParachute;
      }
   }
}