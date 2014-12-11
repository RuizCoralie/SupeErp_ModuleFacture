using ModuleFactureUserControl.Model;
using System;
using System.Collections.ObjectModel;

namespace ModuleFactureUserControl.Mapper
{
    public static class MapperToWpfModel
    {
        public static BillQuotation ToBillQuotation(this FacturationService.BILL_BillQuotation billQuotationService)
        {
            var billQuotation = new BillQuotation();
            try
            {
                if (billQuotationService != null)
                {
                    billQuotation.AmountDF = billQuotationService.AmountDF;
                    billQuotation.Vat = billQuotationService.Vat;
                    billQuotation.Type = string.IsNullOrEmpty(billQuotationService.NBill) ? BillQuotationType.Devis : BillQuotationType.Facture;
                    billQuotation.NBill = billQuotationService.NBill;
                    billQuotation.BillQuotation_Id = billQuotationService.BillQuotation_Id;
                    billQuotation.DateBillQuotation = billQuotationService.DateBillQuotation;
                    billQuotation.BILL_Transmitter = billQuotationService.BILL_Transmitter.ToTransmitter();
                    billQuotation.Company = billQuotationService.Company.ToCompany();
                    //billQuotation.BILL_BillQuotationStatus = billQuotationService.BILL_BillQuotationStatus.First().ToBillQuotationStatus();
                    //billQuotation.BILL_LineBillQuotation = billQuotationService.BILL_LineBillQuotation.ToLineBillQuotation();
                }
            }
            catch (Exception ex)
            {
            }
            return billQuotation;
        }

        public static BillQuotation ToBillQuotation(this FacturationService.BillQuotationComplete billQuotationCompleteService)
        {
            var billQuotation = new BillQuotation();
            try
            {
                if (billQuotationCompleteService != null)
                {
                    billQuotation.AmountDF = billQuotationCompleteService.AmountDF;
                    billQuotation.AmountTTC = billQuotationCompleteService.AmountTTC;
                    billQuotation.BillQuotation_Id = billQuotationCompleteService.BillQuotation_Id;
                    billQuotation.DateBillQuotation = billQuotationCompleteService.DateBillQuotation;
                    billQuotation.NBill = billQuotationCompleteService.NBill;
                    billQuotation.Vat = billQuotationCompleteService.Vat;
                    billQuotation.Type = string.IsNullOrEmpty(billQuotationCompleteService.NBill) ? BillQuotationType.Devis : BillQuotationType.Facture;
                    billQuotation.BILL_LineBillQuotation = billQuotationCompleteService.BILL_LineBillQuotation.ToLineBillQuotation();
                    billQuotation.BILL_Transmitter = billQuotationCompleteService.BILL_Transmitter.ToTransmitter();
                    billQuotation.Company = billQuotationCompleteService.Company.ToCompany();
                    billQuotation.Status = billQuotationCompleteService.BillStatus.ToStatus();
                    //billQuotation.BILL_BillQuotationStatus = billQuotationCompleteService.BILL_BillQuotationStatus.First().ToBillQuotationStatus();
                }
            }
            catch (Exception ex)
            {
            }
            return billQuotation;
        }

        public static BillQuotation ToBillQuotation(this FacturationService.BillQuotationLight billQuotationLightService)
        {
            var billQuotation = new BillQuotation();
            try
            {
                if (billQuotationLightService != null)
                {
                    billQuotation.AmountDF = billQuotationLightService.AmountDF;
                    billQuotation.DateBillQuotation = billQuotationLightService.DateBillQuotation;
                    billQuotation.NBill = billQuotationLightService.NBill;
                    billQuotation.Vat = billQuotationLightService.Vat;
                    billQuotation.Status = billQuotationLightService.BillStatus.ToStatus();
                    billQuotation.AmountTTC = billQuotationLightService.AmountTTC;
                    billQuotation.BillQuotation_Id = billQuotationLightService.BillQuotation_Id;
                    billQuotation.Type = string.IsNullOrEmpty(billQuotationLightService.NBill) ? BillQuotationType.Devis : BillQuotationType.Facture;
                    //billQuotation.BILL_LineBillQuotation = billQuotationLightService.BILL_LineBillQuotation.ToLineBillQuotation();
                    //billQuotation.BILL_BillQuotationStatus = billQuotationLightService.BILL_BillQuotationStatus.First().ToBillQuotationStatus();
                    billQuotation.BILL_Transmitter = billQuotationLightService.BILL_Transmitter.ToTransmitter();
                    billQuotation.Company = billQuotationLightService.Company.ToCompany();
                }
            }
            catch (Exception ex)
            {
            }
            return billQuotation;
        }

        public static BillQuotationStatus ToBillQuotationStatus(this FacturationService.BILL_BillQuotationStatus billQuotationStatusService)
        {
            var billQuotationStatus = new BillQuotationStatus();
            try
            {
                billQuotationStatus.BILL_Status = billQuotationStatusService.BILL_Status.ToStatus();
                billQuotationStatus.BillQuotationStatus_Id = billQuotationStatusService.BillQuotationStatus_Id;
                billQuotationStatus.DateAdvancement = billQuotationStatusService.DateAdvancement;
            }
            catch (Exception ex)
            {
            }
            return billQuotationStatus;
        }

        public static Category ToCategory(this FacturationService.BILL_Category categoryService)
        {
            var category = new Category();
            try
            {
                if (categoryService != null)
                {
                    category.Category_Id = categoryService.Category_Id;
                    category.DescriptionCat = categoryService.DescriptionCat;
                    category.Name = categoryService.Name;
                }
            }
            catch (Exception ex)
            {
            }
            return category;
        }

        public static Company ToCompany(this FacturationService.Company companyService)
        {
            var company = new Company();
            try
            {
                if (companyService != null)
                {
                    company.Adress = companyService.address;
                    company.City = companyService.city;
                    company.Id = companyService.id;
                    company.Name = companyService.name;
                    company.Postalcode = companyService.postalcode;
                    company.Siret = companyService.siret;
                }
            }
            catch (Exception ex)
            {
            }
            return company;
        }

        public static Company ToCompanyClient(this ClientService.Company companyService)
        {
            var company = new Company();
            try
            {
                if (companyService != null)
                {
                    company.Adress = companyService.address;
                    company.City = companyService.city;
                    company.Id = companyService.id;
                    company.Name = companyService.name;
                    company.Postalcode = companyService.postalcode;
                    company.Siret = companyService.siret;
                }
            }
            catch (Exception ex)
            {
            }
            return company;
        }

        public static ObservableCollection<LineBillQuotation> ToLineBillQuotation(this FacturationService.BILL_LineBillQuotation[] linesBillQuotationService)
        {
            var linesBillQuotation = new ObservableCollection<LineBillQuotation>();
            foreach (var line in linesBillQuotationService)
            {
                linesBillQuotation.Add(line.ToLineBillQuotation());
            }
            return linesBillQuotation;
        }

        public static ObservableCollection<LineBillQuotation> ToLineBillQuotationExtended(this FacturationService.LineExtended[] linesBillQuotationService)
        {
            var linesBillQuotation = new ObservableCollection<LineBillQuotation>();
            foreach (var line in linesBillQuotationService)
            {
                linesBillQuotation.Add(line.ToLineBillQuotation());
            }
            return linesBillQuotation;
        }

        public static LineBillQuotation ToLineBillQuotation(this FacturationService.BILL_LineBillQuotation lineBillQuotationService)
        {
            var lineBillQuotation = new LineBillQuotation();
            try
            {
                if (lineBillQuotationService != null)
                {
                    lineBillQuotation.BILL_Product = lineBillQuotationService.BILL_Product.ToProduct();
                    lineBillQuotation.DateLine = lineBillQuotationService.DateLine;
                    lineBillQuotation.LineBillQuotation_Id = lineBillQuotationService.LineBillQuotation_Id;
                    lineBillQuotation.Quantite = lineBillQuotationService.Quantite;
                }
            }
            catch (Exception ex)
            {
            }
            return lineBillQuotation;
        }

        public static LineBillQuotation ToLineBillQuotation(this FacturationService.LineExtended lineBillQuotationExtendedService)
        {
            var lineBillQuotation = new LineBillQuotation();
            try
            {
                if (lineBillQuotationExtendedService != null)
                {
                    lineBillQuotation.BILL_Product = lineBillQuotationExtendedService.BILL_Product.ToProduct();
                    lineBillQuotation.DateLine = lineBillQuotationExtendedService.DateLine;
                    lineBillQuotation.LineBillQuotation_Id = lineBillQuotationExtendedService.LineBillQuotation_Id;
                    lineBillQuotation.Quantite = lineBillQuotationExtendedService.Quantite;
                    lineBillQuotation.IsInBill = lineBillQuotationExtendedService.Included;
                    lineBillQuotation.AmountHT = lineBillQuotationExtendedService.AmountHT;
                    lineBillQuotation.AmountTTC = lineBillQuotationExtendedService.AmountTTC;
                }
            }
            catch (Exception ex)
            {
            }
            return lineBillQuotation;
        }

        public static Product ToProduct(this FacturationService.BILL_Product productService)
        {
            var product = new Product();
            try
            {
                if (productService != null)
                {
                    product.BILL_Category = productService.BILL_Category.ToCategory();
                    product.BILL_Vat = productService.BILL_Vat.ToVat();
                    product.DescriptionPro = productService.DescriptionPro;
                    product.Name = productService.Name;
                    product.Price = productService.Price;
                    product.Product_Id = productService.Product_Id;
                }
            }
            catch (Exception ex)
            {
            }
            return product;
        }

        public static Status ToStatus(this FacturationService.BILL_Status statusService)
        {
            var status = new Status();
            try
            {
                if (statusService != null)
                {
                    status.Libel = statusService.Libel;
                    status.Status_Id = statusService.Status_Id;
                }
            }
            catch (Exception ex)
            {
            }
            return status;
        }

        public static Transmitter ToTransmitter(this FacturationService.BILL_Transmitter transmitterService)
        {
            var transmitter = new Transmitter();
            try
            {
                if (transmitterService != null)
                {
                    transmitter.Adress = transmitterService.Adress;
                    transmitter.AdressMail = transmitterService.AdressMail;
                    transmitter.City = transmitterService.City;
                    transmitter.CompanyName = transmitterService.CompanyName;
                    transmitter.NSiret = transmitterService.NSiret;
                    transmitter.Phone = transmitterService.Phone;
                    transmitter.PostCode = transmitterService.PostCode;
                    transmitter.Transmitter_Id = transmitterService.Transmitter_Id;
                }
            }
            catch (Exception ex)
            {
            }
            return transmitter;
        }

        public static Vat ToVat(this FacturationService.BILL_Vat vatService)
        {
            var vat = new Vat();
            try
            {
                if (vatService != null)
                {
                    vat.DateVat = vatService.DateVat;
                    vat.Rate = vatService.Rate;
                    vat.Vat_Id = vatService.Vat_Id;
                }
            }
            catch (Exception ex)
            {
            }
            return vat;
        }
    }
}