using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA 
    {
         private readonly IJogador _jogadorA;
         private readonly IJogador _jogadorB;

         private readonly IJogador _jogadorGustavo;


        public JogoFODA(IJogador jogadorA, IJogador jogadorB, IJogador jogadorGustavo)
        {
            _jogadorA = jogadorA;
            _jogadorB= jogadorB;
            _jogadorGustavo = jogadorGustavo;
        }

        public void IniciarJogo()
        {
          System.Console.WriteLine( _jogadorA.Chuta());
          System.Console.WriteLine(_jogadorA.Corre());
          System.Console.WriteLine(_jogadorA.Passe());
          System.Console.WriteLine("----------->");

          System.Console.WriteLine(_jogadorB.Chuta());
          System.Console.WriteLine(_jogadorB.Corre());
          System.Console.WriteLine(_jogadorB.Passe());

          System.Console.WriteLine("----------->");
          System.Console.WriteLine(_jogadorGustavo.Chuta());
          System.Console.WriteLine(_jogadorGustavo.Corre());
          System.Console.WriteLine(_jogadorGustavo.Passe());
          
        }
    }
}