using ModuleFactureUserControl.Helpers;
using ModuleFactureUserControl.FacturationService;

namespace ModuleFactureUserControl.ViewModel
{
    public class ListeFactureDevisViewModel : NotificationObject
    {
        #region Initialisation
        public ListeFactureDevisViewModel()
        {
            FacturationServiceClient FacturationService = new FacturationServiceClient();
            
        }
        #endregion

        #region Methods
        private void PrintCommandHandler()
        {
        }

        private void ExportPdfCommandHandler()
        {
            
        }

        private void ExportXlsCommandHandler()
        {
            
        }

        private void FilterCommandHandler()
        {
            
        }

        private void CreateBillCommandHandler()
        {
        }

        private void UpdateBillCommandHandler()
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

        private RelayCommand _PrintCommand;

        public RelayCommand PrintCommand
        {
            get
            {
                if (_PrintCommand == null)
                    _PrintCommand = new RelayCommand((x) => PrintCommandHandler());
                return _PrintCommand;
            }
            set
            {
                _PrintCommand = value;
                RaisePropertyChanged("PrintCommand");
            }
        }

        

        private RelayCommand _ExportPdfCommand;

        public RelayCommand ExportPdfCommand
        {
            get
            {
                if (_ExportPdfCommand == null)
                    _ExportPdfCommand = new RelayCommand((x) => ExportPdfCommandHandler());
                return _ExportPdfCommand;
            }
            set
            {
                _ExportPdfCommand = value;
                RaisePropertyChanged("ExportPdfCommand");
            }
        }


        private RelayCommand _ExportXlsCommand;

        public RelayCommand ExportXlsCommand
        {
            get
            {
                if (_ExportXlsCommand == null)
                    _ExportXlsCommand = new RelayCommand((x) => ExportXlsCommandHandler());
                return _ExportXlsCommand;
            }
            set
            {
                _ExportXlsCommand = value;
                RaisePropertyChanged("ExportXlsCommand");
            }
        }

        private RelayCommand _CreateBillCommand;

        public RelayCommand CreateBillCommand
        {
            get
            {
                if (_CreateBillCommand == null)
                    _CreateBillCommand = new RelayCommand((x) => CreateBillCommandHandler());
                return _CreateBillCommand;
            }
            set
            {
                _CreateBillCommand = value;
                RaisePropertyChanged("CreateBillCommand");
            }
        }

        private RelayCommand _UpdateBillCommand;

        public RelayCommand UpdateBillCommand
        {
            get
            {
                if (_UpdateBillCommand == null)
                    _UpdateBillCommand = new RelayCommand((x) => UpdateBillCommandHandler());
                return _UpdateBillCommand;
            }
            set
            {
                _UpdateBillCommand = value;
                RaisePropertyChanged("UpdateBillCommand");
            }
        }

        #endregion
    }
}
