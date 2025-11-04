namespace DesafioPOO.Models
{
    // Classe abstrata que serve como modelo base para todos os smartphones
    // Não pode ser instanciada diretamente
    public abstract class Smartphone
    {
        // Propriedade pública - pode ser acessada e modificada
        public string Numero { get; set; }

        // Propriedades privadas - só podem ser definidas no construtor
        // Não podem ser alteradas depois de criadas (encapsulamento)
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        // Construtor que recebe todos os parâmetros necessários
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Atribui os valores recebidos às propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método para realizar uma ligação
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber uma ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato - deve ser implementado pelas classes filhas
        // Cada marca de celular instala aplicativos de forma diferente
        public abstract void InstalarAplicativo(string nomeApp);
    }
}