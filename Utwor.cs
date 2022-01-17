using System;

namespace ObserwatorZTP4
{
    public class Utwor : IObservable
    {
        public string Name { get; set; }
        private string Composer { get; set; }
        private double PriceForPlaying { get; set; }
        
        public Utwor(string Name, string Composer, double PriceForPlaying)
        {
            this.Name = Name;
            this.Composer = Composer;
            this.PriceForPlaying = PriceForPlaying;
        }
        public void Notify()
        {
            Console.WriteLine("Utwór: powiadamiam bibliotekę");
            Program.biblioteka.Update(this, PriceForPlaying);
        }

        public void Play()
        {
            Console.WriteLine($"Utwór: Odtwarzam utwór o tytule {this.Name} i wykonawcy {this.Composer}. Cena za odtworzenie utworu to: {this.PriceForPlaying}");
            this.Notify();
        }

        public string GetName()
        {
            return Name;
        }
    }
}
