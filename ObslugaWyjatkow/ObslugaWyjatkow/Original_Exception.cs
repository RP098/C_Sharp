using System;
using System.Collections.Generic;
using System.Text;

namespace ObslugaWyjatkow
{
    class Original_Exception : ApplicationException
    {
        private string ExceptionMessage;
        public DateTime dateTimeException {get; set;}
        public string Cause_Error { get; set; }
        public Original_Exception() { }
        public Original_Exception(string ExceptionMessage,DateTime dateTimeException, string Cause_Error)
        {
            this.ExceptionMessage = ExceptionMessage;
            this.dateTimeException = dateTimeException;
            this.Cause_Error = Cause_Error;
        }

        public override string Message {
            get
            {
                return string.Format($"You must in next time {ExceptionMessage} \nYour Exception occured because {Cause_Error}\n Exception has been throw {dateTimeException} ");
            }
        
        }



    }
}
