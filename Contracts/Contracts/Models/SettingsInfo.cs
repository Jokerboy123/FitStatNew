namespace Contracts.Models {
    public class SettingsInfo {
        public SettingsInfo(string pathToApplication)
        {
            ApplicationPath = pathToApplication;
        }
        public string ApplicationPath { get; }
        /*public const string DefaultProductImage = ".jpg";
        public const string DefaultUserImage = ".jpg";*/
#if DEBUG
        public string WebSiteBaseUrl { get; set; } = "http://192.168.0.186:7101"; //TODO: Возможно нужно изменить IP.
#else
        public string WebSiteBaseUrl { get; set; } = "https://www.j-fit.ru";
#endif
        public string ApiVersionKey { get; set; } = "v1.0";
    }
}