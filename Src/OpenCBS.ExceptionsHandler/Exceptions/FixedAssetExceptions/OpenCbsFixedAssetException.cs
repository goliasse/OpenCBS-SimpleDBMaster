using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsFixedAssetException : OpenCbsException
    {
        private readonly string _message;
        private OpenCbsFixedAssetExceptionEnum _code;
        public OpenCbsFixedAssetExceptionEnum Code { get { return _code; } }

        protected OpenCbsFixedAssetException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsFixedAssetExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsFixedAssetException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsFixedAssetExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsFixedAssetException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsFixedAssetException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsFixedAssetExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {

            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsFixedAssetExceptionEnum
    {


    }
}