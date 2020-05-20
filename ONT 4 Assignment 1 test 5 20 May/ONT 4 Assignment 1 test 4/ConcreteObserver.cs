using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
    class ConcreteObserver:Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteKitchen _subject;

        // Constructor
        public ConcreteObserver(ConcreteKitchen subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Console.WriteLine("Coolie's Kitchen in {0} now serving {1}",
              _name, _observerState);
        }

        // Gets or sets subject
        public ConcreteKitchen Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
    }
}
