using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {



        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library(List<Book> books,string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public Library() { }

        public override string ToString()
        {
            string booksinlibrary = "";
            foreach (Book book in Books)
            {
                booksinlibrary += book + "\n";
            }
            return string.Format("\nBooks in Library: {0}\nLibrary Name: {1}\nStreet Address: {2}\nCity :{3}\nState: {4}\nZip :{5}",
                booksinlibrary,
                LibraryName,
                StreetAddress,
                City,
                State,
                Zip);
        }
    }
}
