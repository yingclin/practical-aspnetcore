using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using P001.DependencyInjection.Services;

namespace P001.DependencyInjection.Pages
{
    public class NextModel : PageModel
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly TransientOperation _transientOperation;

        public NextModel(ISingletonOperation singletonOperation, 
            TransientOperation transientOperation)
        {
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
        }        
        public void OnGet()
        {
        }

        public string GetSingletonId => _singletonOperation.GetId();

        public string GetTransientId => _transientOperation.Id;
    }
}