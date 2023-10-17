namespace Saude360.Models
{
    public class Cadastro
    {
        public int id { get; set; }
        public string nomeUsuario { get; set; }
        public Enums genero { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }   
        public string telefone { get; set; }
        public string senha { get; set; }

    }
}
