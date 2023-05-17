namespace source; 

public class Shoes : CommonObject {

    private string material;
    private int height;
    private long price;

    public Shoes() {
    }

    public Shoes(string name, string material, int height, long price) : base(name) {
        this.name = name;
        this.material = material;
        this.height = height;
        this.price = price;
    }

    public void setMaterial(string material) {
        this.material = material;
    }

    public string getMaterial() {
        return material;
    }

    public void setHeight(int height) {
        this.height = height;
    }

    public int getHeight() {
        return height;
    }

    public void setPrice(long price) {
        this.price = price;
    }

    public long getPrice() {
        return price;
    }
}