namespace Web
{
    public class Themes
    {
        internal static string Neutral { get; } = "theme-neutral";
        internal static string Primary { get; } = "theme-primary";
        internal static string Danger { get; } = "theme-danger";

        internal static string NeutralHover => Neutral + "_h";
        internal static string PrimaryHover => Primary + "_h";
        internal static string DangerHover => Danger + "_h";
    }
}
