using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "99997777", modelo: "Modelo A", imei: "00010007", memoria: 128 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "99000107", modelo: "Modelo B", imei: "00020007", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");