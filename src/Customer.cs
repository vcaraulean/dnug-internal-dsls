using System;
using CsvHelper.Configuration;
using NHibernate.Mapping.Attributes;
using NHibernate.Search.Attributes;
using NHibernate.Search.Bridge.Builtin;
using NHibernate.Validator.Constraints;

namespace dnug.internaldsl
{
	[Class]
	[Indexed(Index = "LuceneIndex")]
	public class Customer
	{
		[Id(Column = "CUSTOMER_ID")]
		[Generator(1, Class = "guid")] 
		[CsvField(Ignore = false, Name = "Customer ID", Index = 1)]
		[DocumentId(Name = "customerId")]
		[FieldBridge(typeof(GuidBridge))]
		public Guid Id { get; set; }

		[Property(Column = "FIRST_NAME")]
		[Length(Min = 3, Max = 20)]
		[CsvField(Index = 2, Name = "First name")]
		[Field(Index.Tokenized, Store = Store.Yes)]
		public string FirstName { get; set; }

		[Property]
		[Length(Min = 3, Max = 20)]
		[CsvField(Index = 3, Name = "Last name")]
		[Field(Index.Tokenized, Store = Store.Yes)]
		public string LastName { get; set; }

		[Property]
		[Range(Min = 16, Max = 65)]
		[CsvField(Ignore = true)]
		public int Age { get; set; }

		[Property]
		[CreditCardNumber]
		[CsvField(Ignore = true)]
		[Field(Index.UnTokenized, Store = Store.No)]
		[FieldBridge(typeof(CreditCardEncriptedFieldBridge))]
		public string CreditCardNumber { get; set; }
	}
}
