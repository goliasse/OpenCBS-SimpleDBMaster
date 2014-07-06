using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsFixedDepositException : OpenCbsException
    {

        private readonly string _message;
        private OpenCbsFixedDepositExceptionEnum _code;
        public OpenCbsFixedDepositExceptionEnum Code { get { return _code; } }

        protected OpenCbsFixedDepositException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsFixedDepositExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsFixedDepositException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsFixedDepositExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsFixedDepositException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsFixedDepositException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsFixedDepositExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {

            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsFixedDepositExceptionEnum
    {


    }
}
