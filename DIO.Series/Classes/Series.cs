namespace DIO.Series
{
    public class Series : EntidadeBase
    {
       
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}     

        private bool Excluido {get; set;}

         public Series(int id, Genero genero, string titulo, string descricao, int ano) 
        {
            this.id = id
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;   
            this.Excluido = false;           
        }   

        public override string ToString()

        string retorno = "";
        retorno += "Genero:" + this.Genero + Environmnet.NewLine;
        retorno += "Titulo:" + this.Titulo + Environmnet.NewLine;
        retorno += "Descricao:" + this.Descricao + Environmnet.NewLine;
        retorno += "Ano:" + this.Ano + Environmnet.NewLine;
        return = retorno;
    }

    public string retornaTitulo()
    {
        return this.Titulo;
    }

    public int retornaId()
    {
        return this.Titulo;
    }

    public void Excluir()
    {
        this.Excluido = true;
    }
}