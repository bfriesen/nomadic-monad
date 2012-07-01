namespace RandomSkunk.NomadicMonad
{
    public static class Monad
    {
        public static Monad<T> ToMonad<T>(this T value)
        {
            return new Monad<T>(value);
        }
    }
}