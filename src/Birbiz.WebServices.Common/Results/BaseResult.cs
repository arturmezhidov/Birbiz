namespace Birbiz.WebServices.Common.Results
{
    public abstract class BaseResult
    {
        public virtual int StatusCode { get; set; }

        public virtual bool IsSuccess { get; set; }

        public virtual bool HasError { get; set; }
    }
}