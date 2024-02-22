
// enum behaviour -> bisa di assign angka yang sama, dan setelah angka yg di assign bakal lanjut + 1
public enum Days{
    Monday = 4,
    Tuesday, // -> kalau tidak diassign bakalan jadi 5
    Wednesday, //lanjut 6
    Thursday = 100,
    Friday, // -> lanjut 101
    Saturday = 100, // bisa, tapi kalau dipanggil dari int ke enum lagi hanya akan ngambil yang pertama
    Sunday
}
public enum StatusCode : int { //bisa diganti ke short, byte dan bbrp type lainnya 
	NotFound = 404,
	Redirect = 300,
	Unauthorized = 401,
	InternalServerError = 500,
	OK = 200
}

public class enumExample
{
    void GetAllEnumList(){
        short x = 404;
        StatusCode code = (StatusCode)x;


        var result = Enum.GetValues(typeof(StatusCode)); //aslinya typenya array. akan mengembalikan "OK" duluan karena angka terkecil
    }
}
