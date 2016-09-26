using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Texter.Models.ViewModels
{
    public class SendMessageViewModel
    {
        public List<string> Recipients { get; set; }
        public string From { get; set; }
        public string Body { get; set; }
        public string Status { get; set; }
    };
}
