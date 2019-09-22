// https://getbootstrap.com/docs/4.3/components/alerts/

namespace Pakohuone.Models.Bootstrap
{
    public class Alert
    {
        public Alert()
        {
        }

        public Alert(string text) =>
            (Text, Type) = (text, AlertType.Primary);

        public Alert(string text, AlertType type) =>
            (Text, Type) = (text, type);

        public string Text { get; set; }

        public AlertType Type { get; set; }
    }

    public enum AlertType
    {
        Primary,
        Secondary,
        Success,
        Danger,
        Warning,
        Info,
        Light,
        Dark
    }
}
