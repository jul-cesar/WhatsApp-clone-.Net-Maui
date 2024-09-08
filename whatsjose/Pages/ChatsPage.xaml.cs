using System.Collections.ObjectModel;
using whatsjose.Models;

namespace whatsjose.Pages;

public partial class ChatsPage : ContentPage
{
    public ObservableCollection<ChatInfo> Chats { get; set; }

    public ChatsPage()
	{
		InitializeComponent();
        Chats = new ObservableCollection<ChatInfo>();


        Chats.Add(new ChatInfo
        {
            ImagePerfil = "flor",
            NombreChat = "andres jose",
            LastMensaje = "Hola, me gustan los perro",
            LastTime = "4:20 PM",
             Messages = new List<Message>
             {
                 new Message
                 {
                     Contenido = "hola",
                     Date = "9:46 pm"
                 },
                  new Message
                 {
                     Contenido = "hola",
                     Date = "9:46 pm"
                 },
                   new Message
                 {
                     Contenido = "hola",
                     Date = "9:46 pm"
                 },
             }

        }


           );
        Chats.Add(new ChatInfo
        {
            ImagePerfil = "joy",
            NombreChat = "luis jose",
            LastMensaje = "Hola, me gustan los xd",
            LastTime = "9:23 AM"

        }


           );
        Chats.Add(new ChatInfo
        {
            ImagePerfil = "blank",
            NombreChat = "alex betun",
            LastMensaje = "Hola, me gustan los betunes",
            LastTime = "7:09 PM"

        }


           );
        Chats.Add(new ChatInfo
        {
            ImagePerfil = "flor",
            NombreChat = "Jose guillermo",
            LastMensaje = "Hola, me gustan los gatitos",
            LastTime = "7:30 AM"
        });

        Chats.Add(new ChatInfo
        {
            ImagePerfil = "jaj",
            NombreChat = "andres jose",
            LastMensaje = "Hola, me gustan los perros",
            LastTime = "4:20 PM"
        });


        Chats.Add(new ChatInfo
        {
            ImagePerfil = "flor",
            NombreChat = "andres jose",
            LastMensaje = "Hola, me gustan los perro",
            LastTime = "4:20 PM"

        }


           );
        Chats.Add(new ChatInfo
        {
            ImagePerfil = "joy",
            NombreChat = "luis jose",
            LastMensaje = "Hola, me gustan los xd",
            LastTime = "9:23 AM"

        }


           );
        Chats.Add(new ChatInfo
        {
            ImagePerfil = "blank",
            NombreChat = "alex betun",
            LastMensaje = "Hola, me gustan los betunes",
            LastTime = "7:09 PM"

        }


           );
        Chats.Add(new ChatInfo
        {
            ImagePerfil = "flor",
            NombreChat = "Jose guillermo",
            LastMensaje = "Hola, me gustan los gatitos",
            LastTime = "7:30 AM"
        });

        Chats.Add(new ChatInfo
        {
            ImagePerfil = "jaj",
            NombreChat = "andres jose",
            LastMensaje = "Hola, me gustan los perros",
            LastTime = "4:20 PM",
            
        });




        this.BindingContext = this;
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if(cv.SelectedItem != null)
        {
            cv.SelectedItem = null;

            ChatInfo? selectedItem = (ChatInfo)e.CurrentSelection.FirstOrDefault();

            MessagesPage msgPage = new MessagesPage(selectedItem);
           await Navigation.PushAsync(msgPage);
        }

      
    }
   
}