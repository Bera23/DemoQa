using NUnit.Framework;

namespace DemoQa.Tests
{
    public class SampleTest : BaseTest
    {
        [Test]
        public void HomePage()
        {
            Scroll(150, 0);
            homePage.ElementsHomePage();
            homePage.ElementTextBox();
            Assert.AreEqual("Text Boxx", homePage.GetHeader().ToString());

           /* textBox.FullName("Uros Beric");
            textBox.Email("uros.beric@seavus.com");
            textBox.CurrentAddress("Beograd");
            textBox.PermanentAddress("Beograd");
            Scroll(300, 0);
            textBox.SubmitButton();
            textBox.ElementCheckBox();

            checkBox.ToggleHome();
            checkBox.ToggleDownloads();
            checkBox.CheckBoxDownloads();
            checkBox.CollapseAll();
            checkBox.ElementRadioBtn();

            radioButton.PressYesButton();
            radioButton.ElementWebTables();
            Scroll(300, 0);

            webtables.AddNewRecordButton();
            webtables.FirstName("Uros");
            webtables.LastName("Beric");
            webtables.Email("uros.beric@seavus.com");
            webtables.Age("25");
            webtables.Salary("800");
            webtables.Department("Banking");
            webtables.SubmitBtn();
            webtables.DeleteRecord();
            webtables.SearchBox("Uros");
            webtables.EditRecord();
            webtables.ClearSalary();
            webtables.EditSalary("1100");
            webtables.SubmitBtnEdit();
            Scroll(100, 0);
            webtables.ElementButtons();

            Scroll(0, 0);
            buttons.DoubleClick();
            buttons.RightClick();
            buttons.ClickBtn();
            Scroll(200, 0);
            buttons.ElementLinks();

            Scroll(0, 0);
            links.HomeLink();
            SwitchTab(0);
            links.HomeLink2();
            SwitchTab(0);
            Scroll(150, 0);
            links.Created();
            links.NoContent();
            links.Moved();
            links.BadRequest();
            links.Unauthorized();
            links.Forbidden();
            links.NotFound();
            Scroll(250, 0);
            links.ElementBrokenLinks();

            Scroll(100, 0);
            brokenLinks.ValidLink();
            GoBack();
            Scroll(100, 0);
            brokenLinks.BrokenLink(); //chrome
            GoBack();
            Scroll(300, 0);
            brokenLinks.ElementUploadAndDownload();

            //uploadDownload.DownloadBtn();  //download file
            uploadDownload.UploadBtn(@"C:\Users\Uros.Beric\Desktop\C#\DemoQa\DemoQa\File\Screenshot_1.png");
            Scroll(400, 0);
            uploadDownload.ElementDynamicProperties();

            CloseAds();
            HideElements();

            dynamicProperties.EnableBtn();
            dynamicProperties.ChangeColorBtn();
            dynamicProperties.VisibleAfterBtn();
            Scroll(550, 0);
            dynamicProperties.Forms();
            dynamicProperties.PracticeFormsForm();

            Scroll(50, 0);
            practiceForm.FirstName("Uros");
            practiceForm.LastName("Beric");
            practiceForm.Email("uros.beric@seavus.com");
            practiceForm.PressMaleButton();
            practiceForm.MobileNumber("0620640752");
            Scroll(10, 0);
            practiceForm.DateOfBirth();
            practiceForm.YearOfBirth();
            practiceForm.PickYear();
            practiceForm.MonthOfBirth();
            practiceForm.PickMonth();
            practiceForm.PickDay();
            Scroll(200, 0);
            practiceForm.Hobbies();
            practiceForm.SubmitBtn();
            practiceForm.CloseBtn();



            practiceForm.AlertsFrameWindows();
            practiceForm.AlertsBrowserWindows();

            browserWindows.NewTab();
            SwitchTab(0);
            browserWindows.NewWindow();
            SwitchTab(0);
            browserWindows.NewWindowMessage();
            SwitchTab(0);
            Scroll(200, 0);
            browserWindows.Alerts();

            alerts.Alert();
            PressAlert();
            alerts.AlertWait();
            PressAlert();
            alerts.ComfirmAlert();
            PressAlert();
            alerts.PromptAlert();
            TextAlert("Uros");
            PressAlert();
            Scroll(300, 0);
            alerts.AlertFrames();
            Scroll(200, 0);
            alerts.AlertNestedFrames();
            Scroll(200, 0);
            alerts.AlertModealDialogs();


            modalDialogs.SmallModal();
            modalDialogs.CloseSmall();
            modalDialogs.LargeModal();  //chrome
            modalDialogs.CloseLarge();
            Scroll(300, 0);
            modalDialogs.Widgets();
            Scroll(300, 0);
            modalDialogs.WidgetsAccordian();

            accordian.Section2();
            Scroll(200, 0);
            accordian.Section3();
            accordian.WidgetsAutoComplete();
            Scroll(150, 0);

            //autoComplete.MultipleColorClick();
            // autoComplete.MultipleColor("y");
            // autoComplete.MultipleColorEnter();
            autoComplete.WidgetsDatePicker();

            datePicker.SelectDate();
            datePicker.SelectYear();
            datePicker.PickYear();
            datePicker.SelectMonth();
            datePicker.PickMonth();
            datePicker.PickDay();
            datePicker.DateAndTimePickerInput();
            datePicker.SelectYearDateTime();
            datePicker.PickYearDateTime();
            datePicker.PickTIme();
            Scroll(300, 0);
            datePicker.WidgetsSlider();

            slider.ClickSlider();
            slider.MoveSlider(39);
            Scroll(300, 0);
            slider.WidgetsProgressBar();

            progressBar.StartProgressBar();
            progressBar.StopProgressBar();
            Scroll(350, 0);
            progressBar.WidgetsTabs();

            tabs.OriginTab();
            tabs.UseTab();
            tabs.WhatTab();
            Scroll(450, 0);
            tabs.WidgetsToolTip();

            toolTips.HoverButton();
            toolTips.HoverTextField();
            toolTips.HoverText();
            Scroll(550, 0);
            toolTips.WidgetsMenu();

            menu.MainItem2(); //fireFox chrome
            menu.SubList();
            menu.SubItem2();
            Scroll(750, 0);
            menu.WidgetsSelectMeny();


            selectMenu.SelectOption();
            selectMenu.PickOptions();
            selectMenu.SelectOne();
            selectMenu.PickOne();
            selectMenu.Multiselect();
            selectMenu.PickMultiSelect();
            selectMenu.StandardMultiSelect();
            Scroll(-200, 0);
            selectMenu.CloseWidgets();
            Scroll(250, 0);
            selectMenu.OpenInteractions(); //chrome
            selectMenu.InteractionsSortable();

            sortable.DragSixOnOne();
            sortable.DragTwoOnFour();
            sortable.Grid();
            sortable.DragThreeToSeven();
            Scroll(500, 0);
            sortable.InteractionsSelectable();

            selectable.ListFour();
            selectable.ListTwo();
            selectable.Grid();
            selectable.GridFive();
            selectable.GridNine();
            Scroll(500, 0);
            selectable.InteractionsResizable();

            resizable.ResizableBox(300, 250);  //fireFox
            Scroll(300, 0);
            resizable.ResizableBoxBig(500, 100);
            Scroll(100, 0);
            resizable.InteractionsDroppable();


            droppable.SimpleDropBox(); //fireFox
            droppable.AcceptTab();
            droppable.AcceptableDropBox();
            droppable.PreventTab();
            droppable.PreventDropBoxOuter();
            Scroll(200, 0);
            droppable.PreventDropBoxOuterDrop();
            droppable.RevertTab();
            droppable.WillRevert();
            droppable.NotRevert();
            Scroll(500, 0);
            droppable.InteractionsDragabble();

            dragabble.SimpleDropBox(320, 150);  //fireFox
            dragabble.AxisTab();
            dragabble.XDrag(200);
            dragabble.YDrag(100);
            dragabble.ContainerTab();
            dragabble.ContainerBox(500, 200);
            Scroll(100, 0);
            dragabble.ContainerParent(20, 20);
            Scroll(500, 0);
            dragabble.BookStore();  //chrome
            dragabble.LoginBS();
            Scroll(-500, 0);

            login.NewUserBtn();


            /* register.FirstName("Uros");
              register.LastName("Beric");
              register.UserName("Bera2");
              register.Password("Ratimir233@");
              register.Captcha();
              DefaultFrame();
              register.RegisterBtn();
              PressAlert();
              
            register.GoToLoginBtn();
            login.UserName("Bera2");
            login.Password("Ratimir233@");
            login.LoginBtn();

            profile.GoToStore();

            bookStore.PickBook();
            Scroll(300, 0);
            bookStore.AddToCollection();
            PressAlert();
            bookStore.GoBack();
            Scroll(300, 0);
            bookStore.Profil();*/
        }
    }
}
