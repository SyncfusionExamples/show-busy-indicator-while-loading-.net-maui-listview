using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class BookInfoViewModel:INotifyPropertyChanged
    {
        #region Fields

        public ObservableCollection<BookInfo> BookInfo { get; set; }
        private bool isLoading = false;

        #endregion

        #region Properties

        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                this.isLoading = value;
                OnPropertyChanged("IsLoading");
            }
        }

        #endregion

        #region Constructor

        public BookInfoViewModel()
        {
            BookInfo = new ObservableCollection<BookInfo>();           
        }

        #endregion

        #region Private Methods

        public void GenerateItems()
        {
            BookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is the de facto programming paradigm for many programming languages Microsoft Visual Studio 2015 is the new version of the widely-used integrated development environment for building modern." });
            BookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions in your .NET applications, Neural networks are an exciting field of software development used to calculate outputs from input data" });
            BookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You’ll learn several different approaches to applying machine learning" });
            BookInfo.Add(new BookInfo() { BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development" });
            BookInfo.Add(new BookInfo() { BookName = "Visual Studio Code", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming" });
            BookInfo.Add(new BookInfo() { BookName = "Android Programming", BookDescription = "It is provides a useful overview of the Android application life cycle" });
            BookInfo.Add(new BookInfo() { BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone" });
            BookInfo.Add(new BookInfo() { BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment" });
            BookInfo.Add(new BookInfo() { BookName = "Xamarin.Forms", BookDescription = "Its creates mappings from its C# classes and controls directly" });
            BookInfo.Add(new BookInfo() { BookName = "Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development.Learn the basics of Windows Services and how to develop and deploy basic apps with Author by José Roberto Olivas Mendoza." });
            BookInfo.Add(new BookInfo() { BookName = "Agile Software Development", BookDescription = "Learning new development processes can be difficult, but switching to Agile doesn’t need to be complicated." });
            BookInfo.Add(new BookInfo() { BookName = "Assembly Language", BookDescription = "Assembly language is as close to writing machine code as you can get without writing in pure hexadecimal." });
            BookInfo.Add(new BookInfo() { BookName = "Cryptography in .NET", BookDescription = "Cryptography is used throughout software to protect all kinds of information, from emails, to passwords to credit card data." });
           BookInfo.Add(new BookInfo() { BookName = "Entity Framework Code First", BookDescription = "Follow author Ricardo Peres as he introduces the newest development mode for Entity Framework, Code First." });
            BookInfo.Add(new BookInfo() { BookName = "Localization for .NET", BookDescription = "Learn to write applications that support different languages and cultures, with an emphasis on .NET development" });
            BookInfo.Add(new BookInfo() { BookName = "Developing Windows Services", BookDescription = "Learn the basics of Windows Services and how to develop and deploy basic apps with Author by José Roberto Olivas Mendoza." });
            BookInfo.Add(new BookInfo() { BookName = "Data Structures", BookDescription = "Data Structures is your concise guide to skip lists, hash tables, heaps, priority queues, AVL trees." });
            BookInfo.Add(new BookInfo() { BookName = " Objective-C", BookDescription = "Objective-C is the only book you need for getting started with Objective-C—the primary language." });
            BookInfo.Add(new BookInfo() { BookName = " SciPy Programming", BookDescription = "James McCaffrey’s SciPy Programming offers readers a quick, thorough grounding in knowledge of the Python." });
            BookInfo.Add(new BookInfo() { BookName = "Python Succinctly", BookDescription = "Author Jason Cannon will guide to learn to use the Python language to create programs of all kinds." });
        }



        #endregion

        #region Interface Methods

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
