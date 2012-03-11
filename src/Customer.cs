using System;
using CsvHelper.Configuration;
using NHibernate.Mapping.Attributes;
using NHibernate.Validator.Constraints;

namespace dnug.internaldsl
{
	[Class]
	public class Customer
	{
		[Id(Column = "CUSTOMER_ID")]
		[Generator(1, Class = "guid")] 
		[CsvField(Ignore = false, Name = "Customer ID", Index = 1)]
		public Guid Id { get; set; }

		[Property(Column = "FIRST_NAME")]
		[Length(Min = 3, Max = 20)]
		[CsvField(Index = 2, Name = "First name")]
		public string FirstName { get; set; }

		[Property]
		[Length(Min = 3, Max = 20)]
		[CsvField(Index = 3, Name = "Last name")]
		public string LastName { get; set; }

		[Property]
		[Range(Min = 16, Max = 65)]
		[CsvField(Ignore = true)]
		public int Age { get; set; }

		[Property]
		[CreditCardNumber]
		[CsvField(Ignore = true)]
		public string CreditCardNumber { get; set; }
	}
}
