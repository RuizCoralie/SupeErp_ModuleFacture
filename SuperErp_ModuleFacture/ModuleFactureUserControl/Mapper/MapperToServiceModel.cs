using ModuleFactureUserControl.Model;
using System;
using System.Collections.ObjectModel;

namespace ModuleFactureUserControl.Mapper
{
    public static class MapperToServiceModel
    {
        public static FacturationService.BILL_BillQuotation ToBillQuotation(this BillQuotation billQuotationWpf)
        {
            var billQuotation = new FacturationService.BILL_BillQuotation();
            try
            {
                billQuotation.AmountDF = billQuotationWpf.AmountDF;
                //billQuotation.BILL_BillQuotationStatus = billQuotationWpf.BILL_BillQuotationStatus.First().ToBillQuotationStatus();
                //billQuotation.BILL_LineBillQuotation = billQuotationService.BILL_LineBillQuotation.ToLineBillQuotation();
                billQuotation.BILL_Transmitter = billQuotationWpf.BILL_Transmitter.ToTransmitter();
                billQuotation.BillQuotation_Id = billQuotationWpf.BillQuotation_Id;
                billQuotation.Company = billQuotationWpf.Company.ToCompany();
                billQuotation.DateBillQuotation = billQuotationWpf.DateBillQuotation;
                billQuotation.NBill = billQuotationWpf.NBill;
                billQuotation.Vat = billQuotationWpf.Vat;
            }
            catch (Exception ex)
            {
            }
            return billQuotation;
        }

        public static FacturationService.BillQuotationComplete ToBillQuotationComplete(this BillQuotation billQuotationCompleteWpf)
        {
            var billQuotation = new FacturationService.BillQuotationComplete();
            try
            {
                billQuotation.AmountDF = billQuotationCompleteWpf.AmountDF;
                //billQuotation.BILL_BillQuotationStatus = billQuotationCompleteWpf.BILL_BillQuotationStatus.First().ToBillQuotationStatus();
                billQuotation.BILL_LineBillQuotation = billQuotationCompleteWpf.BILL_LineBillQuotation.ToLineBillQuotation();
                billQuotation.BILL_Transmitter = billQuotationCompleteWpf.BILL_Transmitter.ToTransmitter();
                billQuotation.BillQuotation_Id = billQuotationCompleteWpf.BillQuotation_Id;
                billQuotation.Company = billQuotationCompleteWpf.Company.ToCompany();
                billQuotation.Company_Id = billQuotationCompleteWpf.Company.Id;
                billQuotation.Transmitter_Id = billQuotationCompleteWpf.BILL_Transmitter.Transmitter_Id;
                billQuotation.DateBillQuotation = billQuotationCompleteWpf.DateBillQuotation;
                billQuotation.NBill = billQuotationCompleteWpf.NBill;
                billQuotation.Vat = billQuotationCompleteWpf.Vat;
                billQuotation.AmountTTC = billQuotationCompleteWpf.AmountTTC;
            }
            catch (Exception ex)
            {
            }
            return billQuotation;
        }

        public static FacturationService.BillQuotationLight ToBillQuotationLight(this BillQuotation billQuotationLightWpf)
        {
            var billQuotation = new FacturationService.BillQuotationLight();
            try
            {
                billQuotation.AmountDF = billQuotationLightWpf.AmountDF;
                //billQuotation.BILL_BillQuotationStatus = billQuotationLightWpf.BILL_BillQuotationStatus.First().ToBillQuotationStatus();
                //billQuotation.BILL_LineBillQuotation = billQuotationLightService.BILL_LineBillQuotation.ToLineBillQuotation();
                billQuotation.BILL_Transmitter = billQuotationLightWpf.BILL_Transmitter.ToTransmitter();
                billQuotation.BillQuotation_Id = billQuotationLightWpf.BillQuotation_Id;
                billQuotation.Company = billQuotationLightWpf.Company.ToCompany();
                billQuotation.DateBillQuotation = billQuotationLightWpf.DateBillQuotation;
                billQuotation.NBill = billQuotationLightWpf.NBill;
                billQuotation.Vat = billQuotationLightWpf.Vat;
                billQuotation.AmountTTC = billQuotationLightWpf.AmountTTC;
            }
            catch (Exception ex)
            {
            }
            return billQuotation;
        }

        public static FacturationService.BILL_BillQuotationStatus ToBillQuotationStatus(this BillQuotationStatus billQuotationStatusWpf)
        {
            var billQuotationStatus = new FacturationService.BILL_BillQuotationStatus();
            try
            {
                billQuotationStatus.BILL_Status = billQuotationStatusWpf.BILL_Status.ToStatus();
                billQuotationStatus.BillQuotationStatus_Id = billQuotationStatusWpf.BillQuotationStatus_Id;
                billQuotationStatus.DateAdvancement = billQuotationStatusWpf.DateAdvancement;
            }
            catch (Exception ex)
            {
            }
            return billQuotationStatus;
        }

        public static FacturationService.BILL_Category ToCategory(this Category categoryWpf)
        {
            var category = new FacturationService.BILL_Category();
            try
            {
                category.Category_Id = categoryWpf.Category_Id;
                category.DescriptionCat = categoryWpf.DescriptionCat;
                category.Name = categoryWpf.Name;
            }
            catch (Exception ex)
            {
                throw;
            }
            return category;
        }

        public static FacturationService.Company ToCompany(this Company companyWpf)
        {
            var company = new FacturationService.Company();
            try
            {
                company.address = companyWpf.Adress;
                company.city = companyWpf.City;
                company.id = companyWpf.Id;
                company.name = companyWpf.Name;
                company.postalcode = companyWpf.Postalcode;
                company.siret = companyWpf.Siret;
            }
            catch (Exception ex)
            {
            }
            return company;
        }

        public static ClientService.Company ToCompanyClient(this Company companyWpf)
        {
            var company = new ClientService.Company();
            try
            {
                company.address = companyWpf.Adress;
                company.city = companyWpf.City;
                company.id = companyWpf.Id;
                company.name = companyWpf.Name;
                company.postalcode = companyWpf.Postalcode;
                company.siret = companyWpf.Siret;
            }
            catch (Exception ex)
            {
            }
            return company;
        }

        public static FacturationService.LineExtended[] ToLineBillQuotationExtented(this ObservableCollection<LineBillQuotation> linesBillQuotationWpf)
        {
            var linesBillQuotation = new FacturationService.LineExtended[250];
            for (int i = 0; i < linesBillQuotationWpf.Count - 1; i++)
            {
                try
                {
                    linesBillQuotation[i] = linesBillQuotationWpf[i].ToLineBillQuotationExtended();
                }
                catch (Exception)
                {
                }
            }
            return linesBillQuotation;
        }

        public static FacturationService.BILL_LineBillQuotation[] ToLineBillQuotation(this ObservableCollection<LineBillQuotation> linesBillQuotationWpf)
        {
            var linesBillQuotation = new FacturationService.BILL_LineBillQuotation[250];
            for (int i = 0; i < linesBillQuotationWpf.Count - 1; i++)
            {
                try
                {
                    linesBillQuotation[i] = linesBillQuotationWpf[i].ToLineBillQuotation();
                }
                catch (Exception)
                {
                }
            }
            return linesBillQuotation;
        }

        public static FacturationService.BILL_LineBillQuotation ToLineBillQuotation(this LineBillQuotation lineBillQuotationWpf)
        {
            var lineBillQuotation = new FacturationService.BILL_LineBillQuotation();
            try
            {
                lineBillQuotation.BILL_Product = lineBillQuotationWpf.BILL_Product.ToProduct();
                lineBillQuotation.DateLine = lineBillQuotationWpf.DateLine;
                lineBillQuotation.Product_Id = lineBillQuotationWpf.BILL_Product.Product_Id;
                lineBillQuotation.LineBillQuotation_Id = lineBillQuotationWpf.LineBillQuotation_Id;
                lineBillQuotation.Quantite = lineBillQuotationWpf.Quantite;
            }
            catch (Exception ex)
            {
            }
            return lineBillQuotation;
        }

        public static FacturationService.LineExtended ToLineBillQuotationExtended(this LineBillQuotation lineBillQuotationExtendedWpf)
        {
            var lineBillQuotation = new FacturationService.LineExtended();
            try
            {
                lineBillQuotation.BILL_Product = lineBillQuotationExtendedWpf.BILL_Product.ToProduct();
                lineBillQuotation.DateLine = lineBillQuotationExtendedWpf.DateLine;
                lineBillQuotation.Product_Id = lineBillQuotationExtendedWpf.BILL_Product.Product_Id;
                lineBillQuotation.LineBillQuotation_Id = lineBillQuotationExtendedWpf.LineBillQuotation_Id;
                lineBillQuotation.Quantite = lineBillQuotationExtendedWpf.Quantite;
                lineBillQuotation.Included = lineBillQuotationExtendedWpf.IsInBill;
                lineBillQuotation.AmountHT = lineBillQuotationExtendedWpf.AmountHT;
                lineBillQuotation.AmountTTC = lineBillQuotationExtendedWpf.AmountTTC;
            }
            catch (Exception ex)
            {
            }
            return lineBillQuotation;
        }

        public static FacturationService.BILL_Product ToProduct(this Product productWpf)
        {
            var product = new FacturationService.BILL_Product();
            try
            {
                product.BILL_Category = productWpf.BILL_Category.ToCategory();
                product.BILL_Vat = productWpf.BILL_Vat.ToVat();
                product.Category_Id = productWpf.BILL_Category.Category_Id;
                product.Vat_Id = productWpf.BILL_Vat.Vat_Id;
                product.DescriptionPro = productWpf.DescriptionPro;
                product.Name = productWpf.Name;
                product.Price = productWpf.Price;
                product.Product_Id = productWpf.Product_Id;
            }
            catch (Exception ex)
            {
            }
            return product;
        }

        public static FacturationService.BILL_Status ToStatus(this Status statusWpf)
        {
            var status = new FacturationService.BILL_Status();
            try
            {
                status.Libel = statusWpf.Libel;
                status.Status_Id = statusWpf.Status_Id;
            }
            catch (Exception ex)
            {
            }
            return status;
        }

        public static FacturationService.BILL_Transmitter ToTransmitter(this Transmitter transmitterWpf)
        {
            var transmitter = new FacturationService.BILL_Transmitter();
            try
            {
                transmitter.Adress = transmitterWpf.Adress;
                transmitter.AdressMail = transmitterWpf.AdressMail;
                transmitter.City = transmitterWpf.City;
                transmitter.CompanyName = transmitterWpf.CompanyName;
                transmitter.NSiret = transmitterWpf.NSiret;
                transmitter.Phone = transmitterWpf.Phone;
                transmitter.PostCode = transmitterWpf.PostCode;
                transmitter.Transmitter_Id = transmitterWpf.Transmitter_Id;
            }
            catch (Exception ex)
            {
            }
            return transmitter;
        }

        public static FacturationService.BILL_Vat ToVat(this Vat vatService)
        {
            var vat = new FacturationService.BILL_Vat();
            try
            {
                vat.DateVat = vatService.DateVat;
                vat.Rate = vatService.Rate;
                vat.Vat_Id = vatService.Vat_Id;
            }
            catch (Exception ex)
            {
            }
            return vat;
        }
    }
}