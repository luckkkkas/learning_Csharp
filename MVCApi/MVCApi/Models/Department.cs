namespace MVCApi.Models {
    public class Department 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public double TotalSales(DateTime initia, DateTime final)
        {
            return sellers.Sum(seller => seller.TotalSales(initia, final));
        }
    }
}
