using Rg.Plugins.Popup.Pages;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.MessageBox.PopupBox
{
    //Reference document
    //https://theconfuzedsourcecode.wordpress.com/2017/07/26/an-await-able-transparent-custom-popup-input-dialog-in-xamarin-forms/
    public class PopupDialogBase<T> : PopupPage
    {
        // the awaitable task
        public Task<T> PageClosedTask { get { return PageClosedTaskCompletionSource.Task; } }

        // the task completion source
        public TaskCompletionSource<T> PageClosedTaskCompletionSource { get; set; }

        public PopupDialogBase(View contentBody)
        {
            Content = contentBody;

            // init the task completion source
            PageClosedTaskCompletionSource = new System.Threading.Tasks.TaskCompletionSource<T>();

            this.BackgroundColor = new Color(0, 0, 0, 0.4);
        }

        // Method for animation child in PopupPage
        // Invoced after custom animation end
        protected override void OnAppearingAnimationEnd()
        {
            Content.FadeTo(1);
            base.OnAppearingAnimationEnd();
        }

        // Method for animation child in PopupPage
        // Invoked before custom animation begin
        protected override void OnDisappearingAnimationBegin()
        {
            Content.FadeTo(1);
            base.OnDisappearingAnimationBegin();
        }

        protected override bool OnBackButtonPressed()
        {
            // Prevent back button pressed action on android
            //return base.OnBackButtonPressed();
            return true;
        }

        // Invoced when background is clicked
        protected override bool OnBackgroundClicked()
        {
            // Prevent background clicked action
            //return base.OnBackgroundClicked();
            return false;
        }
    }
}
