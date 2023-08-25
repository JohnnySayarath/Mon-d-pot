using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire
{
    internal class Operation : CompteBancaire
    {
        private string _numero;
        private decimal _montant;
        private string _statut;


        public string Numero { get => _numero; set => _numero = value; }
        public decimal Montant { get => _montant; set => _montant = value; }
        public string Statut 
        {
            get => _statut; 
            set 
            {
                
                    string depot;
                    string retrait;
                
            }
        }
        
        public Operation(string numero, decimal montant, string statut)
        {
            Numero = numero;
            Montant = montant;
            Statut = statut;
        }

        public void Afficher()
        {

        }
    }
}
