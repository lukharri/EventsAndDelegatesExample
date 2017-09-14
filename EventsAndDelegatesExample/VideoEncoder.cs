using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsAndDelegatesExample
{
    class VideoEncoder
    {
        // METHOD 1
        // 1- define a custom delegate
        // 2- define an event based on that delegate
        // 3- raise the event in a method

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);
        // public event VideoEncodedEventHandler VideoEncoded;

        // protected virtual void OnVideoEncoded(Video video)
        // {
        //    VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video } );
        // }


        // METHOD 2
        // Similar to method 1 except use .NET delegate type (EventHandler, EventHandler<TEventArgs>)
        public event EventHandler<VideoEventArgs> VideoEncoded;

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

    }

}
