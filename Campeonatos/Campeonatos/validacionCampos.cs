//Autor: Guillermo Canel
//0901-09-12084
//INGENIERIA EN SISTEMAS -UMG-
//GRUPO DE PRUEBAS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Campeonatos
{
    class validacionCampos
    {


        
        //los metodos que acontinuacion se muestran solo evaluan a la hora de escribir en los campos
        //escritura alfanumerico
        public void alfanumerico(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if ((char.IsLetter(letras)) || (letras=='-'))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(letras))
            {
                e.Handled = false;

            }
            else if (char.IsSeparator(letras))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //escritura solo una palabra
        public void soloLetras(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if (char.IsLetter(letras))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //escritura varias palabras
        public void soloLetras_palabras(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if (char.IsLetter(letras))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else if(char.IsSeparator(letras))
            {
                e.Handled=false;
            }
            else
            {
                e.Handled = true;
            }
        }

//AQUI ASOCIAMOS CON LOS METODOS GENERALES PARA CADA LEAVE
        //escritura de numeros
       public void soloNumeros(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;

            if (char.IsDigit(letras))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        //------------------------------------------------------------------------------------

        //las expresiones regulares evaluan la escritura dando mejor funcionalidad al trabajo
        //ER->de expresion_regular
        private bool ERsoloLetras(String cadena)
        {
            if (cadena.Length == 0)
            {
                return true;
            }             

            return Regex.IsMatch(cadena, "^[a-z A-Z]+$");
        }

        private bool ERsolonumeros(String cadena)
        {
            if (cadena.Length == 0)
            {
                return true;
            }
            return Regex.IsMatch(cadena, "^[0-9]+$");
        }

        private bool ERalfanumerico(String cadena)
        {
            if (cadena.Length == 0)
            {
                return true;
            }
            return Regex.IsMatch(cadena, "^[a-zA-Z-0-9 ]+$");// "^[a-zA-Z0-9]+$");

        }
        
        //------------------------------------------------------------------------------------
        //mensaje de error en el campo
        public void mensaje()
        {
            MessageBox.Show("Verifique escritura/Campos no pueden estar Vacios");
            
        }
        //------------------------------------------------------------------------------------
        //UTILIZACION DE METODOS Y CLASES
        //escritura solo una palabra en el campo
        public void escrituraLetras(TextBox control)
        {
            if (ERsoloLetras(control.Text) == false)
            {
                mensaje();
                control.Focus();
                control.SelectAll();
            }
        }

        public void escrituraNumeros(TextBox control)
        {
            if (ERsolonumeros(control.Text) == false)
            {
                mensaje();
                control.Focus();
                control.SelectAll();
            }
        }

        public void escrituraAlfanumerico(TextBox control)
        {
            if (ERalfanumerico(control.Text) == false)
            {
                mensaje();
                control.Focus();
                control.SelectAll();
            }

        }
        //------------------------------------------------------------------------------------

    }
    }

