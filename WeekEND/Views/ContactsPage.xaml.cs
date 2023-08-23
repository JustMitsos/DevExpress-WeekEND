namespace WeekEND.Views;

public partial class ContactsPage : ContentView
{
	public ContactsPage()
	{
		InitializeComponent();
	
	}

    private void btnEditContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EditContactPage));
    }

    private void btnAddContact_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));

    }
}