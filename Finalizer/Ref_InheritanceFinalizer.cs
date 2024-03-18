namespace Finalizer;

class GrandParent{
    ~GrandParent() {
        System.Console.WriteLine("GrandParent's finalizer");
    }
}
class Parent : GrandParent {
    ~Parent() {
        System.Console.WriteLine("Parent's finalizer");
    }
}
class Child : Parent {
    ~Child() {
        System.Console.WriteLine("Child's finalizer");
    }
}
// class Program {
//     static void Main() {
//         InstanceCreator();
//         GC.Collect(); //Halt/Freeze
//         System.Console.WriteLine("Press any key to exit");
//         System.Console.ReadLine();
//     }
//     static void InstanceCreator() {
//         Child child = new Child();
//     }
// }