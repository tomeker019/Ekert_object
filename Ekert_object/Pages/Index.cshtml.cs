using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekert_object.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int Povrch { get; set; }
        public int Objem { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnPost(int A, int B, int C)
        {

            if (A >= 0 & B >= 0 & C >= 0)
            {
                Objem = A * B * C;
                Povrch = 2 * (A * B + B * C + A * C);
            }
            else
            {
            }
        }
    }
}
