namespace ValueAndReferenceTypes
{
    public struct ValueType
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Swap(int x, int y)
        {
            var degisken = x;
            x = y;
            y = degisken;
        }


    }
}