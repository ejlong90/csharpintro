using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CardHolder
    {
        String cardNum;
        int pin;
        String firstName;
        String lastName;
        double balance;

        public CardHolder(string cardNum, int pin, String firstName, String lastName, double newBalance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = newBalance;

        }

        public String getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public String getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

        public void setNum(string newNum)
        {
            cardNum = newNum;
        }

    }
}
