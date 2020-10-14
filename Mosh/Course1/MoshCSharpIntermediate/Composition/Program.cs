using System.Runtime.InteropServices.ComTypes;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {

            // here we can either instanciate a new Logger object as an argument, or pass an existing Logger object, as seen in each of these examples

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();

        }
    }
}
