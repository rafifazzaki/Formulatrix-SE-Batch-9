// ? is to mark when it could be null so it could still run. null checking operator
// Something?.Run() -> ini berarti, kalau misalkan yang kiri null (Something = null) maka Run() ngga dijalankan


public delegate void PlatformToSendDelegate(Video video);
// public delegate int VideoWatch(int watchCount);
class Program{
    static void Main(){
        Youtube yt = new();
        Instagram ig = new();
        Tiktok tk = new();
        WhatsApp wa = new();

        App app = new();
        Video catVideo = new("Chipi chapa cat", 0.56f);
        app.platformToSendDelegate = yt.YtShort;
        app.platformToSendDelegate += ig.InstaReels;
        app.platformToSendDelegate += tk.TiktokVideo;
        app.platformToSendDelegate += wa.SendGroupVideo;
        app.platformToSendDelegate += wa.SendVideo;
        app.SendOneMinuteVideo(catVideo);

        Console.WriteLine("-----");

        Video viralVideo = new("prank", 0.6f);
        app.platformToSendDelegate -= wa.SendGroupVideo;
        app.platformToSendDelegate -= wa.SendVideo;
        app.SendOneMinuteVideo(viralVideo);

    }
}
public interface ISocialMedia{
    void Uploader();
    void UploadedAt();
}

public class Youtube : ISocialMedia{

    #region interface
    public void Uploader(){}
    public void UploadedAt(){}

    #endregion
    public void YtShort(Video video){
        Console.WriteLine($"YtShort one minutes video : {video.name}");
    }

    public int Watch(int watchCount){
        return watchCount;
    }
}

public class Instagram : ISocialMedia{

    #region interface
    public void Uploader(){}
    public void UploadedAt(){}

    #endregion
    public void InstaReels(Video video){
        Console.WriteLine($"InstaReels one minutes video : {video.name}");
    }

    public int Watch(int watchCount){
        return watchCount;
    }
}

public class Tiktok : ISocialMedia{

    #region interface
    public void Uploader(){}
    public void UploadedAt(){}

    #endregion
    public void TiktokVideo(Video video){
        Console.WriteLine($"Tiktok one minutes video : {video.name}");
    }

    public int Watch(int watchCount){
        return watchCount;
    }
}

public class WhatsApp{
    public void SendGroupVideo(Video video){
        Console.WriteLine($"WhatsApp Group video : {video.name}");
    }

    public void SendVideo(Video video){
        Console.WriteLine($"WhatsApp video : {video.name}");
    }

    public int Watch(int watchCount){
        return watchCount;
    }
}

public class App{
    public PlatformToSendDelegate? platformToSendDelegate;

    public void SendOneMinuteVideo(Video video){
        platformToSendDelegate?.Invoke(video);
    }

    // public void WatchVideo(Video video){
    //     platformToSendDelegate?.Invoke(video);
    // }

    
}

public class Video{
    internal string name = "";
    internal float length;

    public Video(string name, float length){
        this.name = name;
        this.length = length;
    }

}