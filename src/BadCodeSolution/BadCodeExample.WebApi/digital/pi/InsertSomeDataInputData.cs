using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DigitalServices.digital.pi
{
	public class InsertSomeDataInputData : GenericInputData
	{
		public string Name { get; set; }




		public List<SomeEntity> someEntities { get; set; }

		public override void validate()
		{
			foreach (var item in someEntities)
			{
				validateSomeEntity(item);
			}
		}

		

		private void validateSomeEntity(SomeEntity someEntity)
		{
            if (someEntity != null)
			{
				var SqlQuery = "SELECT * FROM SomeEntity WHERE Id = " + someEntity.Id 
					+ " or SomeIdentifier = '" + someEntity.SomeIdentifier +"'";
				
				var connectionString = "Data Source=.;Initial Catalog=SomeDatabase;Integrated Security=True";
				var adoConnection = new SqlConnection(connectionString);
				var query = new SqlCommand(SqlQuery, adoConnection);
				adoConnection.Open();

				var isValid = query.ExecuteReader().HasRows;
				if (isValid == false)
				{
                    throw new Exception("SomeEntity cannot be null.");
                }

				adoConnection.Close();
            }
        }
	}
}