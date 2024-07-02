
namespace Oyster.Exceptions
{


    public class FareException : Exception
    {
        public FareException() { }

        public FareException(string message) : base(message) { }

        public FareException(string message, Exception innerException) : base(message, innerException) { }

      
    }




}
