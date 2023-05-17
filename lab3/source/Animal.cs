namespace source; 

public class Animal : CommonObject {
    private int age;
    private string source;
    private LevelProtected levelProtected;

    public Animal() {
    }

    public Animal(string name, int age, string source, LevelProtected levelProtected) : base(name) {
        this.age = age;
        this.source = source;
        this.levelProtected = levelProtected;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public int getAge() {
        return age;
    }

    public void setSource(string source) {
        this.source = source;
    }

    public string getSource() {
        return source;
    }

    public void setLevelProtected(LevelProtected levelProtected) {
        this.levelProtected = levelProtected;
    }

    public LevelProtected getLevelProtected() {
        return levelProtected;
    }
}

public enum LevelProtected {
    LOW = 1,
    NOMAL = 2,
    WARNING = 3
}