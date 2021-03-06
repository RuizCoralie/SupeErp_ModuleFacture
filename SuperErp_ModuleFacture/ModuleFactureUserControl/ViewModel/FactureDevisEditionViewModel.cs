﻿using ModuleFactureUserControl.FacturationService;
using ModuleFactureUserControl.Helpers;
using ModuleFactureUserControl.Mapper;
using ModuleFactureUserControl.Model;
using ModuleFactureUserControl.View;
using ModuleFactureUserControl.Windows;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ModuleFactureUserControl.ViewModel
{
    public class FactureDevisEditionViewModel : NotificationObject
    {
        #region Events

        public event Action CloseWindow;

        public event Action RefreshListQuotationEvent;

        #endregion Events

        #region Properties

        private FacturationServiceClient FacturationService;

        private ClientService.ServiceGestionClientClient ServiceGestionClient;

        #endregion Properties

        #region Initialisation

        public FactureDevisEditionViewModel()
        {
            FacturationService = new FacturationServiceClient();
            ServiceGestionClient = new ClientService.ServiceGestionClientClient();
            IsNewBillQuotation = true;
            RefreshStatus();

            Task.Factory.StartNew(() =>
            {
                InitListFiltre();
                try
                {
                    //Transmitter
                    var transmitter = FacturationService.GetTransmitter();
                    if (transmitter != null)
                    {
                        Helpers.Helpers.DispatchService.Invoke(() =>
                            {
                                transmitter.ToList().ForEach(x => AllTransmitter.Add(x.ToTransmitter()));
                            });
                    }

                    //Company
                    var company = ServiceGestionClient.GetListCompany();
                    if (company != null)
                    {
                        Helpers.Helpers.DispatchService.Invoke(() =>
                            {
                                company.ToList().ForEach(x => AllCompany.Add(x.ToCompanyClient()));
                            });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            });
        }

        public FactureDevisEditionViewModel(BillQuotation billQuotation)
        {
            FacturationService = new FacturationServiceClient();
            ServiceGestionClient = new ClientService.ServiceGestionClientClient();
            IsNewBillQuotation = false;
            //RefreshStatus();
            BillQuotation = billQuotation;
            TotalHT = BillQuotation.AmountDF;
            TotalTTC = BillQuotation.AmountTTC;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    //Transmitter
                    var transmitter = FacturationService.GetTransmitter();
                    if (transmitter != null)
                    {
                        Helpers.Helpers.DispatchService.Invoke(() =>
                        {
                            transmitter.ToList().ForEach(x => AllTransmitter.Add(x.ToTransmitter()));
                            SelectedTransmistter = AllTransmitter.SingleOrDefault(x => x.Transmitter_Id == BillQuotation.BILL_Transmitter.Transmitter_Id);
                        });
                    }

                    //Company
                    var company = ServiceGestionClient.GetListCompany();
                    if (company != null)
                    {
                        Helpers.Helpers.DispatchService.Invoke(() =>
                        {
                            company.ToList().ForEach(x => AllCompany.Add(x.ToCompanyClient()));
                            SelectedCompany = AllCompany.SingleOrDefault(x => x.Id == BillQuotation.Company.Id);
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            });
        }

        #endregion Initialisation

        #region Fields

        private bool _IsNewBillQuotation;

        public bool IsNewBillQuotation
        {
            get
            {
                return _IsNewBillQuotation;
            }
            set
            {
                _IsNewBillQuotation = value;
                RaisePropertyChanged("IsNewBillQuotation");
            }
        }

        private double _TotalHT;

        public double TotalHT
        {
            get { return _TotalHT; }
            set
            {
                _TotalHT = value;
                BillQuotation.AmountDF = _TotalHT;
                RaisePropertyChanged("TotalHT");
            }
        }

        private double _TotalTTC;

        public double TotalTTC
        {
            get { return _TotalTTC; }
            set
            {
                _TotalTTC = value;
                BillQuotation.AmountTTC = _TotalTTC;
                RaisePropertyChanged("TotalTTC");
            }
        }

        private BillQuotation _BillQuotation;

        public BillQuotation BillQuotation
        {
            get
            {
                if (_BillQuotation == null)
                    _BillQuotation = new BillQuotation();
                return _BillQuotation;
            }
            set
            {
                _BillQuotation = value;
                RaisePropertyChanged("BillQuotation");
            }
        }

        private Transmitter _SelectedTransmitter;

        public Transmitter SelectedTransmistter
        {
            get { return _SelectedTransmitter; }
            set
            {
                _SelectedTransmitter = value;
                BillQuotation.BILL_Transmitter = _SelectedTransmitter;
                RaisePropertyChanged("SelectedTransmistter");
            }
        }

        private ObservableCollection<Transmitter> _AllTransmitter;

        public ObservableCollection<Transmitter> AllTransmitter
        {
            get
            {
                if (_AllTransmitter == null)
                    _AllTransmitter = new ObservableCollection<Transmitter>();
                return _AllTransmitter;
            }
            set
            {
                _AllTransmitter = value;
                RaisePropertyChanged("AllTransmitter");
            }
        }

        private ModuleFactureUserControl.Model.Company _SelectedCompany;

        public ModuleFactureUserControl.Model.Company SelectedCompany
        {
            get
            {
                return _SelectedCompany;
            }
            set
            {
                _SelectedCompany = value;
                BillQuotation.Company = _SelectedCompany;
                RaisePropertyChanged("SelectedCompany");
            }
        }

        private ObservableCollection<ModuleFactureUserControl.Model.Company> _AllCompany;

        public ObservableCollection<ModuleFactureUserControl.Model.Company> AllCompany
        {
            get
            {
                if (_AllCompany == null)
                    _AllCompany = new ObservableCollection<Model.Company>();
                return _AllCompany;
            }
            set
            {
                _AllCompany = value;
                RaisePropertyChanged("AllCompany");
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

        private BillQuotationType _SelectedType;

        public BillQuotationType SelectedType
        {
            get
            {
                return _SelectedType;
            }
            set
            {
                _SelectedType = value;
                RefreshStatus();
                RaisePropertyChanged("SelectedType");
            }
        }

        #endregion Fields

        #region Methods

        private void ChangeStatusCommandHandler()
        {
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
        }

        //private void RemoveLineCommandHandler(long idLine)
        //{
        //    DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", "Suppression", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {
        //        //TODO : Method pour sup line
        //        //FacturationService.RemoveLine(idLine);
        //    }
        //}

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

        private void UpdateLineCommandHandler()
        {
            try
            {
                var lineQuotationExtended = FacturationService.GetAllLines(BillQuotation.BillQuotation_Id);
                var lineQuotation = lineQuotationExtended.ToLineBillQuotationExtended();

                var datacontext = new AjoutModifLigneCommandeViewModel(lineQuotation);
                var uc = new AjoutModifLigneCommande();
                uc.DataContext = datacontext;
                var wnd = new WindowsSimple(uc);
                datacontext.CloseWindow += wnd.CloseWindowEvent;
                datacontext.SaveLineBillQuotation += datacontext_SaveLineBillQuotation;
                wnd.Height = 600;
                wnd.Width = 800;
                wnd.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public void datacontext_SaveLineBillQuotation(System.Collections.Generic.List<LineBillQuotation> lineBillQuotation)
        {
            BillQuotation.BILL_LineBillQuotation = new ObservableCollection<LineBillQuotation>(lineBillQuotation);
            RefreshCountAmount();
        }

        private void SaveBillCommandHandler()
        {
            try
            {
                var billQuotationComplete = BillQuotation.ToBillQuotationComplete();
                var result = false;
                if (IsNewBillQuotation)
                {
                    billQuotationComplete.DateBillQuotation = DateTime.Now;
                    result = FacturationService.CreateBillQuotation(billQuotationComplete);
                }
                else
                    result = FacturationService.ModifyBillQuotation(billQuotationComplete);

                if (result && RefreshListQuotationEvent != null)
                {
                    RefreshListQuotationEvent.Invoke();
                    if (CloseWindow != null)
                        CloseWindow.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void CancelCommandHandler()
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment annuler vos modifications?", "Annuler", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (CloseWindow != null)
                    CloseWindow.Invoke();
            }
        }

        private void RefreshCountAmount()
        {
            TotalHT = 0;
            TotalTTC = 0;

            // Additionne les prix des produits
            foreach (var line in BillQuotation.BILL_LineBillQuotation)
            {
                TotalHT = TotalHT + line.AmountHT;
                TotalTTC = TotalTTC + line.AmountTTC;
            }
        }

        public void RefreshStatus()
        {
            if (IsNewBillQuotation)
                BillQuotation.Type = SelectedType;

            if (ListeFactureDevisViewModel.StatusStatic != null)
            {
                if (BillQuotation.Type == BillQuotationType.Facture)
                {
                    BillQuotation.NBill = "1";
                    BillQuotation.Status = ListeFactureDevisViewModel.StatusStatic[10];
                }
                else
                {
                    BillQuotation.NBill = "0";
                    BillQuotation.Status = ListeFactureDevisViewModel.StatusStatic[9];
                }
            }
        }

        #endregion Methods

        #region Commands

        ////ChangeStatusCommand
        //private RelayCommand _ChangeStatusCommand;

        //public ICommand ChangeStatusCommand
        //{
        //    get
        //    {
        //        if (_ChangeStatusCommand == null)
        //            _ChangeStatusCommand = new RelayCommand((x) => ChangeStatusCommandHandler());
        //        return ChangeStatusCommand;
        //    }
        //}

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

        private RelayCommand _UpdateLineCommand;

        public ICommand UpdateLineCommand
        {
            get
            {
                if (_UpdateLineCommand == null)
                    _UpdateLineCommand = new RelayCommand((x) => UpdateLineCommandHandler());
                return _UpdateLineCommand;
            }
        }

        //private RelayCommand<long> _RemoveLineCommand;

        //public ICommand RemoveLineCommand
        //{
        //    get
        //    {
        //        if (_RemoveLineCommand == null)
        //            _RemoveLineCommand = new RelayCommand<long>((x) => RemoveLineCommandHandler(x));
        //        return _RemoveLineCommand;
        //    }
        //}

        private RelayCommand _SaveBillCommand;

        public ICommand SaveBillCommand
        {
            get
            {
                if (_SaveBillCommand == null)
                    _SaveBillCommand = new RelayCommand((x) => SaveBillCommandHandler());
                return _SaveBillCommand;
            }
        }

        private RelayCommand _CancelCommand;

        public ICommand CancelCommand
        {
            get
            {
                if (_CancelCommand == null)
                    _CancelCommand = new RelayCommand((x) => CancelCommandHandler());
                return _CancelCommand;
            }
        }

        #endregion Commands
    }
}