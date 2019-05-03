using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using SnapshotOptions.Models;

namespace SnapshotOptions.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyOptions _snapshotOptions;

        public IndexModel(IOptionsSnapshot<MyOptions> snapshotOptionsAccessor)
        {
            _snapshotOptions = snapshotOptionsAccessor.Value;
        }

        public string SnapshotOptions { get; private set; }

        public void OnGet()
        {
            // Snapshot options
            var snapshotOption1 = _snapshotOptions.Option1;
            var snapshotOption2 = _snapshotOptions.Option2;
            SnapshotOptions =
                $"snapshot option1 = {snapshotOption1}, " +
                $"snapshot option2 = {snapshotOption2}";
        }
    }
}