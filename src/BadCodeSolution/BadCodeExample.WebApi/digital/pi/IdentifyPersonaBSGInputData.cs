using System;
using bsgGeneric.pi;
using bsgGeneric.exceptions;
using bsgSupport.common.messages;

namespace bsgSupport.digital.pi
{
    /// <summary>
    /// Summary description for IdentifyPersonaBSGInputData.
    /// </summary>
    public class IdentifyPersonaBSGInputData : GenericInputData
    {
        #region Properties
        public string personaID
        {
            get;
            set;
        }

        public string sessionID
        {
            get;
            set;
        }

        #endregion Properties

        #region Method.public

        public override void validate()
        {
            if (string.IsNullOrEmpty(this.personaID))
                throw new BSGValidationException("personaID is mandatory");

            if (string.IsNullOrEmpty(this.sessionID))
                throw new BSGValidationException("sessionID is mandatory");

            if ( !this.personaID.Substring(0,1).ToUpper().Equals("P") )
                throw new BSGValidationException("personaID wrong format");
        }

        public string[] populateTransaction()
        {
            String[] sparams = new String[8];
            sparams[0] = "IP";
            sparams[1] = this.personaID.Substring(1); // o 1º char 'P' não interessa
            sparams[2] = null;
            sparams[3] = null;
            sparams[4] = null;
            sparams[5] = null;
            sparams[6] = null;
            sparams[7] = null;
            sparams[8] = this.sessionID;

            return sparams;
        }

        #endregion Method.public
    }
}