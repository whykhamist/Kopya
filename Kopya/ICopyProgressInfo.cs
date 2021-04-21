using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopya
{
    public interface ICopyProgressInfo
    {
        string FileName { get; set; }

        string FullName { get; set; }

        double Progress { get; set; }

        bool Cancelled { get; set; }
    }
}
