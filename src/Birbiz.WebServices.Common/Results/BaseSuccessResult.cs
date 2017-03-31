namespace Birbiz.WebServices.Common.Results
{
    public class BaseSuccessResult : BaseResult
    {
        public override bool IsSuccess { get { return true; } }

        public override bool HasError { get { return false; } }

        public BaseSuccessResult(int statusCode) : base(statusCode)
        {
        }
    }
}