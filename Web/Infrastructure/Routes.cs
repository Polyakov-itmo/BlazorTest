namespace Web.Infrastructure
{
    public static class Routes
    {
        public static string User { get; } = "/users";
        public static string UserCreate => User + "/create";


        public static string Todo { get; } = "/todos";
    }
}
