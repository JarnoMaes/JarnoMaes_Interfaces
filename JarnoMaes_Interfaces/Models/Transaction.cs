using JarnoMaes_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarnoMaes_Interfaces.Models
{
    public class Transaction : Bank, ITransaction
    {
        private readonly string _Code;
        private readonly string _Date;
        private readonly double _Amount;
        private double _Commission;
        
        public Transaction(string code, string date, double amount)
        {
            this._Code = code;
            this._Date = date;
            this._Amount = amount;
        }

        public double GetAmount()
        {
            double FullAmount;
            if (_Amount > 100)
            {
                
                _Commission = 100 / 100 * 0.5;
                Console.WriteLine($"You will be charged extra commission of {_Commission}% on your {_Amount}Euro");   
                FullAmount = _Amount - _Commission;
                return FullAmount;
            }
            else
            {
                Console.WriteLine("You will not be charged extra commission");
                return _Amount;
            }
        }
        public string ShowBankName()
        {
            return BankName;
        }
        public void ShowTransaction()
        {
            Console.WriteLine($"Name of Bank: {BankName}\n" +
                $"Adress of Bank: {BankAdress}\nTransaction: {_Code}\n" +
                $"Date: {_Date}\nAmount: {_Amount}");              
        }
    }
}
