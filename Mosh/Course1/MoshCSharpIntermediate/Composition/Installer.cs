namespace Composition
{
    public class Installer
    {
        private Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("App was installed with no errors :)");
        }

    }
}
