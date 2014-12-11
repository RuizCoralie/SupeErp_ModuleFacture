using ModuleFactureUserControl.FacturationService;
using ModuleFactureUserControl.Helpers;
using ModuleFactureUserControl.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace ModuleFactureUserControl.ViewModel
{
    public class AjoutModifLigneCommandeViewModel : NotificationObject
    {
        #region Events

        public event Action CloseWindow;

        public event Action<List<LineBillQuotation>> SaveLineBillQuotation;

        #endregion Events

        #region Properties

        private FacturationServiceClient FacturationService;

        #endregion Properties

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

        private ObservableCollection<LineBillQuotation> _LineBillQuotation;

        public ObservableCollection<LineBillQuotation> LineBillQuotation
        {
            get { return _LineBillQuotation; }
            set
            {
                _LineBillQuotation = value;
                RaisePropertyChanged("LineBillQuotation");
            }
        }

        private double _TotalHT;

        public double TotalHT
        {
            get { return _TotalHT; }
            set
            {
                _TotalHT = value;
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
                RaisePropertyChanged("TotalTTC");
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

        #endregion Fields

        #region Initialisation

        public AjoutModifLigneCommandeViewModel()
        {
            AllProductsIsChecked = false;
            FacturationService = new FacturationServiceClient();
        }

        public AjoutModifLigneCommandeViewModel(ObservableCollection<LineBillQuotation> lineBillQuotation)
        {
            AllProductsIsChecked = false;
            LineBillQuotation = lineBillQuotation;
            FacturationService = new FacturationServiceClient();
        }

        #endregion Initialisation

        #region Methods

        //TODO :Refresh lors d'un selection d'une ligne
        private void RefreshCountAmount()
        {
            TotalHT = 0;
            TotalTTC = 0;

            // Additionne les prix des produits
            foreach (var line in LineBillQuotation)
            {
                TotalHT = TotalHT + line.AmountHT;
                TotalTTC = TotalTTC + line.AmountTTC;
            }
        }

        private void FilterCommandHandler()
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void CancelCommandHandler()
        {
            if (CloseWindow != null)
                CloseWindow.Invoke();
        }

        private void ComfirmCommandHandler()
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment confirmer vos modifications?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Recup toutes les lignes cochées;
                var linesChecked = LineBillQuotation.Where(x => x.IsInBill).ToList();
                if (linesChecked == null)
                    linesChecked = new List<LineBillQuotation>();

                linesChecked.ForEach(x => x.DateLine = DateTime.Now);

                if (SaveLineBillQuotation != null)
                    SaveLineBillQuotation.Invoke(linesChecked);

                if (CloseWindow != null)
                    CloseWindow.Invoke();
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

        private RelayCommand _ComfirmCommand;

        public ICommand ComfirmCommand
        {
            get
            {
                if (_ComfirmCommand == null)
                    _ComfirmCommand = new RelayCommand((x) => ComfirmCommandHandler());
                return _ComfirmCommand;
            }
        }

        #endregion Commands
    }
}