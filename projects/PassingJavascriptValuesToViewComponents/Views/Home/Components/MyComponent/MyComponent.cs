using Microsoft.AspNetCore.Mvc;
using PassingJavascriptValuesToViewComponents.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingJavascriptValuesToViewComponents.Views.Home.Components.MyComponent
{
    public class MyComponent : ViewComponent
    {
        public MyComponent() { }

        public IViewComponentResult Invoke(MyComponentModel model)
        {
            model.ScreenWidth = "Read on the server:" + model.ScreenWidth;
            return View(model);
        }
    }
}
