namespace TestCodes;

// EventHandler

public class VideoInfo
{
    public int videoId { get; set; }
    public string videoTitle { get; set; }
    public string videoDesc { get; set; }

}

public class VideoYoutubeChannel
{
    public event EventHandler<VideoInfo> videoEvent;
    public void uploadVideo(VideoInfo videoInfo)
    {
        Console.WriteLine($"New video uploaded {videoInfo.videoTitle}");
        if (videoEvent != null)
        {
            videoEvent.Invoke(this, new VideoInfo { videoId = videoInfo.videoId, videoTitle = videoInfo.videoTitle, videoDesc = videoInfo.videoDesc });
        }
    }
}


public class Subscriber
{
    public void subscribe(VideoYoutubeChannel channel)
    {
        channel.videoEvent += watchVideo;
    }
    public void watchVideo(object? sender,VideoInfo video)
    {
        Console.WriteLine($"User watch {video.videoTitle} of id: {video.videoId}");
    }
}