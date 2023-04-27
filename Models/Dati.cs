namespace webApplicationFineCorso.Models
{
    public static class Dati
    {
        static List<User> UserList = new List<User>()
        {
            new User("aaa@gmail.com", "ciao"),
            new User("bbb@gmail.com","ciao"),
            new User("ccc@gmail.com","ciao")
        };
    }
    public static string Login(string email)
    {
        var user = listaUser.FirstOrDefault(l => l.email == email);

        if (user != null)
        {
            return "00000";
        }
        else return "0";
    }
}
