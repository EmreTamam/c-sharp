namespace abstractclass
{
    public abstract class Otomobil
    {
        public int Tekerlek(){
            return 4;
        }

        public virtual Renk RengiNe(){
            return Renk.Beyaz;
        }

        public abstract Marka Markasi();
    }
}