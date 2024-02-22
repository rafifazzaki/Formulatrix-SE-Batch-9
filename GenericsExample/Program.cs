

class Program{
    static void Main(){
        var myCollection = new MyCollection<int, string>(20); //menentukan generics sebagai int & string
        myCollection.Add(10, "ten");
        myCollection.Add(13, "thirteen");


        // tuple maximal 8, and not a good practice
        (int, string) myTuple = myCollection.GetLastElementWithTuple(); //don't use tuple
        //myTuple.Item1
        Data<int, string> data = myCollection.GetLastElement();
        // data.data;
        // data.data2;
    }
}

class MyCollection<T, T2>{ //generics masih bebeas tp harus ditentukan nanti pas dipanggil
    private T[] firstCollection;
    private T2[] secondCollection;
    private int index = 0;

    public MyCollection(int lastIndex){
        firstCollection = new T[lastIndex];
        secondCollection = new T2[lastIndex];
    }

    public void Add(T data, T2 data2){
        firstCollection[index] = data;
        secondCollection[index] = data2;
        index++;
    }

    //This is Tuple, it's simple but DO NOT USE (the tuple is returning 2 value at once) 
    public (T, T2) GetLastElementWithTuple(){
        return (firstCollection[index-1], secondCollection[index-1]);
    }

    public Data<T, T2> GetLastElement(){
        return new Data<T, T2>(firstCollection[index-1], secondCollection[index-1]);
    }
}

class Data<T, T2>{
    public T data;
    public T2 data2;

    public Data(T data, T2 data2){
        this.data = data;
        this.data2 = data2;
    }
}
