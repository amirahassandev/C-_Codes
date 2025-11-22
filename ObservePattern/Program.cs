namespace ObservePattern;

internal class program
{
    static void Main(String[] args)
    {
        VideoYoutubeChannel video = new VideoYoutubeChannel();

        VideoYoutubeChannel channel1 = new VideoYoutubeChannel() { channelName = "Elzero" };
        VideoYoutubeChannel channel2 = new VideoYoutubeChannel(){channelName = "Code" };

        Subscriber subscriber1 = new Subscriber();
        Subscriber subscriber2 = new Subscriber();
        Subscriber subscriber3 = new Subscriber();
        Subscriber subscriber4 = new Subscriber();

        subscriber1.subscribe(channel1);
        subscriber2.subscribe(channel1);
        subscriber3.subscribe(channel2);



        // video.uploadVideo("Video1");
        channel1.uploadVideo(new VideoInfoEventArgs { videoId = 1, videoTitle = "v1", videoDesc = "v1_desc_channel1" });
        channel2.uploadVideo(new VideoInfoEventArgs{videoId = 2, videoTitle = "v1", videoDesc = "v1_desc_channel2"});

    }
}