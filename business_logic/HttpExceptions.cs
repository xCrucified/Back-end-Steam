using System.Net;
using System.Runtime.Serialization;

namespace business_logic
{
    [Serializable]
    public class HttpExceptions : Exception
    {
        public HttpStatusCode Status { get; set; }
        public HttpExceptions(HttpStatusCode status)
        {
            Status = status;
        }

        public HttpExceptions(string? message, HttpStatusCode status) : base(message)
        {
            Status = status;
        }

        public HttpExceptions(string? message, HttpStatusCode status, Exception? innerException) : base(message, innerException)
        {
            Status = status;
        }

        protected HttpExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
