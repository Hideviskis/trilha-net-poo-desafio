using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i = new Iphone("12982395243", "Iphone 15","1234", 8);
Nokia n = new Nokia("12982395243", "WindowsPhone","1234", 4);

//Iphone
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Instagram");

//Nokia
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Whatsapp");