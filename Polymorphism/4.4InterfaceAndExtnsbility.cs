using System;

namespace _6._3.InterfaceAndExtnsbility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}"+ DateTime.Now);
            _logger.LogInfo("Migrationg finished at {0}" + DateTime.Now);
        }
    }
}
