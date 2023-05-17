// See https://aka.ms/new-console-template for more information

using source;

public class Program {
    public static void Main() {

        Console.WriteLine("Nhap bai tap can thuc hien: \n1, 2, 3, 4 or 5");
        int exam = Convert.ToInt32(Console.ReadLine());
        switch (exam) {
            case 1:
                Console.WriteLine("Nhap so giay: ");
                int length = Convert.ToInt32(Console.ReadLine());

                Shoes[] arrayShoes = takeShoes(length);
                Console.WriteLine("\n============> Danh sach tat ca giay: ");
                showMultiShoes(arrayShoes);

                Console.Write("Danh sach vi tri giay: ");
                for (int i = 0; i < arrayShoes.Length; i++) {
                    Console.Write((i + 1) + ", ");
                }

                Console.WriteLine("\nNhap vi tri giay can so sanh: ");
                Console.WriteLine("vi tri doi thu nhat: ");
                int inde1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("vi tri doi thu hai: ");
                int index2 = Convert.ToInt32(Console.ReadLine());

                Shoes compareResult = heightCompare(arrayShoes[inde1 - 1], arrayShoes[index2 - 1]);
                if (compareResult.getId() == null) {
                    Console.WriteLine("Hai doi giay cao bang nhau");
                    Console.WriteLine("Doi thu nhat: ");
                    showShoesInfo(arrayShoes[inde1 - 1]);
                    Console.WriteLine("Doi thu hai: ");
                    showShoesInfo(arrayShoes[index2 - 1]);
                } else {
                    Console.WriteLine("Doi giay co chieu cao lon hon: ");
                    showShoesInfo(compareResult);
                }
                break;
            
            case 2:
                Console.WriteLine("Nhap so van dong vien: ");
                int numberGamers = Convert.ToInt32(Console.ReadLine());
                Gamer[] arrayGamers = takeGamers(numberGamers);
                
                Console.WriteLine("\nDanh sach van dong vien: ");
                showMultiGamers(arrayGamers);

                Gamer[] gamersSorted = sortAscByWeight(arrayGamers);
                Console.WriteLine("\nDanh sach van dong vien sau khi sap xep: ");
                showMultiGamers(gamersSorted);
                
                Console.WriteLine("\nVan dong vien cao nhat: ");
                Gamer byMaxHeight = arrayGamers.MaxBy(gamer => gamer.getHeight());
                showGamerInfo(byMaxHeight);
                
                break;
            
            case 3:
                Console.WriteLine("Nhap so luong dong vat: ");
                int numberAnimals = Convert.ToInt32(Console.ReadLine());
                Animal[] animals = takeAnimals(numberAnimals);
                
                Console.WriteLine("\nDanh sach dong vat: ");
                showMultiAnimals(animals);
                
                Console.WriteLine("\nDanh sach cac con vat co nguy co tuyet chung: ");
                Animal[] resAnimal = filterByWarningLevel(animals);
                showMultiAnimals(resAnimal);
                
                break;
            
            case 4:
                Console.WriteLine("Nhap so sinh vien: " );
                int numberStudents = Convert.ToInt32(Console.ReadLine());
                Student[] students = takeStudents(numberStudents);
                
                Console.WriteLine("\nDanh sach sinh vien: ");
                showMultiStudents(students);

                Student[] studentsSorted = sortStudents(students);
                Console.WriteLine("\nDanh sach sinh vien sau khi sap xep theo diem trung binh: ");
                showMultiStudents(studentsSorted);
                
                Console.WriteLine("\nDanh sach 10 ban co diem trung binh cao nhat: ");
                Student[] clone = new Student[2];
                Array.Copy(studentsSorted, clone, 2);  //2 cho don gian
                showMultiStudents(clone);
                
                break;
            
            case 5:
                Console.WriteLine("Nhap so the thu vien: ");
                int numberCards = Convert.ToInt32(Console.ReadLine());
                LibraryCard[] libraryCards = takeLibraryCards(numberCards);
                
                Console.WriteLine("\n==========> Danh sach the: ");
                showMultiCards(libraryCards);
                
                Console.WriteLine("Nhap ngay tra can tim: ");
                string stringFormat = Console.ReadLine();
                DateTime dateFormated = DateTime.Parse(stringFormat);
                LibraryCard[] cardsByExpire = filterByExpireDate(libraryCards, dateFormated);
                
                Console.WriteLine("\nDanh sach cac the co ngay het han '" + stringFormat + "' la:");
                showMultiCards(cardsByExpire);
                break;
        }
    }

    private static LibraryCard[] filterByExpireDate(LibraryCard[] libraryCards, DateTime expireDate) {
        List<LibraryCard> list = new List<LibraryCard>();
        for (int i = 0; i < libraryCards.Length; i++) {
            if (libraryCards[i].getExpireDate().Equals(expireDate)) {
                list.Add(libraryCards[i]);
            }
        }

        return list.ToArray();
    }

    private static void showMultiCards(LibraryCard[] libraryCards) {
        for (int i = 0; i < libraryCards.Length; i++) {
            Console.WriteLine("\nThong tin the thu " + (i + 1));
            showCardInfo(libraryCards[i]);
        }
    }

    private static void showCardInfo(LibraryCard libraryCard) {
        Console.WriteLine("Ma the: " + libraryCard.getId());
        Console.WriteLine("Ngay muon: " + libraryCard.getDateReceive());
        Console.WriteLine("Ngay tra: " + libraryCard.getExpireDate());
        Console.WriteLine("Ma sach: " + libraryCard.getBookId());
    }

    private static LibraryCard[] takeLibraryCards(int length) {
        LibraryCard[] array = new LibraryCard[length];
        for (int i = 0; i < length; i++) {
            Console.WriteLine("Nhap thong tin the thu " + (i + 1) + ": ");
            Console.WriteLine("Nhap ngay muon: ");
            string stringFormat = Console.ReadLine();
            DateTime dateFormat = DateTime.Parse(stringFormat);
            Console.WriteLine("Nhap ngay tra: ");
            string stringFormatExpire = Console.ReadLine();
            DateTime dateFormatExpire = DateTime.Parse(stringFormatExpire);
            Console.WriteLine("Nhap ma sach: ");
            string bookId = Console.ReadLine();

            array[i] = new LibraryCard(dateFormat, dateFormatExpire, bookId);
        }

        return array;
    }

    private static Student[] sortStudents(Student[] students) {
        for (int i = 0; i < students.Length - 1; i++) {
            for (int j = i; j < students.Length; j++) {
                Student caching = students[i];
                if (students[i].getAvg() < students[j].getAvg()) {
                    students[i] = students[j];
                    students[j] = caching;
                }
            }
        }

        return students;
    }

    private static void showMultiStudents(Student[] students) {
        for (int i = 0; i < students.Length; i++) {
            Console.WriteLine("Thong tin sinh vien thu: " + (i + 1));
            showStudentInfo(students[i]);
        }
    }

    private static void showStudentInfo(Student student) {
        Console.WriteLine("Ma sinh vien: " + student.getId());
        Console.WriteLine("Ho ten sinh vien: " + student.getName());
        Console.WriteLine("Ten lop: " + student.getClassName());
        Console.WriteLine("Ngay sinh: " + student.getDateOfBirth());
        Console.WriteLine("Diem trung binh: " + student.getAvg());
    }

    private static Student[] takeStudents(int length) {
        Student[] students = new Student[length];
        for (int i = 0; i < length; i++) {
            Console.WriteLine("\nNhap thong tin sinh vien thu " + (i + 1) + ": ");
            Console.WriteLine("Nhap ten sinh vien: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap ten lop: ");
            string className = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            string stringFormat = Console.ReadLine();
            DateTime dateTimeFormated = DateTime.Parse(stringFormat);
            Console.WriteLine("Nhap diem trung binh: ");
            double avg = Convert.ToDouble(Console.ReadLine());

            students[i] = new Student(name, className, dateTimeFormated, avg);
        }

        return students;
    }

    private static Animal[] filterByWarningLevel(Animal[] animals) {
        List<Animal> list = new List<Animal>();
        for (int i = 0; i < animals.Length; i++) {
            if (animals[i].getLevelProtected().Equals(LevelProtected.WARNING)) {
                list.Add(animals[i]);
            }
        }

        return list.ToArray();
    }

    private static void showMultiAnimals(Animal[] animals) {
        for (int i = 0; i < animals.Length; i++) {
            Console.WriteLine("===============> Thong tin con vat thu " + (i + 1) + ": ");
            showAnimalInfo(animals[i]);
        }
    }

    private static void showAnimalInfo(Animal animal) {
        Console.WriteLine("Ma con vat: " + animal.getId());
        Console.WriteLine("Ten con vat: " + animal.getName());
        Console.WriteLine("So tuoi: " + animal.getAge());
        Console.WriteLine("Nguon goc: " + animal.getSource());
        Console.WriteLine("Cap do bao ve: " + animal.getLevelProtected());
    }

    private static Animal[] takeAnimals(int length) {
        Animal[] array = new Animal[length];
        for (int i = 0; i < length; i++) {
            Console.WriteLine("Nhap thong tin con vat thu " + (i + 1) + ": ");
            Console.WriteLine("Nhap ten: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nguon goc: ");
            string src = Console.ReadLine();
            Console.WriteLine("Nhap cap do bao ve: 1, 2 or 3");
            int value = Convert.ToInt32(Console.ReadLine());
            LevelProtected levelProtected = (LevelProtected) value;

            array[i] = new Animal(name, age, src, levelProtected);
        }

        return array;
    }

    private static Gamer[] sortAscByWeight(Gamer[] array) {
        for (int i = 0; i < array.Length - 1; i++) {
            for (int j = i; j < array.Length; j++) {
                Gamer caching = array[i];
                if (array[i].getWeight() > array[j].getWeight()) {
                    array[i] = array[j];
                    array[j] = caching;
                }
            }
        }

        return array;
    }

    private static void showMultiGamers(Gamer[] array) {
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine("====================> Thong tin van dong vien so " + (i  + 1) + ": ");
            showGamerInfo(array[i]);
        }
    }

    private static void showGamerInfo(Gamer gamer) {
        Console.WriteLine("Ma so van dong vien: " + gamer.getId());
        Console.WriteLine("Ho va ten: " + gamer.getName());
        Console.WriteLine("Tuoi: " + gamer.getAge());
        Console.WriteLine("Mon thi dau: " + gamer.getEventName());
        Console.WriteLine("Chieu cao: " + gamer.getHeight());
        Console.WriteLine("Can nang: " + gamer.getWeight());
    }

    private static Gamer[] takeGamers(int length) {
        Gamer[] array = new Gamer[length];
        for (int i = 0; i < length; i++) {
            Console.WriteLine("Nhap thong van dong vien thu " + (i + 1) + ": ");
            Console.WriteLine("Nhap ten: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mon thi dau: ");
            string eventName = Console.ReadLine();
            Console.WriteLine("Nhap chieu cao: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap can nang: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            array[i] = new Gamer(name, age, eventName, height, weight);
        }
        

        return array;
    }
    
    private static Shoes heightCompare(Shoes shoes1, Shoes shoes2) {
        if (shoes1.getHeight() > shoes2.getHeight()) {
            return shoes1;
        } else if (shoes1.getHeight() < shoes2.getHeight()) {
            return shoes2;
        } else {
            return new Shoes();
        }
    }

    private static void showShoesInfo(Shoes shoes) {
        Console.WriteLine("Ma san pham: " + shoes.getId());
        Console.WriteLine("Thuong hieu: " + shoes.getName());
        Console.WriteLine("Chat lieu: " + shoes.getMaterial());
        Console.WriteLine("Chieu cao: " + shoes.getHeight());
        Console.WriteLine("Gia tien: " + shoes.getPrice());
    }

    private static void showMultiShoes(Shoes[] shoesArray) {
        for (int i = 0; i < shoesArray.Length; i++) {
            Console.WriteLine("====================> Thong tin doi thu " + (i  + 1) + ": ");
            showShoesInfo(shoesArray[i]);
        }
    }

    private static Shoes[] takeShoes(int length) {
        Shoes[] array = new Shoes[length];
        for (int i = 0; i < length; i++) {
            Console.WriteLine("Nhap thong tin doi thu " + (i + 1) + ": ");
            Console.WriteLine("Nhap thuong hieu: ");
            string brand = Console.ReadLine();
            Console.WriteLine("Nhap chat lieu: ");
            string material = Console.ReadLine();
            Console.WriteLine("Nhap chieu cao: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia: ");
            long price = Convert.ToInt64(Console.ReadLine());

            array[i] = new Shoes(brand, material, height, price);
        }
        

        return array;
    }
    
    
}