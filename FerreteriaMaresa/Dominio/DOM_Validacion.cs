﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dominio
{
    public class DOM_Validacion
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo debe ingresar letras" + ex);
            }
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsSeparator(e.KeyChar) || e.KeyChar =='.')
                {
                    e.Handled = true;
                }
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo debe ingresar Numeros" + ex);
            }
        }

        public Boolean email(String email)
        {

            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Formato de Correo Incorrecto");
                return false;
            }
        }

    }
}
