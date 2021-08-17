using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Interface
{
     public interface IPerson
    {
      string FirstName { get; set; }

      string LastName { get; set; }


      int Age { get; set; }


      string Gender { get; set; }


      void YouHaveToImplementMe();

        
    }
}
