using Generate.Template;
using Generate.Utility;
using Infrastructure.Mapping;
using System.Reflection;

namespace GenerateBL
{
    public class Generator
    {
        private IMapper _mapper;
        public Generator(IMapper mapper)
        {
            _mapper =  mapper;
        }

        public void Generate()
        {
            var schemaGenerator = SchemaGeneratorFactory.GetSchemaGenerator(_mapper);

            var tables = schemaGenerator.GetTables();

            foreach (var table in tables)
            {
                Console.WriteLine(table.TableName);

                var columns = schemaGenerator.GetColumns(table);
                
                string insertColumns = "";
                string insertValues = "";
                foreach (var column in columns)
                {
                    insertColumns += column.Name + ",";
                    Console.WriteLine(column.Name);
                }
                if (insertColumns.EndsWith(",")) insertColumns = insertColumns.Substring(0, insertColumns.Length - 1);

                // Load an assembly
                Assembly assembly = Assembly.LoadFrom("Template.dll");

                // Get all the types defined in the assembly
                Type[] types = assembly.GetTypes();

                // Filter the types to get only classes
                var classes = Array.FindAll(types, t => t.IsClass);

                // Filter the types to get only those in a specific namespace
                classes = Array.FindAll(classes, t => t.Namespace == "Generate.Template");

                // Print the names of the classes
                foreach (var type in classes)
                {
                    // Create an instance of the class
                    object obj = Activator.CreateInstance(type);

                    // Get the method with the name "Output"
                    MethodInfo method = type.GetMethod("Output");

                    // Create an object array to hold the method's parameters
                    object[] parameters = new object[] { table.TableName.ToProperCase(), table.TableName, insertColumns };

                    // Invoke the method with parameters
                    Console.WriteLine(method.Invoke(obj, parameters));
                }
            }
        }
    }
}