using System;
using System.Globalization;
using DigitalServices.digital.pi;
using System.Data.SqlClient;
using System.Collections.Generic;
using CommonStuff.digital;
using CommonStuff.digital.core;

namespace CommonStuff.digital
{
	public class BadCodeService : GenericService
	{
		#region Constants and Statics
		public static class ClassInsideTheFileWithoutPourpose 
		{
			//...SomeInformation
		}
		#endregion

		#region Web methods 
		public virtual InsertSomeDataOutputData genericMethodBadName(InsertSomeDataInputData inputData)
		{
			var serviceName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			var dt1 = DateTime.Now;
            var outputData = new InsertSomeDataOutputData();

			try
			{
				// Validate the headers
				var userContext = checkSecurity();

				// Validate the input
				if (inputData != null)
					inputData.validate();
				else
					throw new Exception("Inexistent input data structure.");

                // Execute
                var transaction = new BadCodeExampleTransaction(userContext);
                transaction.execute(inputData, ref outputData);
            }
            catch (Exception exception)
			{
				var god = outputData;
				god.outputMessage = exception.ToString();
				HandleException(serviceName, exception, ref god);
			}

			outputData.beTime = (DateTime.Now - dt1).TotalSeconds.ToString(CultureInfo.InvariantCulture);

			return outputData;
		}

        #endregion
    }
}