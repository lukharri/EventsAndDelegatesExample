using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesExample
{
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
