using System;

namespace practicas_fundamentals
{
    internal class Coche
    {
        #region Campos / Variables miembro. Almacenan ESTADO privado. //Buena práctica poner los campos privados. 

        private int _kilometrosRecorridos; //Se nombram normalemtne con un guión bajo al princio.
                                           //Si tiene varias palabras, se separan por mayúsculas. 
                                           //Otra gente no pone el guión bajo inicial: kilometrosRecorridos
       

        #endregion

        #region Propiedades. Dan acceso al ESTADO desde fuera. 

        public int KilometrosRecorridos //Se nommran sin guión bajo y con mayúsculas
        {
            get
            {
                Console.WriteLine("Me están pidiendo los kilómetros recorridos"); //Puedo añadir código adicional
                return _kilometrosRecorridos;
            }
            private set//La pongo private para que sólo desde dentro de mi clase se pueda modificar. 
            {
                _kilometrosRecorridos = value;//value es una palabra reservada. Conetendrá el valor que me hayan pasado al establecer esta propiedad. 
            }

        }

        public double Gasolina { get; private set; }//Esto es más cómodo y rápido si sólo quiero hacer get y set, sin código adicional. 

        #endregion

        #region Constructores

        public Coche()//Si alguien hace new Coche(), el programa se mete aquí para inicializar ese coche
        {
            //Al pricnipio, al crear un coche, quiero que sus kilómetros recorridos sean 0. 
            _kilometrosRecorridos = 0;//Optamos por esta opcíon, proque es la más simple
            // KilometrosRecorridos = 0;//También se podría hacer así, porque , aunque tenga el getter privado, está dentro de la misma clase
            //Aquí, se metería en el setter y value tomaría el valor 0, y por tanto _kilometrosRecorridos pasaría a 0

            Gasolina = 5;
        }


        #endregion

    }


}