using Rg.Plugins.Popup.Services;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.MessageBox.PopupBox
{
    public class MessageBox
    {
        public static async Task<DialogResult> ShowAsync(string Title, string Message, MessageBoxButtons DisplayButtons = MessageBoxButtons.OK, MessageBoxIcon DisplayIcon = MessageBoxIcon.Info)
        {
            var MessageView = new PopupMessageView(Title, Message, DisplayButtons, DisplayIcon);
            var popup = new PopupDialogBase<DialogResult>(MessageView);

            MessageView.ButtonEventHandler += (s, e) =>
            {
                popup.PageClosedTaskCompletionSource.SetResult(((PopupMessageView)s).Result);
            };

            await PopupNavigation.Instance.PushAsync(popup);
            //await PopupNavigation.PushAsync(popup);

            var result = await popup.PageClosedTask;

            await PopupNavigation.Instance.PopAsync();

            return result;
        }
    }


    public enum DialogResult
    {
        Abort,
        Cancel,
        Ignore,
        No,
        None,
        OK,
        Retry,
        Yes
    };

    public enum MessageBoxButtons
    {
        AbortRetryIgnore,
        OK,
        OKCancel,
        RetryCancel,
        YesNo,
        YesNoCancel
    }

    public enum MessageBoxIcon
    {
        Success,
        Info,
        Warning,
        Danger
    }

    public static class ColorConstants
    {
        public static Color AlertSuccessBackground = Color.FromHex("dff0d8");
        public static Color AlertSuccessText = Color.FromHex("3c763d");
        public static Color AlertSuccessBorder = Color.FromHex("d0e9c6");
        public static Color AlertSuccessBar = Color.FromHex("5a7052");

        public static Color AlertInfoBackground = Color.FromHex("d9edf7");
        public static Color AlertInfoText = Color.FromHex("31708f");
        public static Color AlertInfoBorder = Color.FromHex("bcdff1");
        public static Color AlertInfoBar = Color.FromHex("4480ae");

        public static Color AlertWarningBackground = Color.FromHex("fcf8e3");
        public static Color AlertWarningText = Color.FromHex("8a6d3b");
        public static Color AlertWarningBorder = Color.FromHex("faf2cc");
        public static Color AlertWarningBar = Color.FromHex("967132");

        public static Color AlertDangerBackground = Color.FromHex("f2dede");
        public static Color AlertDangerText = Color.FromHex("a94442");
        public static Color AlertDangerBorder = Color.FromHex("ebcccc");
        public static Color AlertDangerBar = Color.FromHex("b32f2d");

    }
}
