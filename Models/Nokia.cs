namespace DesafioPOO.Models
{
    // Classe Nokia herda de Smartphone (usando :)
    // Herda todas as propriedades e métodos da classe pai
    public class Nokia : Smartphone
    {
        // Construtor da Nokia que recebe os mesmos parâmetros
        // e passa para o construtor da classe pai usando 'base'
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescreve o método abstrato da classe pai
        // Implementa a forma específica da Nokia instalar aplicativos
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na Nokia Store");
        }
    }
}