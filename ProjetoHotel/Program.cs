using ProjetoHotel;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(_nome: "Hospede 1", _sobrenome: "Cadastrado");
Pessoa p2 = new Pessoa(_nome: "Hospede 2", _sobrenome: "Registrado");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(_tipoSuite: "Presidencial", _capacidade: 1, _valorDiaria: 10);

Reserva reserva = new Reserva(_diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes registrados: {reserva.ObterQuantidadeDeHospedes()}");
Console.WriteLine($"Valor Diária: {reserva.CalcularValorDiaria()}");