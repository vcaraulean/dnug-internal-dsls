using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace dnug.internaldsl.Persistence
{
	public class CustomerMapping : ClassMapping<Customer>
	{
		public CustomerMapping()
		{
			Id(x => x.Id, mapper =>
			{
				mapper.Generator(Generators.Guid);
				mapper.Column("CUSTOMER_ID");
			});

			Property(x => x.FirstName, mapper => mapper.Column("FIRST_NAME"));
			Property(x => x.LastName);
			Property(x => x.Age);
			Property(x => x.CreditCardNumber);
		}
	}
}