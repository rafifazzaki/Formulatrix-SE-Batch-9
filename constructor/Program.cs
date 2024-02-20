// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

class Program{
    static void Main(){
        Employee rafif = new Employee("rafif", 1223);
        rafif.email = "r@mail.com";

        Console.WriteLine(rafif.id);

        Team teamTest = new Team("testTeam");

        Console.WriteLine(teamTest.emp.name);

    }
}

class Employee{
    public string name;
    public int id;
    public string email;

    public Employee(string name, int id){
        this.name = name;
        this.id = id;
    }
}

class Team{
    public string name;
    public string division;

    public Employee emp;

    public Team(string name){
        this.name = name;

        emp = new Employee("test", 111);
    }
}