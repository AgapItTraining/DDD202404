using System.Collections.Generic;
using CommonStuff.digital;

namespace DigitalServices.digital.pi
{
	public class InsertSomeDataOutputData : GenericOutputData
    {
        internal string outputMessage;
        internal string beTime;

        /// <summary>
        /// List of parent card objects inserted or updated.
        /// </summary>
        public List<SomeEntity> insertedParentCards { get; set; }

		/// <summary>
		/// Public constructor.
		/// </summary>
		public InsertSomeDataOutputData()
		{
			insertedParentCards = new List<SomeEntity>();
		}
	}
}