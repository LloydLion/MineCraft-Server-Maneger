using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Models
{
    class ServerDownloadInfo : ServerInfo
    {
        public string Link { get; set; }

        public override void Format(params object[] args)
        {
            args = PrepareArrayForFormatMethod(args);
            Link = string.Format(Link, args);
            base.Format(args);
        }
    }
}
