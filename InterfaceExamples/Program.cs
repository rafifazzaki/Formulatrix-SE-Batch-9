using System.Diagnostics;

class Program{
    static void Main(){
        ApplePhoneProMax2024 applePhoneProMax2024 = new();
        IBluetooth bluetoothDevice = applePhoneProMax2024; //yang lebih lengkap bisa masuk ke yang lebih sedikit
    }
}

public enum ChargerType{
    TypeC,
    TypeB,
    Lightning
}

public interface ICommunicationFunctionality{
    void TextMessage();
    void Call();
}
public interface IElectronic{
    void charge();
}

public interface IWireless{
    void Connect();
    void Disconnect();
}

public interface IBluetooth{
    void BTConnect();
    void BTDisconnect();
}


public interface IPhone : ICommunicationFunctionality, IElectronic, IWireless, IBluetooth {
    public string Screen {get;}
    public string Processor {get;}
    public int Ram {get;}
}

public class BluetoothSpeaker : IBluetooth,IElectronic
{
    ChargerType chargerType;
    public void BTConnect()
    {
        //..
    }

    public void BTDisconnect()
    {
        //..
    }

    public void charge()
    {
        chargerType = ChargerType.TypeB;
    }
}

public abstract class ApplePhone : IPhone
{
    ChargerType chargerType;

    public string Screen {get; private set;}

    public string Processor {get; private set;}

    public int Ram {get; private set;}

    public ApplePhone(){
        Screen = "micro Oled";
        Processor = "M2";
        Ram = 16;
    }

    public void BTConnect()
    {
        //..
    }

    public void BTDisconnect()
    {
        //..
    }

    public void Call()
    {
        //..
    }

    public void charge()
    {
        chargerType = ChargerType.Lightning;
    }

    public void Connect()
    {
        //..
    }

    public void Disconnect()
    {
        //..
    }

    public void TextMessage()
    {
        //..
    }
}
public abstract class AndroidPhone : IPhone
{
    public string Screen {get; private set;}

    public string Processor {get; private set;}

    public int Ram {get; private set;}

    public AndroidPhone(){
        Screen = "micro Oled";
        Processor = "M2";
        Ram = 16;
    }
    ChargerType chargerType;
    public void BTConnect()
    {
        //..
    }

    public void BTDisconnect()
    {
        //..
    }

    public void Call()
    {
        //..
    }

    public void charge()
    {
        chargerType = ChargerType.TypeC;
    }

    public void Connect()
    {
        //..
    }

    public void Disconnect()
    {
        //..
    }

    public void TextMessage()
    {
        //..
    }
}




class ApplePhoneProMax2024 : ApplePhone{

}
class XiaomiRedmiNote20 : AndroidPhone{

}
class POCO7 : AndroidPhone{

}




public class PhoneWareHouse{
    private IPhone[] phones;

    public void AddPhones(){

    }
}

public class BluetoothDeviceWareHouse{
    private IBluetooth[] bluetoothDevices;

    public void AddBluetoothDevices(){

    }
}
