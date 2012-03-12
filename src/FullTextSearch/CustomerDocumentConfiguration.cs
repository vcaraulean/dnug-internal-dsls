using NHibernate.Search.Fluent.Mapping;

namespace dnug.internaldsl.FullTextSearch
{
	public class CustomerDocumentConfiguration : DocumentMap<Customer>
	{
		public CustomerDocumentConfiguration()
		{
			Name("LuceneIndex");
			Id(x => x.Id);
			
			Map(x => x.FirstName)
				.Store().Yes()
				.Index().Tokenized();
			
			Map(x => x.LastName)
				.Store().Yes()
				.Index().Tokenized();

			Map(x => x.CreditCardNumber)
				.Store().No()
				.Index().UnTokenized();

			FieldBridge(x => x.CreditCardNumber).Custom<CreditCardEncriptedFieldBridge>();
		}
	}
}