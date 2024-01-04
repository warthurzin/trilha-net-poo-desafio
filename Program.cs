using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "42501", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "27620", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");