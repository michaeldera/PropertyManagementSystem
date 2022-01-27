using PropertyManagementSystem.Data;

namespace PropertyManagementSystem.Templates.Helpers
{
    internal class Class1
    {
        public Class1()
        {




        }
        public List<string> GetModelNames()
        {
            var modelNames = new List<string>();
            var relativePath = Path.Join("PropertyManagementSystem.Common", "Models");

            var files = Directory.GetFiles(relativePath);

            var modelFiles = files.Where(f => f.EndsWith(".cs"));

            foreach (var file in modelFiles)
            {
                modelNames.Add(file);
            }

            return modelNames;
        }
    }
}
