using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsCARException : OpenCbsException
    {
        private readonly string _message;
        private OpenCbsCARExceptionEnum _code;
        public OpenCbsCARExceptionEnum Code { get { return _code; } }

        protected OpenCbsCARException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsCARExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsCARException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsCARExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsCARException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsCARException(OpenCbsCARExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsCARException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsCARExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {
                 
            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsCARExceptionEnum
    {
        

    }
    }
