//Задание 1 и 2
namespace LabWork6
{
    class Book
    {
        private string _name;
        private string _author;
        private int _price;

        #region  Перегрузка конструкторов
        public Book() : this("Неизвестно", "Неизвестно", 0) { }

        public Book(string name, string author, int price)
        {
            _name = name;
            _author = author;
            _price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Название: {_name}, Автор: {_author}, Цена: {_price}");
        }

        public string Author
        {
            get
            {
                return _author;
            }
        }

        public bool Price(int minPrice, int maxPrice)
        {
            return (_price >= minPrice && _price <= maxPrice);
        }
        #endregion

        #region Перегрузка индексаторов
        public object? this[string index]
        {
            get
            {
                return index switch
                {
                    "name" => _name,
                    "author" => _author,
                    "price" => Convert.ToString(_price),
                    _ => null
                };
            }
        }

        public char this[int index]
        {
            get
            {
                if (index >=0 && index < _name.Length) 
                {
                    return _name[index];
                }
                else
                {
                    return '\0';
                }
            }
        }
        #endregion
    }
}
