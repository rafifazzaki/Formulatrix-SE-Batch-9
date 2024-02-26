class Program{
    static void Main(){
        SMS sms = new();
        Email email = new();

        Publisher pub = new();

        // tanpa event, bisa jadi ngga sengaja semuanya ngga kepanggil gara-gara terakhir ke replace =
        pub.mySubscriber = sms.Notification;
        pub.mySubscriber += email.Notification;
        pub.mySubscriber = null;

        // dengan event, dipaksa semuanya nambah atau ngurangin delegate (action dan func ya delegate)
        pub.mySubscriberEvent += sms.Notification;
        pub.mySubscriber += email.Notification;

    }
}

class Publisher{
    public Action mySubscriber;
    public event Action mySubscriberEvent;
    public void Upload(){
        Console.WriteLine("Uploading...");
        Console.WriteLine("Finish...");
        Console.WriteLine("Inform to subscriber");
        Notify();
    }
    public void Notify(){
        mySubscriber.Invoke();
        mySubscriberEvent.Invoke();
    }
}

class SMS{
    public void Notification(){}
}
class Email{
    public void Notification(){}
}