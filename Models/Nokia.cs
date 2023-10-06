namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string iMEI, string  modelo, int memoria) : base(numero, iMEI, modelo, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} para nokia");
        }
    }
}