public interface IAnimal {
    void Walk();
    void Breath();
    void Sound();
}

public interface IJump{
    void Jump();
}

public interface IRun{
    void Run();
}

public abstract class LandAnimal : IAnimal
{
    // LandAnimal untuk Breath dan Walk sama, (ex. cat, dog, kukang, monkey) tapi suaranya beda"
    public void Breath()
    {
        //..
    }
    public void Walk()
    {
        // ..
    }
    public abstract void Sound(); //pakai abstract karena pasti ada suara, tapi berbeda"
}


public class Cat : LandAnimal, IJump, IRun { //inherit to one parent, but has multiple contract
    public void Jump()
    {
        // ..
    }
    public void Run()
    {
        // ..
    }
    public override void Sound()
    {
        // ..
    }
}