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
using System.Windows.Media;

namespace ModuleFactureUserControl.ViewModel
{
    public class ListeFactureDevisViewModel : NotificationObject
    {
        #region Properties

        public static ObservableCollection<Status> StatusStatic;
        private FacturationServiceClient FacturationService;

        #endregion Properties

        #region Initialisation

        public ListeFactureDevisViewModel()
        {
            IsBusy = true;
            FacturationService = new FacturationServiceClient();
            StatusStatic = new ObservableCollection<Model.Status>();
            InitListFiltre();

            RefreshListQuotation();
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

        private DateTime? _DateFacturation;

        public DateTime? DateFacturation
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

        private Status _SelectedStatut;

        public Status SelectedStatut
        {
            get { return _SelectedStatut; }
            set
            {
                _SelectedStatut = value;
                RaisePropertyChanged("SelectedStatut");
            }
        }

        private double? _MontantMin;

        public double? MontantMin
        {
            get { return _MontantMin; }
            set
            {
                _MontantMin = value;
                RaisePropertyChanged("MontantMin");
            }
        }

        private double? _MontantMax;

        public double? MontantMax
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

        private ObservableCollection<Status> _Status;

        public ObservableCollection<Status> Status
        {
            get
            {
                if (_Status == null)
                    _Status = new ObservableCollection<Status>();
                return _Status;
            }
            set
            {
                _Status = value;
                StatusStatic = Status;
                RaisePropertyChanged("Status");
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

        private void RefreshListQuotation()
        {
            Task.Factory.StartNew(() =>
            {
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

            var status = new List<Status>();
            Task.Factory.StartNew(() =>
            {
                try
                {
                    var statusService = FacturationService.GetStatus();
                    if (statusService != null)
                    {
                        statusService.ToList().ForEach(x => status.Add(x.ToStatus()));
                    }
                }
                catch (Exception)
                {
                }
            }).ContinueWith((x) =>
            {
                Helpers.Helpers.DispatchService.Invoke(() => { Status = new ObservableCollection<Status>(status); });
            });
        }

        private void PrintCommandHandler(Visual visual)
        {
            System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();
            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {
                //Size pageSize = new Size(Printdlg.PrintableAreaWidth, Printdlg.PrintableAreaHeight);

                //visual.Measure(pageSize);
                //visual.Arrange(new Rect(5, 5, pageSize.Width, pageSize.Height));

                Printdlg.PrintVisual(visual, "Listes Factures / Devis");
            }
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
                    if (StatusStatic.Count != 0)
                    {
                        var billsQuotationsService = FacturationService.SearchBillQuotation(NomClient, NumFacture, DateFacturation, SelectedStatut.ToStatus(), Convert.ToInt32(MontantMin), Convert.ToInt32(MontantMax), Type == BillQuotationType.Facture);
                        if (billsQuotationsService != null)
                        {
                            var billsQuotation = new List<BillQuotation>();
                            billsQuotationsService.ToList().ForEach(x => billsQuotation.Add(x.ToBillQuotation()));
                            BillsQuotations = new ObservableCollection<BillQuotation>(billsQuotation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le service n'a pas encore répondu", "Info", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            });
        }

        private void CreateBillCommandHandler()
        {
            if (StatusStatic.Count != 0)
            {
                var datacontext = new FactureDevisEditionViewModel();
                var uc = new FactureDevisEdition();
                uc.DataContext = datacontext;
                var wnd = new WindowsSimple(uc);
                datacontext.CloseWindow += wnd.CloseWindowEvent;
                datacontext.RefreshListQuotationEvent += datacontext_RefreshListQuotationEvent;
                wnd.Height = 500;
                wnd.Width = 700;
                wnd.Show();
            }
        }

        private void datacontext_RefreshListQuotationEvent()
        {
            RefreshListQuotation();
        }

        private void UpdateBillCommandHandler()
        {
            try
            {
                if (StatusStatic.Count != 0)
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
                else
                {
                    MessageBox.Show("Le service n'a pas encore répondu", "Info", MessageBoxButtons.OK);
                }
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

        private RelayCommand<Visual> _PrintCommand;

        public ICommand PrintCommand
        {
            get
            {
                if (_PrintCommand == null)
                    _PrintCommand = new RelayCommand<Visual>((x) => PrintCommandHandler(x));
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