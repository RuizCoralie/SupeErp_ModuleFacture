using ModuleFactureUserControl.Helpers;

namespace ModuleFactureUserControl.ViewModel
{
    public class AjoutModifLigneCommandeViewModel : NotificationObject
    {
        #region Fields
        private bool _AllProductsIsChecked;

        public bool AllProductsIsChecked
        {
            get { return _AllProductsIsChecked; }
            set 
            { 
                _AllProductsIsChecked = value;
                RaisePropertyChanged("AllProductsIsChecked");
            }
        }

        private string _PrixMin;

        public string PrixMin
        {
            get { return _PrixMin; }
            set 
            { 
                _PrixMin = value;
                RaisePropertyChanged("PrixMin");
            }
        }

        private string _PrixMax;

        public string PrixMax
        {
            get { return _PrixMax; }
            set 
            { 
                _PrixMax = value;
                RaisePropertyChanged("PrixMax");
            }
        }
        
        #endregion

        #region Initialisation
        public AjoutModifLigneCommandeViewModel()
        {
            AllProductsIsChecked = false;
        }
        #endregion


        #region Methods
        private void FilterCommandHandler()
        {
            
        }
        private void CancelCommandHandler()
        {
            
        }

        private void ComfirmCommandHandler()
        {
           
        }
        #endregion

        #region Commands
        private RelayCommand _FilterCommand;

        public RelayCommand FilterCommand
        {
            get
            {
                if (_FilterCommand == null)
                    _FilterCommand = new RelayCommand((x) => FilterCommandHandler());
                return _FilterCommand;
            }
            set
            {
                _FilterCommand = value;
                RaisePropertyChanged("FilterCommand");
            }
        }

        private RelayCommand _CancelCommand;

        public RelayCommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new RelayCommand((x) => CancelCommandHandler());
                return _CancelCommand;
            }
            set
            {
                _CancelCommand = value;
                RaisePropertyChanged("CancelCommand");
            }
        }

        
        private RelayCommand _ComfirmCommand;

        public RelayCommand ComfirmCommand
        {
            get
            {
                if (_ComfirmCommand == null)
                    _ComfirmCommand = new RelayCommand((x) => ComfirmCommandHandler());
                return _ComfirmCommand;
            }
            set
            {
                _ComfirmCommand = value;
                RaisePropertyChanged("ComfirmCommand");
            }
        }
    
        #endregion

    }
}
