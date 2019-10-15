using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class RiskyPlayer : IObserver
    {
        public string BoxerToPutMoneyOn { get; set; }

        public void Update(ISubject subject)
        {
            var boxFight = (BoxFight) subject;

            if (boxFight.BoxerAScore < boxFight.BoxerBScore)
            {
                BoxerToPutMoneyOn = "I put on boxer B, better be safe!";
            }
            else
            {
                BoxerToPutMoneyOn = "I put on boxer A";
            }

            Console.WriteLine("risky: {0}",BoxerToPutMoneyOn);
        }
    }
}
