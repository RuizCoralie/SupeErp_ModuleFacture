using ModuleFactureUserControl.Helpers;
using ModuleFactureUserControl.FacturationService;
using ModuleFactureUserControl.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using ModuleFactureUserControl.Mapper;
using System.Threading.Tasks;
using System;
using ModuleFactureUserControl.Windows;
using ModuleFactureUserControl.View;

namespace ModuleFactureUserControl.ViewModel
{
    public class ListeFactureDevisViewModel : NotificationObject
    {
        #region Properties         
        private FacturationServiceClient FacturationService;
        #endregion

        #region Initialisation
        public ListeFactureDevisViewModel()
        {
            FacturationService = new FacturationServiceClient();
            Task.Factory.StartNew(() =>
            {
                InitListFiltre();
                try
                {
                    var billsQuotationsService = FacturationService.GetListQuotation();
                    if(billsQuotationsService!=null)
                    {
                        var billsQuotation = new List<BillQuotation>();
                        billsQuotationsService.ToList().ForEach(x =>billsQuotation.Add(x.ToBillQuotation()));
                        BillsQuotations = new ObservableCollection<BillQuotation>(billsQuotation);
                    }
                }
                catch (Exception)
                {                   
                    throw;
                }
            });
            
        }
        #endregion

        #region Fields
        #region Filters
        private string _NomClient;

        public string NomClient
        {
            get { return _NomClient; }
            set 
            { 
                _NomClient = value;
                RaisePropertyChanged("NomClient");
            }
        }
        private DateTime _DateFacturation;

        public DateTime DateFacturation
        {
            get { return _DateFacturation; }
            set 
            { 
                _DateFacturation = value;
                RaisePropertyChanged("DateFacturation");
            }
        }

        private string _NumFacture;

        public string NumFacture
        {
            get { return _NumFacture; }
            set 
            { 
                _NumFacture = value;
                RaisePropertyChanged("NumFacture");
            }
        }

        private BillQuotationType _Type;

        public BillQuotationType Type
        {
            get { return _Type; }
            set 
            { 
                _Type = value;
                RaisePropertyChanged("Type");
            }
        }

        private BillQuotationStatutEnum _Statut;

        public BillQuotationStatutEnum Statut
        {
            get { return _Statut; }
            set 
            { 
                _Statut = value;
                RaisePropertyChanged("Statut");
            }
        }
        

        private double _MontantMin;

        public double MontantMin
        {
            get { return _MontantMin; }
            set 
            { 
                _MontantMin = value;
                RaisePropertyChanged("MontantMin");
            }
        }

        private double _MontantMax;

        public double MontantMax
        {
            get { return _MontantMax; }
            set 
            { 
                _MontantMax = value;
                RaisePropertyChanged("MontantMax");
            }
        }

        private ObservableCollection<BillQuotationType> _AllType;

        public ObservableCollection<BillQuotationType> AllType
        {
            get 
            {
                if (_AllType == null)
                    _AllType = new ObservableCollection<BillQuotationType>();
                return _AllType; 
            }
            set 
            { 
                _AllType = value;
                RaisePropertyChanged("AllType");
            }
        }

        private ObservableCollection<BillQuotationStatutEnum> _AllStatut;

        public ObservableCollection<BillQuotationStatutEnum> AllStatut
        {
            get 
            {
                if (_AllStatut == null)
                    _AllStatut = new ObservableCollection<BillQuotationStatutEnum>();
                return _AllStatut; 
            }
            set 
            { 
                _AllStatut = value;
                RaisePropertyChanged("AllStatut");
            }
        }
        
        
        #endregion


        private ObservableCollection<BillQuotation> _BillsQuotations;

        public ObservableCollection<BillQuotation> BillsQuotations
        {
            get { return _BillsQuotations; }
            set 
            { 
                _BillsQuotations = value;
                RaisePropertyChanged("BillsQuotations");
            }
        }

        private BillQuotation _SelectedBillQuotation;

        public BillQuotation SelectedBillQuotation
        {
            get { return _SelectedBillQuotation; }
            set 
            { 
                _SelectedBillQuotation = value;
                RaisePropertyChanged("SelectedBillQuotation");
            }
        }
        
        #endregion

        #region Methods

        private void InitListFiltre()
        {
            AllType.Add(BillQuotationType.Facture);
            AllType.Add(BillQuotationType.Devis);

            AllStatut.Add(BillQuotationStatutEnum.Accepte);
            AllStatut.Add(BillQuotationStatutEnum.Annule);
            AllStatut.Add(BillQuotationStatutEnum.Emis);
            AllStatut.Add(BillQuotationStatutEnum.EnCoursDePaiement);
            AllStatut.Add(BillQuotationStatutEnum.EnCoursDeRedaction);
            AllStatut.Add(BillQuotationStatutEnum.Payee);
            AllStatut.Add(BillQuotationStatutEnum.Refuse);
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
            Task.Factory.StartNew(() =>
            {
                try
                {
                    //var billsQuotationsService = FacturationService.GetBillQuotation();
                    //if (billsQuotationsService != null)
                    //{
                    //    var billsQuotation = new List<BillQuotation>();
                    //    billsQuotationsService.ToList().ForEach(x => billsQuotation.Add(x.ToBillQuotation()));
                    //    BillsQuotations = new ObservableCollection<BillQuotation>(billsQuotation);
                    //}
                }
                catch (Exception)
                {

                    throw;
                }
            });
        }

        private void CreateBillCommandHandler()
        {
            var uc = new FactureDevisEdition();
            var wnd = new WindowsSimple(uc);
            wnd.Show();
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
