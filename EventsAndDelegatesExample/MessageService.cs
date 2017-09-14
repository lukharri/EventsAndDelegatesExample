using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesExample
{
    class MessageService
    {
        public void onVideoEncoded (object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Service: sending text message..." + e.Video.Title + " has been encoded.");
        }
    }
}
