using DesafioPOO.Models;

Iphone iphone = new Iphone ("123456", "X-pro", "987654321", 128);

iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");

Nokia nokia = new Nokia("78955130", "3310", "56449916", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("instagram");