using NHibernate.Validator.Cfg.Loquacious;

namespace dnug.internaldsl.Validation
{
	public class CustomerValidationDefinitions : ValidationDef<Customer>
	{
		public CustomerValidationDefinitions()
		{
			Define(x => x.FirstName).LengthBetween(3, 20);
			Define(x => x.LastName).LengthBetween(3, 20);
			Define(x => x.Age).Whitih(16, 65);
			Define(x => x.CreditCardNumber).IsCreditCardNumber();
		}
	}
}