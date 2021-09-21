using System;

namespace DioJogos.Controllers.V1.Exceptions
{
    public class JogoJaCadastradoException
    {
        public JogoJaCadastradoException()
            : base("Este já jogo está cadastrado")
        { }
        
    }
}