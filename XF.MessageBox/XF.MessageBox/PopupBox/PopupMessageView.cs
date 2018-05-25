using System;
using Xamarin.Forms;

namespace XF.MessageBox.PopupBox
{
    public class PopupMessageView : ContentView
    {
        // public event handler to expose 
        // the Save button's click event
        public EventHandler ButtonEventHandler { get; set; }

        public DialogResult Result { get; set; }

        public PopupMessageView(string Title, string Message, MessageBoxButtons DisplayButtons, MessageBoxIcon DisplayIcon)
        {
            var labTitle = new Label
            {
                Text = Title,
                Margin = new Thickness(24, 12, 12, 12),
                HorizontalTextAlignment = TextAlignment.Start
            };
            if (DisplayIcon == MessageBoxIcon.Danger)
                labTitle.TextColor = ColorConstants.AlertDangerText;
            else if (DisplayIcon == MessageBoxIcon.Info)
                labTitle.TextColor = ColorConstants.AlertInfoText;
            else if (DisplayIcon == MessageBoxIcon.Success)
                labTitle.TextColor = ColorConstants.AlertSuccessText;
            else if (DisplayIcon == MessageBoxIcon.Warning)
                labTitle.TextColor = ColorConstants.AlertWarningText;

            var boxLine = new BoxView
            {
                HeightRequest = 3,
                VerticalOptions = LayoutOptions.Center,
                Opacity = 0.5,
                Color = Color.DarkBlue
            };
            if (DisplayIcon == MessageBoxIcon.Danger)
                boxLine.Color = ColorConstants.AlertDangerBar;
            else if (DisplayIcon == MessageBoxIcon.Info)
                boxLine.Color = ColorConstants.AlertInfoBar;
            else if (DisplayIcon == MessageBoxIcon.Success)
                boxLine.Color = ColorConstants.AlertSuccessBar;
            else if (DisplayIcon == MessageBoxIcon.Warning)
                boxLine.Color = ColorConstants.AlertWarningBar;

            var imgSign = new Image
            {
                HeightRequest = 50,
                WidthRequest = 50,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };
            if (DisplayIcon == MessageBoxIcon.Danger)
                imgSign.Source = ImageSource.FromFile("error.png");
            else if (DisplayIcon == MessageBoxIcon.Info)
                imgSign.Source = ImageSource.FromFile("info.png");
            else if (DisplayIcon == MessageBoxIcon.Success)
                imgSign.Source = ImageSource.FromFile("success.png");
            else if (DisplayIcon == MessageBoxIcon.Warning)
                imgSign.Source = ImageSource.FromFile("warning.png");

            var labMsg = new Label
            {
                Text = Message,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            if (DisplayIcon == MessageBoxIcon.Danger)
                labMsg.TextColor = ColorConstants.AlertDangerText;
            else if (DisplayIcon == MessageBoxIcon.Info)
                labMsg.TextColor = ColorConstants.AlertInfoText;
            else if (DisplayIcon == MessageBoxIcon.Success)
                labMsg.TextColor = ColorConstants.AlertSuccessText;
            else if (DisplayIcon == MessageBoxIcon.Warning)
                labMsg.TextColor = ColorConstants.AlertWarningText;


            var stMsg = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(24, 12, 24, 12)
            };

            stMsg.Children.Add(imgSign);
            stMsg.Children.Add(labMsg);

            var btnAbort = new Button
            {
                WidthRequest = 100,
                Text = "Abort"
            };

            var btnCancel = new Button
            {
                WidthRequest = 100,
                Text = "Cancel"
            };

            var btnIgnore = new Button
            {
                WidthRequest = 100,
                Text = "Ignore"
            };

            var btnNo = new Button
            {
                WidthRequest = 100,
                Text = "No"
            };

            var btnNone = new Button
            {
                WidthRequest = 100,
                Text = "None"
            };

            var btnOK = new Button
            {
                WidthRequest = 100,
                Text = "OK"
            };

            var btnRetry = new Button
            {
                WidthRequest = 100,
                Text = "Retry"
            };

            var btnYes = new Button
            {
                WidthRequest = 100,
                Text = "Yes"
            };

            var gridButtons = new Grid
            {
                //BackgroundColor = Color.Honeydew
            };
            if (DisplayIcon == MessageBoxIcon.Danger)
                gridButtons.BackgroundColor = ColorConstants.AlertDangerBorder;
            else if (DisplayIcon == MessageBoxIcon.Info)
                gridButtons.BackgroundColor = ColorConstants.AlertInfoBorder;
            else if (DisplayIcon == MessageBoxIcon.Success)
                gridButtons.BackgroundColor = ColorConstants.AlertSuccessBorder;
            else if (DisplayIcon == MessageBoxIcon.Warning)
                gridButtons.BackgroundColor = ColorConstants.AlertWarningBorder;

            switch (DisplayButtons)
            {
                case MessageBoxButtons.AbortRetryIgnore:
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.Children.Add(btnAbort, 2, 0);
                    gridButtons.Children.Add(btnRetry, 3, 0);
                    gridButtons.Children.Add(btnIgnore, 4, 0);
                    break;

                case MessageBoxButtons.OK:
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.Children.Add(btnOK, 1, 0);
                    break;

                case MessageBoxButtons.OKCancel:
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.Children.Add(btnOK, 2, 0);
                    gridButtons.Children.Add(btnCancel, 3, 0);
                    break;

                case MessageBoxButtons.RetryCancel:
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.Children.Add(btnRetry, 2, 0);
                    gridButtons.Children.Add(btnCancel, 3, 0);
                    break;

                case MessageBoxButtons.YesNo:
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.Children.Add(btnYes, 2, 0);
                    gridButtons.Children.Add(btnNo, 3, 0);
                    break;

                case MessageBoxButtons.YesNoCancel:
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                    gridButtons.Children.Add(btnYes, 2, 0);
                    gridButtons.Children.Add(btnNo, 3, 0);
                    gridButtons.Children.Add(btnCancel, 4, 0);
                    break;
            }


            var stMain = new StackLayout
            {
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            if (DisplayIcon == MessageBoxIcon.Danger)
                stMain.BackgroundColor = ColorConstants.AlertDangerBackground;
            else if (DisplayIcon == MessageBoxIcon.Info)
                stMain.BackgroundColor = ColorConstants.AlertInfoBackground;
            else if (DisplayIcon == MessageBoxIcon.Success)
                stMain.BackgroundColor = ColorConstants.AlertSuccessBackground;
            else if (DisplayIcon == MessageBoxIcon.Warning)
                stMain.BackgroundColor = ColorConstants.AlertWarningBackground;

            stMain.Children.Add(labTitle);
            stMain.Children.Add(boxLine);
            stMain.Children.Add(stMsg);
            stMain.Children.Add(gridButtons);

            Content = stMain;

            btnAbort.Clicked += (s, e) =>
            {
                // invoke the event handler if its being subscribed
                Result = DialogResult.Abort;
                ButtonEventHandler?.Invoke(this, e);
            };

            btnCancel.Clicked += (s, e) =>
            {
                Result = DialogResult.Cancel;
                ButtonEventHandler?.Invoke(this, e);
            };

            btnIgnore.Clicked += (s, e) =>
            {
                Result = DialogResult.Ignore;
                ButtonEventHandler?.Invoke(this, e);
            };

            btnNo.Clicked += (s, e) =>
            {
                Result = DialogResult.No;
                ButtonEventHandler?.Invoke(this, e);
            };

            btnNone.Clicked += (s, e) =>
            {
                Result = DialogResult.None;
                ButtonEventHandler?.Invoke(this, e);
            };

            btnOK.Clicked += (s, e) =>
            {
                Result = DialogResult.OK;
                ButtonEventHandler?.Invoke(this, e);
            };

            btnRetry.Clicked += (s, e) =>
            {
                Result = DialogResult.Retry;
                ButtonEventHandler?.Invoke(this, e);
            };

            btnYes.Clicked += (s, e) =>
            {
                Result = DialogResult.Yes;
                ButtonEventHandler?.Invoke(this, e);
            };

        }
    }
}
