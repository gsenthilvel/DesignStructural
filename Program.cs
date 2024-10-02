namespace DesignStructural
{
    internal class Program
    {
        private static void AdapterTest()
        {
            BaseLogger baseLogger = new BaseLogger();
            AdvanceLogger advanceLogger = new AdvanceLogger();
            ILogger logger = new LoggerAdapter(advanceLogger);
            logger.Log("This is a message");
            baseLogger.LogMessage("This is a message");
        }

        private static void Main(string[] args)
        {
            AdapterTest();
        }
    }
}