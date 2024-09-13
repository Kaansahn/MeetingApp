namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Ali", Email = "ali@info.com", Phone = "11111", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Ahmet", Email = "ahmet@info.com", Phone = "22222", WillAttend = false });
            _users.Add(new UserInfo() { Name = "Mehmet", Email = "mehmet@info.com", Phone = "33333", WillAttend = true });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}