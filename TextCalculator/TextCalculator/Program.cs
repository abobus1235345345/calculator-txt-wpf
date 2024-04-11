class Program
{
    static void SDS()
    {
        Logger logger = new Logger();
        logger.LogAction("User started the application");
        logger.LogAction("Text entered in field 1");
        logger.LogConcatenationAction(2);
        logger.LogAction("Button clicked");
        logger.LogApplicationClose();
    }
}