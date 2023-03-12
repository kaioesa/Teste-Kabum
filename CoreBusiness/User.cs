namespace CoreBusiness
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public List<Address> UserAddress { get; set; }
    }
}