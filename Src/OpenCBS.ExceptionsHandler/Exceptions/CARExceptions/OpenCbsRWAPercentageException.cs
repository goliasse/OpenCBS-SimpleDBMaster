using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsRWAPercentageException : OpenCbsException
    {
        private readonly string _message;
        private OpenCbsRWAPercentageExceptionEnum _code;
        public OpenCbsRWAPercentageExceptionEnum Code { get { return _code; } }

        protected OpenCbsRWAPercentageException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsRWAPercentageExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsRWAPercentageException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsRWAPercentageExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsRWAPercentageException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsRWAPercentageException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsRWAPercentageExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {

            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsRWAPercentageExceptionEnum
    {


    }
}
