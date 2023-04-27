namespace webApplicationFineCorso.Models
{
    public class LoginUser
    {
        
        public class LoginUtente : User
        {
            public bool ShowError { get; set; }

            public LoginUtente(bool showError)
            {
                ShowError = showError;
            }
        }
    }
}

