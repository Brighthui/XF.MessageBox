In Xamarin Forms application, we need popup message box like in Windows Desktop.

Thanks Rg.Plugins.Popup (https://github.com/rotorgames/Rg.Plugins.Popup/blob/master/README.md) project for its popup ability, now we can build our popup message like below.

You can place your popup message call anywhere in your Xamarin Forms .Net Standard project, i.e, view models, view other any public class.

A call can be simply like

            btnSuccess.Clicked += async (s, e) =>
            {
                var dialogRet = await PopupBox.MessageBox.ShowAsync("This is success Title",
                    "This is success message body",
                    PopupBox.MessageBoxButtons.OK,
                    PopupBox.MessageBoxIcon.Success);
                    
                    if ( dialogRet == PopupBox.DialogResult.Cancel)
                        return;
                        
                    ......
            };

Copy the PopupBox folder to your project and only fix the namespace (replace XF.MessageBox.PopupBox with your own namespace).

Beware that copy icon files to your Android, IOS and UWP projects resource folder.

Click 'Success Message' button will popup this box.

![success](https://user-images.githubusercontent.com/1282675/40561024-b2484ace-6029-11e8-8f0c-d10b6868a4bc.png)

Click 'Warning Message' button will popup this box.

![warning](https://user-images.githubusercontent.com/1282675/40561025-b25583e2-6029-11e8-97cd-22728fb4d2db.png)


Click 'Error Message' button will popup this box.

![error](https://user-images.githubusercontent.com/1282675/40561026-b266666c-6029-11e8-8e4c-7a26df4d244e.png)


Click 'Info Message' button will popup this box.

![info](https://user-images.githubusercontent.com/1282675/40561027-b273302c-6029-11e8-81c2-3fe30eb4b286.png)
