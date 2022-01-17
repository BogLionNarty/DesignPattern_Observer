namespace ObserwatorZTP4
{
    public interface IObserver
    {

        void Add(IObservable observable);
        void Update(IObservable observable, double PriceForPlaying);
    }
}
