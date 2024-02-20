// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program{
    static void Main(){
        Employee rafif = new Employee("rafif", 1223);
        rafif.email = "r@mail.com";

        Console.WriteLine(rafif.id);

        Team teamTest = new Team("testTeam", rafif);

        Console.WriteLine(teamTest.emp.name);
    }
}

class Employee{
    public string name;
    public int id;
    public string email;

    public Employee(){
        name = "default";
        id = 0;
        email = "default@fmlx.com";
    }
    public Employee(string name, int id){
        this.name = name;
        this.id = id;
    }
    // constructor is to make an object, and to force input variable
    // overloading:same constructor/method but diff parameter
    public Employee(string name, int id,string email){
        this.name = name;
        this.id = id;
        this.email = email;
    }
}

class Team{
    public string name;
    public string division;

    public Employee emp;

    public Team(string name){
        this.name = name;
    }

    public Team(string name, Employee emp){
        this.name = name;
        this.emp = emp;
    }
}