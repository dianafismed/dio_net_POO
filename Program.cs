using dio_net_POO.Models;

// Pessoa pessoa1 = new Pessoa("Vampiro", 330);
// pessoa1.Apresentar();

ContaCorrente conta1 = new ContaCorrente("123", 1000m);
conta1.ExibirSaldo();
conta1.Sacar(500m);
conta1.ExibirSaldo();