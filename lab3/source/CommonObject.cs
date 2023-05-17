namespace source; 

public class CommonObject {

    protected static int countId = 1;
    protected string id;
    protected string name;

    public CommonObject() {
    }

    public CommonObject(string name) {
        id = autoIncrementId();
        this.name = name;
    }

    public string autoIncrementId() {
        return "ID_" + countId++;
    }

    public string getId() {
        return id;
    }

    public void setName(string name) {
        this.name = name;
    }

    public string getName() {
        return name;
    }
}