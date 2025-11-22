namespace ObservePattern;

// ObservePattern
// public class VideoYoutubeChannel
// {
//     public delegate void VideoUpload(string videoTitle);
//     public event VideoUpload videoUploadEvent;
//     public void uploadVideo(string videoTitle)
//     {
//         Console.WriteLine($"New video uploaded {videoTitle}");
//         if(videoUploadEvent != null)
//         {
//             videoUploadEvent.Invoke(videoTitle);
//         }
//     }
// }


// public class Subscriber
// {
//     public void subscribe(VideoYoutubeChannel videoYoutubeChannel)
//     {
//         videoYoutubeChannel.videoUploadEvent += watchVideo;
//     }
//     public void watchVideo(string videoTitle)
//     {
//         Console.WriteLine($"User watch {videoTitle}");
//     }
// }



// observe Pattern with eventHandler + string
// public class VideoYoutubeChannel
// {
//     public event EventHandler<string> videoEvent;
//     public void uploadVideo(string videoTitle)
//     {
//         Console.WriteLine($"New video uploaded {videoTitle}");
//         if(videoEvent != null)
//         {
//             videoEvent.Invoke(this, videoTitle);
//         }
//     }
// }


// public class Subscriber
// {

//     public void subscribe(VideoYoutubeChannel channel)
//     {
//         channel.videoEvent += watchVideo;
//     }
//     public void watchVideo(object? sender, string videoTitle)
//     {
//         Console.WriteLine($"User watch {videoTitle}");
//     }
// }



// observe Pattern with eventHandler + class
public class VideoInfoEventArgs: EventArgs
{
    public int videoId { get; set; }
    public string videoTitle { get; set; }
    public string videoDesc { get; set; }

}

public class VideoYoutubeChannel
{
    public string channelName { get; set; }
    public event EventHandler<VideoInfoEventArgs> videoEvent;
    public void uploadVideo(VideoInfoEventArgs videoInfo)
    {
        Console.WriteLine($"{channelName} upload New video called {videoInfo.videoTitle}");
        if (videoEvent != null)
        {
            videoEvent.Invoke(this, new VideoInfoEventArgs { videoId = videoInfo.videoId, videoTitle = videoInfo.videoTitle, videoDesc = videoInfo.videoDesc });
        }
    }
}


public class Subscriber
{
    public void subscribe(VideoYoutubeChannel channel)
    {
        channel.videoEvent += watchVideo;
    }
    public void watchVideo(object sender,VideoInfoEventArgs video)
    {
        VideoYoutubeChannel channel = (VideoYoutubeChannel)sender;
        Console.WriteLine($"User watch {video.videoTitle} of id: {video.videoId} from {channel.channelName}");
    }
}