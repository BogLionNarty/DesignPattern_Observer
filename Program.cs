using System.Collections;

namespace ObserwatorZTP4
{

    public class Program
    {

        public static readonly BibliotekaObserwator biblioteka = new BibliotekaObserwator();
        static void Main(string[] args)
        {
          
            Utwor utwor1 = new("wkk", "lukaszg", 5.32);
            Utwor utwor2 = new("Kiedy byłem małym chlopcem", "Breakout", 2.22);
            Utwor utwor3 = new("Bohemian Rhapsody", "Queen", 15);

            biblioteka.Add(utwor1);
            biblioteka.Add(utwor2);
            biblioteka.Add(utwor3);

            utwor1.Play();
            utwor2.Play();
            utwor3.Play();
            utwor1.Play();

            biblioteka.GetSong(1);
            biblioteka.GetSong(0);
            biblioteka.GetSong(23);

        }
    }
}
