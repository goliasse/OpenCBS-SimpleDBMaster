using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler.Exceptions.CurrentAccountExceptions
{
    [Serializable]
    public class OpenCbsCurrentAcccountTransactionException : OpenCbsException
    {
         private readonly string _message;
        private OpenCbsCurrentAcccountTransactionExceptionEnum _code;
        public OpenCbsCurrentAcccountTransactionExceptionEnum Code { get { return _code; } }

        protected OpenCbsCurrentAcccountTransactionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsCurrentAcccountTransactionExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsCurrentAcccountTransactionException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsCurrentAcccountTransactionExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsCurrentAcccountTransactionException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsCurrentAcccountTransactionException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsCurrentAcccountTransactionExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {

            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsCurrentAcccountTransactionExceptionEnum
    {


    }
    
}