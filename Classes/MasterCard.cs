namespace Aula_08_12_2020.Classes
{
    public class MasterCard : Cartao
    {
        // Atributos
        private int parcelas;

        // Get e Set - Métodos acessores
        public int Parcelas
        {
            get {return parcelas;}          // Acessador get: pegar valor/dados - Leitura
            set {parcelas = value;}         // Acessador set: inserir valor/dados - Escrita
        }

        //Métodos
         public string CompraComDesconto()
         {
             return"";
         }
    }
}