using System;

namespace StandardUtils.Models.Requests
{
    public abstract class BaseRequest
    {
        protected void ThrowArgumentException(string argumentName, object value)
        {
            throw new ArgumentException(argumentName + " => " + value);
        }
    }
}