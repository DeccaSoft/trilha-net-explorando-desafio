using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();
List<Pessoa> hospedes2 = new List<Pessoa>();
List<Pessoa> hospedes3 = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Fulano", sobrenome: "da Silva");
Pessoa p4 = new Pessoa(nome: "Sicrano", sobrenome: "Sauro");
Pessoa p5 = new Pessoa(nome: "Beltrano", sobrenome: "da Silva Sauro");
Pessoa p6 = new Pessoa(nome: "Coisinha", sobrenome: "de Jesus");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes2.Add(p3);
hospedes3.Add(p4);
hospedes3.Add(p5);
hospedes3.Add(p6);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suite2 = new Suite(tipoSuite: "Especial", capacidade: 3, valorDiaria: 45);
Suite suite3 = new Suite(tipoSuite: "Master", capacidade: 4, valorDiaria: 60);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Reserva reserva2 = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite2);
reserva.CadastrarHospedes(hospedes2);

Reserva reserva3 = new Reserva(diasReservados: 15);
reserva.CadastrarSuite(suite3);
reserva.CadastrarHospedes(hospedes2);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");

Console.WriteLine($"Hóspedes: {reserva3.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva3.CalcularValorDiaria()}");