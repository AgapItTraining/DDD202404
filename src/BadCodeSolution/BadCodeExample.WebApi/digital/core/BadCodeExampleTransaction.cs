using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DigitalServices.digital.pi;

namespace CommonStuff.digital.core
{
    class BadCodeExampleTransaction : SQLTransaction
    {
        private UserContext userContext;

        public BadCodeExampleTransaction(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public override string getTransactionId()
        {
            return "spGenericProcedure";
        }

        new public void execute(InsertSomeDataInputData inputData, ref InsertSomeDataOutputData outputData)
        {
            executeByInstance("DEV");
        }

        private void executeByInstance(string v)
        {
            throw new NotImplementedException();
        }
    }
}