﻿using System.Windows.Forms;

namespace lab3
{
    public class Cola1
    {
        public string[] coladatos = new string[100];
        public int primero = 0;
        public int ultimo = -1;
        public int MaxCola = 9;
        public string valor = "";

        public Cola1()
        {
            primero = 0;
            ultimo = -1;
        }

        public bool Vacia()
        {
            if (ultimo < primero) return true;
            else return false;
        }

        public bool Llena()
        {
            if (ultimo == MaxCola - 1) return true;
            else return false;
        }

        public void Insertar(string insert)
        {
            if (Llena()) MessageBox.Show("Error: La cola de elementos esta LLENA");
            else
            {
                ultimo++;
                coladatos[ultimo] = insert;
            }
        }
       

        public string Eliminar()
        {
            string valor = " ";
            if (Vacia()) MessageBox.Show("Error: La cola de elementos esta VACIA");
            else
            {
                valor = coladatos[primero];
                for (int i = 0; i < ultimo; i++)
                {
                    coladatos[i] = coladatos[i + 1];
                }
                ultimo--;
            }
            return valor;
        }

        public void Insertar2(string insert)
        {
            if (Llena()) MessageBox.Show("Error: La cola de elementos esta LLENA");
            else
            {

                primero++;
                for (int i = ultimo - 1; i >= 0; i--)
                {
                    coladatos[i + 1] = coladatos[i];
                    coladatos[primero] = insert;
                }

            }
        }

        public string Eliminar2()
        {
            string valor = " ";
            if (Vacia()) MessageBox.Show("Error: La cola de elementos esta VACIA");
            else
            {
                valor = coladatos[ultimo];
                
                ultimo--;
            }
            return valor;
        }
    }
}