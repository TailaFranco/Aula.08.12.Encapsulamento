namespace Aula_08_12_2020.Classes
{
    public class Cartao
    {
        // Declaração dos atributos
        int x=0;
        int y=0;
        private string numero;
        public float compra;
        public string Numero
        {
            get{ return numero;}
            set{ numero = value;}
        }
        private string bandeira = "MasterCard";
        public string Bandeira
        {
            get {return bandeira;}
        }

        protected string token = "quertyui";
        public string Token
        {
            get {return token;}
        } 
        private string cvv;
        public string Cvv
        {
            get{return cvv;}
            set {cvv= value;}
        }
        protected float limite = 5000;
        public float LimitedeCompra
        {   get {return limite;}
            set {limite = value;}
        }

        // Declaração dos metodos

        public string RegistrarCompra(bool validado)
        {
            if(y==1 && x==1)
            {return "Compra registrada";}
            else
            {return "Sua compra não foi registrada";}
        }
        private bool ValidarCompra(float saldo)
        {
            saldo = limite;
            if (limite <= compra)
            {y=1;
            return true;
            }
            else
            {return false;}
        }
       
        
        protected string ValidarToken(string token)
        {
            if (Token == token)
            {x=1; return "Token válido";}
            else
            {return "Token inválido";}
        }
    }
}