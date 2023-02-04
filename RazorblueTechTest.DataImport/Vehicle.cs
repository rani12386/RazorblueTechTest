namespace RazorblueTechTest.DataImport
{
    public class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Fuel { get; set; }

        public static Vehicle FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            Vehicle vehicle = new()
            {
                RegistrationNumber = values[0],
                Make = values[1],
                Model = values[2],
                Colour = values[3],
                Fuel = values[4]
            };
            return vehicle;
        }
    }
}
