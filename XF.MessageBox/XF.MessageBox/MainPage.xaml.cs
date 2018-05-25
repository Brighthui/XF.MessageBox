using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.MessageBox.PopupBox;

namespace XF.MessageBox
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();

            btnSuccess.Clicked += async (s, e) =>
            {
                var dialogRet = await PopupBox.MessageBox.ShowAsync("This is success Title",
                    "This is success message body",
                    PopupBox.MessageBoxButtons.OK,
                    PopupBox.MessageBoxIcon.Success);

                switch (dialogRet)
                {
                    case PopupBox.DialogResult.Abort:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Abort button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Cancel:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Cancel button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Ignore:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Ignore button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.No:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "No button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.None:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "None button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.OK:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "OK button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Retry:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Retry button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Yes:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Yes button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                }
            };

            btnInfo.Clicked += async (s, e) =>
            {
                var dialogRet = await PopupBox.MessageBox.ShowAsync("This is info Title",
                    "This is info message body",
                    PopupBox.MessageBoxButtons.OKCancel,
                    PopupBox.MessageBoxIcon.Info);
                switch (dialogRet)
                {
                    case PopupBox.DialogResult.Abort:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Abort button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Cancel:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Cancel button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Ignore:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Ignore button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.No:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "No button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.None:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "None button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.OK:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "OK button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Retry:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Retry button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Yes:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Yes button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                }
            };

            btnWarning.Clicked += async (s, e) =>
            {
                var dialogRet = await PopupBox.MessageBox.ShowAsync("This is warning Title",
                    "This is warning message body",
                    PopupBox.MessageBoxButtons.YesNoCancel,
                    PopupBox.MessageBoxIcon.Warning);
                switch (dialogRet)
                {
                    case PopupBox.DialogResult.Abort:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Abort button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Cancel:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Cancel button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Ignore:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Ignore button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.No:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "No button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.None:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "None button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.OK:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "OK button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Retry:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Retry button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Yes:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Yes button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                }
            };

            btnError.Clicked += async (s, e) =>
            {
                var dialogRet = await PopupBox.MessageBox.ShowAsync("This is error Title",
                    "This is error message body",
                    PopupBox.MessageBoxButtons.AbortRetryIgnore,
                    PopupBox.MessageBoxIcon.Danger);
                switch (dialogRet)
                {
                    case PopupBox.DialogResult.Abort:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Abort button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Cancel:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Cancel button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Ignore:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Ignore button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.No:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "No button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.None:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "None button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.OK:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "OK button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Retry:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Retry button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                    case PopupBox.DialogResult.Yes:
                        await PopupBox.MessageBox.ShowAsync("Button Respond",
                                                            "Yes button clicked",
                                                            PopupBox.MessageBoxButtons.OK,
                                                            PopupBox.MessageBoxIcon.Success);
                        break;

                }
            };


        }
    }
}
