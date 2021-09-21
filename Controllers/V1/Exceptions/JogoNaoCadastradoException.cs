using System;

namespace DioJogos.Controllers.V1.Exceptions
{
    public class JogoNaoCadastradoException
    {
        public JogoNaoCadastradoException()
            :base("Este jogo não está cadastrado")
        {}
        
    }
}