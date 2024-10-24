using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia (numero: "1234", modelo: "model1", imei: "1111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone (numero: "5678", modelo: "model2", imei: "2222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Snapchat");