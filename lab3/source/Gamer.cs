namespace source; 

public class Gamer : CommonObject {

    private int age;
    private string eventName;
    private Double height;
    private Double weight;

    public Gamer() {
    }

    public Gamer(string name, int age, string eventName, double height, double weight) : base(name) {
        this.age = age;
        this.eventName = eventName;
        this.height = height;
        this.weight = weight;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public int getAge() {
        return age;
    }
    
    public void setEventName(string eventName) {
        this.eventName = eventName;
    }

    public string getEventName() {
        return eventName;
    }

    public void setHeight(float height) {
        this.height = height;
    }

    public double getHeight() {
        return height;
    }

    public void setWeight(float weight) {
        this.weight = weight;
    }

    public double getWeight() {
        return weight;
    }
}