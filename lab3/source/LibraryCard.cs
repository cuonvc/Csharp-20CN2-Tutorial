namespace source; 

public class LibraryCard : CommonObject {
    private DateTime dateReceive;
    private DateTime expireDate;
    private string bookId;

    public LibraryCard() {
    }

    public LibraryCard(DateTime dateReceive, DateTime expireDate, string bookId) : base() {
        this.dateReceive = dateReceive;
        this.expireDate = expireDate;
        this.bookId = bookId;
    }

    public void setDateReceive(DateTime dateTime) {
        dateReceive = dateTime;
    }

    public DateTime getDateReceive() {
        return dateReceive;
    }

    public void setExpireDate(DateTime dateTime) {
        expireDate = dateTime;
    }

    public DateTime getExpireDate() {
        return expireDate;
    }

    public void setBookId(string bookId) {
        this.bookId = bookId;
    }

    public string getBookId() {
        return bookId;
    }
}