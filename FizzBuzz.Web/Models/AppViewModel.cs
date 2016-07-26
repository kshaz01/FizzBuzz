using FizzBuzz.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzz.Web.Models
{
    public class AppViewModel
    {
        public IAppItem AppItem { get; set; }
    }
}