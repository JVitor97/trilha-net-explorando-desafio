namespace ProjetoHotel
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompletp { get => $"{Nome} {Sobrenome}".ToUpper(); }

        public Pessoa(string _nome, string _sobrenome)
        {
            Nome = _nome;
            Sobrenome = _sobrenome;
        }
    }

}
