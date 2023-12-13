namespace _093__EncapsulationOrnek2
{
    internal class Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        string _telNo;
        public string TelNo
        {
            get
            {
                return "0" + _telNo;
            }
            set
            {
                if (value.Length == 10)
                    _telNo = value;
                else
                    _telNo = "000";
            }
        }


    }
}
