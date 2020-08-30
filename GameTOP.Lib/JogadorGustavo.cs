using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class JogadorGustavo : IJogador
    {
        private readonly string Nome;

        public JogadorGustavo(string nome)
        {
            Nome = nome;
        }

        public string Chuta()
        {
            return $"{Nome} chuta";
        }

        public string Corre()
        {
            return $"{Nome} corre";
        }

        public string Passe()
        {
            return $"{Nome} passa";
        }
    }
}