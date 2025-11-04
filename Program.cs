using DesafioPOO.Models;

// Teste com Nokia
Console.WriteLine("Smartphone Nokia:");

// Cria uma instância de Nokia
// Polimorfismo: variável do tipo Smartphone recebe um objeto Nokia
Smartphone nokia = new Nokia(
    numero: "11999999999",
    modelo: "Nokia 3310",
    imei: "987456321789456",
    memoria: 64
);

// Testa os métodos herdados da classe Smartphone
nokia.Ligar();
nokia.ReceberLigacao();

// Testa o método sobrescrito específico da Nokia
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n"); // Linha em branco para separar os testes

// Teste com iPhone
Console.WriteLine("Smartphone iPhone:");

// Cria uma instância de Iphone
// Polimorfismo: variável do tipo Smartphone recebe um objeto Iphone
Smartphone iphone = new Iphone(
    numero: "21999999999",
    modelo: "iPhone 14",
    imei: "123456789123456",
    memoria: 128
);

// Testa os métodos herdados da classe Smartphone
iphone.Ligar();
iphone.ReceberLigacao();

// Testa o método sobrescrito específico do iPhone
iphone.InstalarAplicativo("Telegram");