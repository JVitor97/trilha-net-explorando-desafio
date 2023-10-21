namespace ProjetoHotel
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set;}
        public decimal ValorDiaria { get; set; }

        public Suite(string _tipoSuite, int _capacidade, decimal _valorDiaria)
        {
            TipoSuite = _tipoSuite;
            Capacidade = _capacidade;
            ValorDiaria = _valorDiaria;
        }
    }
}
