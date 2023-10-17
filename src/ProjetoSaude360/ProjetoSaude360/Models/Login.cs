namespace Saude360.Models
{
    public class Login:Cadastro
    {
        public Cadastro Email { get; set; }    
        public string Password { get; set; }
    }
}
