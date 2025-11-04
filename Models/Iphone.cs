namespace DesafioPOO.Models
{
    // Classe Iphone herda de Smartphone
    // Herda todas as propriedades e métodos da classe pai
    public class Iphone : Smartphone
    {
        // Construtor do iPhone que recebe os mesmos parâmetros
        // e passa para o construtor da classe pai usando 'base'
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o método abstrato da classe pai
        // Implementa a forma específica do iPhone instalar aplicativos
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na App Store");
        }
    }
}