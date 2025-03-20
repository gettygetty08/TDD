using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class Form1ViewModel : INotifyPropertyChanged
    {

        private IDB _db;

        public Form1ViewModel(IDB db)
        {
            _db = db;
        }

        private string _aTextBoxText = string.Empty;
        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set
            {
                if (_aTextBoxText == value) return;

                _aTextBoxText = value;
                OnPropertyChanged("ATextBoxText");
            }
            
        }

        private string _bTextBoxText = string.Empty;
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set
            {
                if (_bTextBoxText == value) return;

                _bTextBoxText = value;
                OnPropertyChanged("BTextBoxText");
            }

        }
        private string _resultLabelText = string.Empty;
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set
            {
                if (_resultLabelText == value) return;

                _resultLabelText = value;
                OnPropertyChanged("ResultLabelText");
            }

        }




        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void CalculationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);


            int dbValue = _db.GetDBValue();
            ResultLabelText = (Caluculation.Sum(a, b)+dbValue).ToString();

        }

        private string _productIdTextBoxText = string.Empty;
        public string ProductIdTextBoxText
        {
            get { return _productIdTextBoxText; }
            set
            {
                if (_productIdTextBoxText == value) return;

                _productIdTextBoxText = value;
                OnPropertyChanged("ProductIdTextBoxText");
            }

        }

        private string _productNameTextBoxText = string.Empty;
        public string ProductNameTextBoxText
        {
            get { return _productNameTextBoxText; }
            set
            {
                if (_productNameTextBoxText == value) return;

                _productNameTextBoxText = value;
                OnPropertyChanged("ProductNameTextBoxText");
            }

        }

        public void ProductCommand()
        {
            var product = _db.GetProduct();
            ProductIdTextBoxText = product.ProductId.ToString();
            ProductNameTextBoxText = product.ProductName;
        }

        public void Save()
        {
            _db.SaveProduct(new Product(Convert.ToInt32(ProductIdTextBoxText), ProductNameTextBoxText));
        }
    }
}
