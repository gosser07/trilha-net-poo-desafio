using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "1234", iMEI: "56789", modelo: "tijolo", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("apptestenokia");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "4321", iMEI: "98765", modelo: "Pro Max", memoria: 16);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("apptesteIphone");
