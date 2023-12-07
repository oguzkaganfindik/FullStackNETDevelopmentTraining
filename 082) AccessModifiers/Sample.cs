namespace _082__AccessModifiers
{
    // Eğer bir yapıya access modifier verilmezse o yapı alabileceği en yüksek güvenlikli (en düşük erişimli) access modifier'ı default olarak alır.

    // Bir class için en düşük erişim mertebesi internal'dır.
    class Sample
    {
        public Sample()
        {
            PrivateProperty = 5;
            // Aynı localde oldukları için burada erişilebilir.
        }
        public int PublicProperty { get; set; }
        // public -> Her yerden erişilebilir.
        internal int InternalProperty { get; set; }
        // internal -> Tanımlandığı proje içerisinde erişilebilir.
        private int PrivateProperty { get; set; }
        // Private -> Tanımlandığı scope içerisinde erişilebilir.

        int DenemeProperty { get; set; }
        // Private
    }
}
