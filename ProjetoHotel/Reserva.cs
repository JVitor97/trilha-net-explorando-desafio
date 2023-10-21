namespace ProjetoHotel
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int _diasReservados)
        {
            DiasReservados = _diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            
            else
            {
                throw new Exception("Capacidade excedida. O número de hóspedes excede a capacidade limite da suíte escolhida");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count;            
        }

        public decimal CalcularValorDiaria()
        {
            decimal calculo = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                calculo = calculo - (calculo * (decimal)0.1);
            }

            return calculo;
        }
    }
}
