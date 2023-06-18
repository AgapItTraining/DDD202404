using CommonStuff.digital.core;
using DigitalServices.digital.pi;
using System;

namespace CommonStuff.digital
{
    public class GenericService
    {
        public void HandleException(string serviceName, Exception exception, ref InsertSomeDataOutputData god)
        {
            throw new NotImplementedException();
        }

        public void HandleException(string serviceName, Exception exception, ref GenericOutputData god)
        {
            throw new NotImplementedException();
        }

        public UserContext checkSecurity()
        {
            throw new NotImplementedException();
        }
    }
}