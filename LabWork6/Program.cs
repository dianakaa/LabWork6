using LabWork6;

Book book1 = new Book();
Book book2 = new Book("Евгений Онегин", "A.C. Пушкин", 568);
Book book3 = new Book("Собачье cердце", "М.А. Булгаков", 889);

book1.Print();
book2.Print();
book3.Print();

Console.WriteLine(book2["name"]);
Console.WriteLine(book2["price"]);
Console.WriteLine(book3["author"]);
Console.WriteLine(book3[300]);

Console.WriteLine($"Периметр квадрата: {Geometry.Perimeter(2)}");
Console.WriteLine($"Периметр квадрата: {Geometry.Perimeter(2, 3)}");