using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConservativePlayer : IObserver
    {
        public string BoxerToPutMoneyOn { get; set; }

        public void Update(ISubject subject)
        {
            var boxFight = (BoxFight)subject;

            if (boxFight.BoxerAScore < boxFight.BoxerBScore)
            {
                BoxerToPutMoneyOn = "I put on boxer B, better be safe!";
            }
            else
            {
                BoxerToPutMoneyOn = "I put on boxer A";
            }

            Console.WriteLine("conservative: {0}", BoxerToPutMoneyOn);
        }
    }
}
