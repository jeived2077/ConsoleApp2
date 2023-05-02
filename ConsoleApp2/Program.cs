using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Class3
    {
    }
    public class Pokypatel
    {
        private string surname;
        private string name;
        private string patronymic;
        private string address;
        private string creditCardNumber;
        private string bankAccountNumber;
        public Pokypatel(string surname, string name, string patronymic, string address, string creditCardNumber, string bankAccountNumber)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.address = address;
            this.creditCardNumber = creditCardNumber;
            this.bankAccountNumber = bankAccountNumber;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPatronymic(string patronymic)
        {
            this.patronymic = patronymic;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetCreditCardNumber(string creditCardNumber)
        {
            this.creditCardNumber = creditCardNumber;
        }

        public void SetBankAccountNumber(string bankAccountNumber)
        {
            this.bankAccountNumber = bankAccountNumber;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPatronymic()
        {
            return patronymic;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetCreditCardNumber()
        {
            return creditCardNumber;
        }

        public string GetBankAccountNumber()
        {
            return bankAccountNumber;
        }

        public void Print()
        {
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Отчество: {patronymic}");
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Номер кредитной карты: {creditCardNumber}");
            Console.WriteLine($"Номер банковского счета: {bankAccountNumber}");
        }
        static void Main(string[] args)
        {
           Pokypatel [] pokypatels = new Pokypatel[4];

            
                pokypatels[0] = new Pokypatel("Karpov", "Oleg", "Olegovich", "Moscow", "1111 2222 3333 4444", "1234567890");
            pokypatels[1] = new Pokypatel("Petrov", "Petr", "Petrovich", "St. Petersburg", "5555 6666 7777 8888", "0987654321");
            pokypatels[2] = new Pokypatel("Sidorov", "Sidor", "Sidorovich", "Novosibirsk", "9999 0000 1111 2222", "1357902468");
            pokypatels[3] = new Pokypatel("Fedorov", "Alexey", "Vitalievich", "Kursk", "3333 4444 5555 6666", "4545454544");
            Console.WriteLine("Покупатели в алфавитном порядке");
            Array.Sort(pokypatels, (x, y) => string.Compare(x.GetSurname(), y.GetSurname()));
            
            //string sortName = Array.Sort(string.Compare(GetName(), pokypatels.GetName()));
            foreach (Pokypatel pokypatelprint in pokypatels)
            {
                pokypatelprint.Print();
                Console.WriteLine();
            }
            Console.WriteLine("Покупатели при номер карты с 1000 1000 1000 1000 до 5000 5000 5000 5000");
            //Array.Sort(pokypatels, (x, y) => x.GetCreditCardNumber().CompareTo("1000 1000 1000 1000") >= 0 && x.GetCreditCardNumber().CompareTo("5000 5000 5000 5000") <= 0);
            //Array.Sort(pokypatels, (x, y) => x.GetCreditCardNumber().Replace("1000 1000 1000 1000").CompareTo(y.GetCreditCardNumber()("5000 5000 5000 5000")));
            //var filtered = pokypatels.Where(x => x.GetCreditCardNumber().CompareTo("1000 1000 1000 1000") >= 0 && x.GetCreditCardNumber().CompareTo("5000 5000 5000 5000") <= 0);
            var filtered = pokypatels.Where(x => x.GetCreditCardNumber().CompareTo("1000 1000 1000 1000") >= 0 && x.GetCreditCardNumber().CompareTo("5000 5000 5000 5000") <= 0);
            foreach (Pokypatel filteredprint in filtered)
            {
                filteredprint.Print();
                Console.WriteLine();
            }




        }
    }



}

