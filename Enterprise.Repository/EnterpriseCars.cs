namespace Enterprise.Repository
{
    public enum CarColor{black,blue,silver,red,white}
    public class EnterpriseCars
    {
        
        //Property
        public string Car { get; set; }
        public string NameOfCustomer { get; set; }
        public bool IsRented { get; set; }
        public int CarId { get; set; }
        public CarColor Color {get; set;}

        
        public EnterpriseCars()
        {
                //Empty Constructor
        }
        public EnterpriseCars(string car, string nameOfCustomer,bool isRented,int carId, CarColor color)
        {

            Car = car;
            NameOfCustomer = nameOfCustomer;
            IsRented = isRented;
            CarId = carId;
            Color = color;


        }
    }
}