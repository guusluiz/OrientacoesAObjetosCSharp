﻿using bytebank.Contas;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agência Central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "André Silva";
//conta2.conta = "10123-X";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pré-transferência: " + conta1.saldo);
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realidad com sucesso? " + transferencia);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pós-transferência: " + conta1.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Andre Silva";
//cliente.cpf = "1025341263";
//cliente.profissao = "Programador C#";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("N° Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("N° Agência = " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.SetSaldo(-10);
//conta3.Conta = "1011-H"; 
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);




////EU NÃO USEI O GET E SET ACIMA


//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();