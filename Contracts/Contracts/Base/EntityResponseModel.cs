using Common;

namespace Contracts.Base {
    public class EntityResponseModel<TViewModel> : BaseResponseModel where TViewModel : class {
		#region Properties
		public TViewModel Entity { get; set; }
		#endregion

		#region Constructors
		public EntityResponseModel() { }
		#endregion
	}
    public static class BaseResponseModelUtilities<T>
       where T : BaseResponseModel, new() {
        public static T DataFormat(T CurrentData) {
            CurrentData.Result = DefaultConstants.Result.ok;
            return CurrentData;
        }

        public static T ErrorFormat(Exception exp) {
            return new T() { Message = BaseModelUtilities<T>.ErrorFormat(exp).ErrorInfo, Result = DefaultConstants.Result.error };
        }
    }
}