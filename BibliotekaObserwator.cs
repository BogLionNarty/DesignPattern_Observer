using System;
using System.Collections.Generic;

namespace ObserwatorZTP4
{
    public class BibliotekaObserwator : IObserver
    {
        private List<IObservable> _biblioteka = new List<IObservable>();
        public double Price { get; set; } = 0.0f;

        public void Update(IObservable observable, double Price)
        {
            this.Price += Price;
            Console.WriteLine("Biblioteka zareagowała na odtworzenie utworu");
            Console.WriteLine($"Sumaryczna cena odtwarzanie utworów to: {this.Price}");
            Console.WriteLine("*******************************************************");
        }

        public void Add(IObservable observable)
        {
            _biblioteka.Add(observable);
        }

        public void Remove(IObservable observable)
        {
            _biblioteka.Remove(observable);
        }

        public void GetSong(int index)
        {

            if (_biblioteka.Count >= index)
            {
                Console.WriteLine(_biblioteka[index].GetName());
            }
            else
            {
                Console.WriteLine("Brak utworu o takim indexie w bibliotece");
            }

        }
    }
}
