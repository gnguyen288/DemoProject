namespace Configuration.Config
{
    public class LoginSettings
    {
        public static string[] User
        {

            get
            {
                string[] logininfo = new string[4];
                logininfo[0] = ConfigurationManager.GetJsonConfig.FirstName;
                logininfo[1] = ConfigurationManager.GetJsonConfig.LastName;
                logininfo[2] = ConfigurationManager.GetJsonConfig.UserName;
                logininfo[3] = ConfigurationManager.GetJsonConfig.Password;
                return logininfo;
            }
        }
    }
}
