
namespace P01IlkSinifimiziOlusturuyoruz
{
    public class person
    {
        public string name; //field kısmı öğrenci veya öğretmenin ismi soyismi ve doğum tarihini oluşturuyoruz.
        public string lastname;
        public DateTime dateTime;

        public string Name
        {
            get { return name; }
            set {  name = value; }
        }
        public string Lastname
        { 
            get { return lastname; }
            set { lastname = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set
            {
                dateTime = value;
            }
        }

        public void KendiniTanit() //Kullanıcının ismini soyismini ve dogum tarihini yazdırdığımız bir metot oluşturduk.
        {
            Console.WriteLine($"Merhaba benim adım {name.ToUpper()} {lastname.ToUpper()} ve doğum tarihim {dateTime.ToShortDateString()}'dir.");
        }
    }
    
}


