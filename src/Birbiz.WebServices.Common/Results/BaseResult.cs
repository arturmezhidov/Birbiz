namespace Birbiz.WebServices.Common.Results
{
    public abstract class BaseResult
    {
        public int StatusCode { get; set; }

        public virtual bool IsSuccess { get; set; }

        public virtual bool HasError { get; set; }

        protected BaseResult(int statusCode)
        {
            StatusCode = statusCode;
        }
    }
}