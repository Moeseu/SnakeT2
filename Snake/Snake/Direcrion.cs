namespace Snake
{
    public class Direcrion
    {
        public readonly static Direcrion Left = new Direcrion(0, -1);
        public readonly static Direcrion Right = new Direcrion(0, 1);
        public readonly static Direcrion Up = new Direcrion(-1, 0);
        public readonly static Direcrion Down = new Direcrion(1, 0);

        public int RowOffSet { get; }
        public int ColOfSet { get; }

        private Direcrion(int rowOffSet, int colOfSet)
        {
            RowOffSet = rowOffSet;
            ColOfSet = colOfSet;
        }

        public Direcrion Opposite()
        {
            return new Direcrion(-RowOffSet, -ColOfSet); 
        }

        public override bool Equals(object obj)
        {
            return obj is Direcrion direcrion &&
                   RowOffSet == direcrion.RowOffSet &&
                   ColOfSet == direcrion.ColOfSet;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffSet, ColOfSet);
        }

        public static bool operator ==(Direcrion left, Direcrion right)
        {
            return EqualityComparer<Direcrion>.Default.Equals(left, right);
        }

        public static bool operator !=(Direcrion left, Direcrion right)
        {
            return !(left == right);
        }
    }
}
