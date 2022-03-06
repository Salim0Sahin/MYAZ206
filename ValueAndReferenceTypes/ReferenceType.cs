namespace ValueAndReferenceTypes
{
    public class ReferenceType
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Swap(ref int x, ref int y)
        {
            var degisken = x;
            x = y;
            y = degisken;
        }

        public void ChechOut(out int x)
        {
            x = 10;
            return;
        }
    }
}