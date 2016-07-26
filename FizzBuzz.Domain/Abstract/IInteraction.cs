using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Domain.Abstract
{
   public interface IInteraction
    {
       IEnumerable<string> Start(int value);
    }
}
