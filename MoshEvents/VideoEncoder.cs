using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshEvents
{
    internal class VideoEncoder
    {
        // 1 - Define a delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // EventHandler
        // EventHandler<TEventArgs>
        public event EventHandler<VideoEventArgs> VideoEncoded;

        // 2 - Define an event based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;

        // 3 - Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
            }
        }


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
    }
}
