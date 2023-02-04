using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;

namespace RazorblueTechTest.DataImport
{
    public static class DataImport
    {
        public const string ValidVehicleRegExpression = "^[A-Za-z]{2}\\d{2}\\s[A-Za-z]{3}$";
        private static readonly List<Vehicle> _vehicles;
        private static readonly string _projectPath = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.FullName;
        static DataImport()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                Path.Combine(_projectPath, "RazorblueTechTest.DataImport", "Technical Test Data.csv"));

            _vehicles = File.ReadAllLines(path)
                .Skip(1)
                .Select(Vehicle.FromCsv)
                .DistinctBy(v => v.RegistrationNumber)
                .ToList();
        }

        public static void ExportVehiclesByType()
        {
            var types = GetValidVehicles().DistinctBy(v => v.Fuel.ToLower()).Select(v => v.Fuel);
            foreach (var type in types)
            {
                var csvStringBuilder = new StringBuilder();
                const string header = "Car Registration,Make,Model,Colour,Fuel";
                csvStringBuilder.AppendLine(header);
                var filteredVehicles = GetValidVehicles().Where(v =>
                    string.Equals(v.Fuel, type, StringComparison.CurrentCultureIgnoreCase));

                foreach (var item in filteredVehicles)
                {
                    csvStringBuilder.AppendLine($"{item.RegistrationNumber}, {item.Make}, {item.Model}, {item.Colour},{item.Fuel}");
                }

                var parentFullName = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName;

                if (parentFullName == null) continue;
                var exportedFilesPath = Path.Combine(parentFullName, "Exports");

                var exists = Directory.Exists(exportedFilesPath);

                if (!exists)
                    Directory.CreateDirectory(exportedFilesPath);
                var fileName = Path.Combine(exportedFilesPath, $"{type}.csv");

                if (File.Exists(fileName))
                    File.AppendAllText(fileName, csvStringBuilder.ToString());
                else
                    File.WriteAllText(fileName, csvStringBuilder.ToString());
            }
        }

        public static IEnumerable<Vehicle> GetValidVehicles()
        {
            return _vehicles.Where(vehicle => Regex.IsMatch(vehicle.RegistrationNumber, ValidVehicleRegExpression)).ToList();
        }

        public static int GetInValidVehicleCount()
        {
            return _vehicles.Count(vehicle => !Regex.IsMatch(vehicle.RegistrationNumber, ValidVehicleRegExpression));
        }
    }
}