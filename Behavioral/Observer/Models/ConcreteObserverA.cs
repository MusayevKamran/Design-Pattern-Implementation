﻿using System;
using System.Collections.Generic;
using System.Text;
using Observer.Interfaces;
using Observer.Pattern;

namespace Observer.Models
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}