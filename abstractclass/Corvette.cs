namespace abstractclass
{
    public class Corvette : Otomobil
    {
        public override Marka Markasi()
        {
            return Marka.Chevrolet;
        }

        public override Renk RengiNe()
        {
            return Renk.Kırmızı;
        }
    }
}