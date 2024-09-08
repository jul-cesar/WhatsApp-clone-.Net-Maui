
namespace whatsjose.Models
{
    public class ChatInfo
    {
        public string ImagePerfil { get; set; }  
        public string NombreChat { get; set; }

        public string LastMensaje {get; set;}
        public string LastTime { get; set; }

        public List<Message>? Messages { get; set; } 


    }
}
