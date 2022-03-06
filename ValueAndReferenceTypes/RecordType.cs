namespace ValueAndReferenceTypes
{
    // Immutable (DTO) Yer değişmez. başlangıçta verilen değeri kalıcıdır.
    // LINQ sorgulerında kullanılıyor
    // Value? .  Değer tipli olarak karşılaştırılabiliyor.


    public record RecordType(int X, int Y);

    //public record RecordType
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}

}