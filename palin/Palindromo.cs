using Microsoft.AspNetCore.Mvc.ViewFeatures;
using palin;
using System;
using System.Collections.Generic;
using System.Linq;

namespace palindromo
{
    public class VerificarPalindromo
    {
        //public string Palavra { get; set; }
        public bool Palindromo { get; set; }
        public List<OcorrenciaCaracteres> Ocorrencias_caracteres { get; set; }

        public VerificarPalindromo(string texto)
        {
            //Palavra = texto;
            Palindromo = IsPalindromo(texto);
            Ocorrencias_caracteres = ListaCaracteresTexto(texto);
        }

        private bool IsPalindromo(string texto)
        {
            return texto.SequenceEqual(texto.Reverse());
        }
        private List<OcorrenciaCaracteres> ListaCaracteresTexto(string texto){

            List<OcorrenciaCaracteres> lista = new List<OcorrenciaCaracteres>();
            for (int i = 0; i < texto.Length; i++) {
                if (texto[i].ToString() != " ") {
                    var found = lista.FirstOrDefault(x => x.Caractere == texto[i]);
           
                    if (found != null)
                        found.Quantidade++;
                    else
                    {
                        OcorrenciaCaracteres ocorr = new OcorrenciaCaracteres { Caractere = texto[i] };
                        ocorr.Quantidade++;
                        lista.Add(ocorr);
                    }
                }
            }
            return lista;
        }
    }

}