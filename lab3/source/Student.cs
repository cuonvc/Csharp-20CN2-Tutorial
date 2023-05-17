namespace source; 

public class Student : CommonObject {
    
    private string className;
    private DateTime dateOfBirth;
    private Double avg;

    public Student() {
    }

    public Student(string name, string className, DateTime dateOfBirth, double avg) : base(name) {
        this.className = className;
        this.dateOfBirth = dateOfBirth;
        this.avg = avg;
    }

    public void setClassName(string className) {
        this.className = className;
    }

    public string getClassName() {
        return className;
    }

    public void setDateOfBirth(DateTime dateOfBirth) {
        this.dateOfBirth = this.dateOfBirth;
    }

    public DateTime getDateOfBirth() {
        return dateOfBirth;
    }

    public void setAvg(double avg) {
        this.avg = avg;
    }

    public Double getAvg() {
        return avg;
    }
}