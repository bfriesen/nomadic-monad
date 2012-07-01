namespace RandomSkunk.NomadicMonad
{
    public class Monad<T>
    {
        private readonly T _value;

        public Monad(T value)
        {
            _value = value;
        }

        public T Value
        {
            get { return _value; }
        }
    }
}