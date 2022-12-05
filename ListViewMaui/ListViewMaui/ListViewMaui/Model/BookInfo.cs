using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class BookInfo:INotifyPropertyChanged
    {
        #region Fields

        private string bookname;

        private string bookDescription;

        #endregion

        #region Constructor

        public BookInfo()
        {
           
        }
        
        #endregion

        #region Properties

        public string BookName
        {
            get { return bookname; }
            set
            {
                this.bookname = value;
                OnPropertyChanged("BookName");
            }
        }

        public string BookDescription
        {
            get { return bookDescription; }
            set
            {
                this.bookDescription = value;
                OnPropertyChanged("BookDescription");
            }
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
