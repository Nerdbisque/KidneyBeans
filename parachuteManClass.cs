using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
     static string[] HangDudes(int a)
        {
            string[] dudes = { @"
_ _ _ _ _
  
   ____     
  /____\       
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^", @"
_ _ _ _ _
  
        
  /____\       
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^", @"
_ _ _ _ _
  
       
         
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^", @"
_ _ _ _ _
      
   \ /
    O
   /|\
   / \

^^^^^^^^^^", @"
_ _ _ _ _

    x
   /|\
   / \

^^^^^^^^^^", @"
_ _ _ _ _
  
   ____     
  /____\       
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^", @"
_ _ _ _ _
  
   ____     
  /____\       
  \    /
   \  /
    O
   /|\
   / \

^^^^^^^^^^" };
            return dudes;
    }   
}