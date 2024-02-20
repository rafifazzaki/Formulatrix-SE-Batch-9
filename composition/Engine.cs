namespace Vehicle;

class Engine{
    public int cylinder;
    public string construction;

    public string cooling;

    public string manufacture;
    
    public Engine(int cylinder, string construction, string cooling){
        this.cylinder = cylinder;
        this.construction = construction;
        this.cooling = cooling;
    }
}