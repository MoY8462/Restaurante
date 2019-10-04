using System;

namespace Usuarios
{
    public class Persona
    {
        #region Atributos
        private string nickname;
        private string correo;
        private string contrasena;
        private int telefono;
        private string pregunta;
        private string respuesta;
        private string confContraseña;
        private string apellido;
        #endregion

        #region Encapsulamiento
        public string Nickname { get => nickname; set => nickname = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public string ConfContraseña { get => confContraseña; set => confContraseña = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Pregunta { get => pregunta; set => pregunta = value; }
        #endregion

        #region Método
        #endregion
    }
}
