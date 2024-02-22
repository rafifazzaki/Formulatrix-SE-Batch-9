public interface IHuman{
    //if you set here, the set must be public!
    int Balance {get;} //readonly
}

class Human : IHuman{
    public int Balance {get; private set;}
}

public class ReadonlyAndConst
{
    public readonly int Balance; //hanya bisa di isi saat constructor
    const int Money = 100; //sifatnya static

}
