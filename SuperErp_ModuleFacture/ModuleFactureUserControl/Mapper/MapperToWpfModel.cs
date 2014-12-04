using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleFactureUserControl.Model;

namespace ModuleFactureUserControl.Mapper
{
    public static class MapperToWpfModel
    {
        public static BillQuotation ToBillQuotation(this FacturationService.BILL_BillQuotation billQuotationService)
        {
            var billQuotation = new BillQuotation();

            return billQuotation;
        }

        public static BillQuotationStatus ToBillQuotationStatus(this FacturationService.BILL_BillQuotationStatus billQuotationStatusService)
        {
            var billQuotationStatus = new BillQuotationStatus();

            return billQuotationStatus;
        }

        public static Category ToCategory(this FacturationService.BILL_Category categoryService)
        {
            var category = new Category();

            return category;
        }

        public static Company ToCompany(this FacturationService.Company companyService)
        {
            var company = new Company();

            return company;
        }

        public static Company_Contact ToCompanyContact(this FacturationService.Company_Contact companyContactService)
        {
            var companyContact = new Company_Contact();

            return companyContact;
        }

        public static LineBillQuotation ToLineBillQuotation(this FacturationService.BILL_LineBillQuotation lineBillQuotationService)
        {
            var lineBillQuotation = new LineBillQuotation();

            return lineBillQuotation;
        }

        public static Product ToProduct(this FacturationService.BILL_Product productService)
        {
            var product = new Product();

            return product;
        }

        public static Status ToStatus(this FacturationService.BILL_Status statusService)
        {
            var status = new Status();

            return status;
        }
        public static Transmitter ToTransmitter(this FacturationService.BILL_Transmitter transmitterService)
        {
            var transmitter = new Transmitter();

            return transmitter;
        }

        public static Vat ToVat(this FacturationService.BILL_Vat vatService)
        {
            var vat = new Vat();

            return vat;
        }
    }
}
