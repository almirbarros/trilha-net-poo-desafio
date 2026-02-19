using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Tijolo", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");
nokia.ReceberLigacao();

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "789123", modelo: "Modelo Laranja", imei: "7777777", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

