public enum ChargerType{
    TypeC,
    TypeB,
    Lightning
}
class Program{
    static void Main(){
        ApplePhoneProMax2024 applePhoneProMax2024 = new();
        IBluetooth bluetoothDevice = applePhoneProMax2024; //yang lebih lengkap bisa masuk ke yang lebih sedikit
    }
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


public interface IPhone : ICommunicationFunctionality, IElectronic, IWireless, IBluetooth {}

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
