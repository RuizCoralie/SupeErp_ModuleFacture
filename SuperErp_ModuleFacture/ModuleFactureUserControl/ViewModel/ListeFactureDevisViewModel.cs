using ModuleFactureUserControl.FacturationService;
using ModuleFactureUserControl.Helpers;
using ModuleFactureUserControl.Mapper;
using ModuleFactureUserControl.Model;
using ModuleFactureUserControl.View;
using ModuleFactureUserControl.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ModuleFactureUserControl.ViewModel
{
    public class ListeFactureDevisViewModel : NotificationObject
    {
        #region Properties

        private FacturationServiceClient FacturationService;

        #endregion Properties

        #region Initialisation

        public ListeFactureDevisViewModel()
        {
            IsBusy = true;
            FacturationService = new FacturationServiceClient();
            Task.Factory.StartNew(() =>
            {
                InitListFiltre();
                try
                {
                    var billsQuotationsService = FacturationService.GetListQuotation();
                    if (billsQuotationsService != null)
                    {
                        var billsQuotation = new List<BillQuotation>();
                        billsQuotationsService.ToList().ForEach(x => billsQuotation.Add(x.ToBillQuotation()));
                        BillsQuotations = new ObservableCollection<BillQuotation>(billsQuotation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }).ContinueWith((x) =>
            {
                IsBusy = false;
            });
        }

        #endregion Initialisation

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

        #endregion Filters

        private bool _IsBusy;

        public bool IsBusy
        {
            get { return _IsBusy; }
            set
            {
                _IsBusy = value;
                RaisePropertyChanged("IsBusy");
            }
        }

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

        #endregion Fields

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            });
        }

        private void CreateBillCommandHandler()
        {
            var datacontext = new FactureDevisEditionViewModel();
            var uc = new FactureDevisEdition();
            uc.DataContext = datacontext;
            var wnd = new WindowsSimple(uc);
            datacontext.CloseWindow += wnd.CloseWindowEvent;
            wnd.Height = 400;
            wnd.Width = 600;
            wnd.Show();
        }

        private void UpdateBillCommandHandler()
        {
            try
            {
                var billQuotationComplete = FacturationService.GetBillQuotation(SelectedBillQuotation.BillQuotation_Id);
                var selectedBillQuotation = billQuotationComplete.ToBillQuotation();

                var datacontext = new FactureDevisEditionViewModel(selectedBillQuotation);
                var uc = new FactureDevisEdition();
                uc.DataContext = datacontext;
                var wnd = new WindowsSimple(uc);
                datacontext.CloseWindow += wnd.CloseWindowEvent;
                wnd.Height = 400;
                wnd.Width = 600;
                wnd.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        #endregion Methods

        #region Commands

        private RelayCommand _FilterCommand;

        public ICommand FilterCommand
        {
            get
            {
                if (_FilterCommand == null)
                    _FilterCommand = new RelayCommand((x) => FilterCommandHandler());
                return _FilterCommand;
            }
        }

        private RelayCommand _PrintCommand;

        public ICommand PrintCommand
        {
            get
            {
                if (_PrintCommand == null)
                    _PrintCommand = new RelayCommand((x) => PrintCommandHandler());
                return _PrintCommand;
            }
        }

        private RelayCommand _ExportPdfCommand;

        public ICommand ExportPdfCommand
        {
            get
            {
                if (_ExportPdfCommand == null)
                    _ExportPdfCommand = new RelayCommand((x) => ExportPdfCommandHandler());
                return _ExportPdfCommand;
            }
        }

        private RelayCommand _ExportXlsCommand;

        public ICommand ExportXlsCommand
        {
            get
            {
                if (_ExportXlsCommand == null)
                    _ExportXlsCommand = new RelayCommand((x) => ExportXlsCommandHandler());
                return _ExportXlsCommand;
            }
        }

        private RelayCommand _CreateBillCommand;

        public ICommand CreateBillCommand
        {
            get
            {
                if (_CreateBillCommand == null)
                    _CreateBillCommand = new RelayCommand((x) => CreateBillCommandHandler());
                return _CreateBillCommand;
            }
        }

        private RelayCommand _UpdateBillCommand;

        public ICommand UpdateBillCommand
        {
            get
            {
                if (_UpdateBillCommand == null)
                    _UpdateBillCommand = new RelayCommand((x) => UpdateBillCommandHandler());
                return _UpdateBillCommand;
            }
        }

        #endregion Commands
    }
}