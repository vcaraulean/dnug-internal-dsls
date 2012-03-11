using System;
using NHibernate.Mapping.Attributes;
using NHibernate.Validator.Constraints;

namespace dnug.internaldsl
{
	[Class]
	public class Customer
	{
		[Id(Column = "CUSTOMER_ID")]
		[Generator(1, Class = "guid")] 
		public Guid Id { get; set; }

		[Property(Column = "FIRST_NAME")]
		[Length(Min = 3, Max = 20)]
		public string FirstName { get; set; }

		[Property]
		[Length(Min = 3, Max = 20)]
		public string LastName { get; set; }

		[Property]
		[Range(Min = 16, Max = 65)]
		public int Age { get; set; }

		[Property]
		[CreditCardNumber]
		public string CreditCardNumber { get; set; }
	}
}
