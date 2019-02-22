using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingJavascriptValuesToViewComponents.ViewModels
{
    public class MyComponentModel
    {
        public FormData FormData { get; set; }
        public string ScreenWidth { get; set; }
    }

    public class FormData
    {
        public string Name { get; set; }
    }
}
