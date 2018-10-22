using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDockerizedNetCoreWithPostgreSql
{
    public class ApiResult<T> where T : class
    {
        public ApiResult()
        { }

        public ApiResult(T data)
        {
            Data = data;
        }

        public ApiResult(Error error)
        {
            Error = Error;
        }

        public T Data { get; set; }
        public Error Error { get; set; }
    }

    public class Error
    {
        public string Message { get; set; }
    }

    public class Error<T> : Error where T : class
    {
        public T AdditionalData { get; set; }
    }
}
