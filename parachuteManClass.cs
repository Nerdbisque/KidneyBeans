using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
   public class parachuteMan
   {
      static string[] display()
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
         return parachute;
      }
   }
}