using static Common.DefaultConstants;

namespace Contracts.Base
{
	public class BaseResponseModel : BaseModel
	{
        public Result Result { get; set; }
        public string Message { get; set; }
        #region Constructors
        public BaseResponseModel() { }
        #endregion
        public BaseResponseModel(Exception exp):base(exp)
		{
            Message = BaseModelUtilities<BaseModel>.ErrorFormat(exp).ErrorInfo;
            Result = Result.error;
        }
        public static BaseResponseModel ErrorFormat(Exception exp)
        {
            return new BaseResponseModel(exp);
        }
    }
}
