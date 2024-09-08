using whatsjose.Models;

namespace whatsjose.Pages;

public partial class MessagesPage : ContentPage
{

	public ChatInfo chatInfo { get; set; }
	public MessagesPage(ChatInfo chatSelected)
	{
		InitializeComponent();
		chatInfo = chatSelected;
		this.BindingContext = this;
	}
}