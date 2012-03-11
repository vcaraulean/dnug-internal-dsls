using System;
using NHibernate.Mapping.Attributes;

namespace dnug.internaldsl
{
	[Class]
	public class Customer
	{
		[Id(Column = "CUSTOMER_ID")]
		[Generator(1, Class = "guid")] 
		public Guid Id { get; set; }

		[Property(Column = "FIRST_NAME")]
		public string FirstName { get; set; }

		[Property]
		public string LastName { get; set; }

		[Property]
		public int Age { get; set; }

		[Property]
		public string CreditCardNumber { get; set; }
	}
}
