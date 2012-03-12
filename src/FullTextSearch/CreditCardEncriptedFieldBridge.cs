using NHibernate.Search.Bridge;

namespace dnug.internaldsl.FullTextSearch
{
	public class CreditCardEncriptedFieldBridge : IFieldBridge
	{
		public void Set(string name, object value, Lucene.Net.Documents.Document document, Lucene.Net.Documents.Field store, Lucene.Net.Documents.Field index, float? boost)
		{
			
		}
	}
}