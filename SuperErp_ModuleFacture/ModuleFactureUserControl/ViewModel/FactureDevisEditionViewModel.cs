using ModuleFactureUserControl.Helpers;

namespace ModuleFactureUserControl.ViewModel
{
    public class FactureDevisEditionViewModel : NotificationObject
    {
        #region Methods
        private void RemoveLineCommandHandler()
        {
           
        }
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

        private void AddLineCommandHandler()
        {
        }

        private void UpdateLineCommandHandler()
        {

        }

        private void SaveBillCommandHandler()
        {
            
        }
        private void CancelCommandHandler()
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

        private RelayCommand _AddLineCommand;

        public RelayCommand AddLineCommand
        {
            get
            {
                if (_AddLineCommand == null)
                    _AddLineCommand = new RelayCommand((x) => AddLineCommandHandler());
                return _AddLineCommand;
            }
            set
            {
                _AddLineCommand = value;
                RaisePropertyChanged("AddLineCommand");
            }
        }

        private RelayCommand _UpdateLineCommand;

        public RelayCommand UpdateLineCommand
        {
            get
            {
                if (_UpdateLineCommand == null)
                    _UpdateLineCommand = new RelayCommand((x) => UpdateLineCommandHandler());
                return _UpdateLineCommand;
            }
            set
            {
                _UpdateLineCommand = value;
                RaisePropertyChanged("UpdateLineCommand");
            }
        }
        private RelayCommand _RemoveLineCommand;

        public RelayCommand RemoveLineCommand
        {
            get
            {
                if (_RemoveLineCommand == null)
                    _RemoveLineCommand = new RelayCommand((x) => RemoveLineCommandHandler());
                return _RemoveLineCommand;
            }
            set
            {
                _RemoveLineCommand = value;
                RaisePropertyChanged("RemoveLineCommand");
            }
        }

        private RelayCommand _SaveBillCommand;

        public RelayCommand SaveBillCommand
        {
            get
            {
                if (_SaveBillCommand == null)
                    _SaveBillCommand = new RelayCommand((x) => SaveBillCommandHandler());
                return _SaveBillCommand;
            }
            set
            {
                _SaveBillCommand = value;
                RaisePropertyChanged("SaveBillCommand");
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
        
        #endregion
    }
}
