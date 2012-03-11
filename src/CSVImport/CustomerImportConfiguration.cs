using CsvHelper.Configuration;

namespace dnug.internaldsl.CSVImport
{
	public class CustomerImportConfiguration : CsvClassMap<Customer>
	{
		public CustomerImportConfiguration()
		{
			Map(x => x.Id).Name("Customer ID").Index(1);
			Map(x => x.FirstName).Name("First name").Index(2);
			Map(x => x.FirstName).Name("Last name").Index(3);

			Map(x => x.Age).Ignore();
			Map(x => x.CreditCardNumber).Ignore();
		}
	}
}