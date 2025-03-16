using Singleton.Interface;
using Singleton.Model;

Parallel.Invoke(WriteInfo, WriteError);
Parallel.Invoke(WriteInfoEager, WriteErrorEager);
Parallel.Invoke(WriteInfoLazy, WriteErrorLazy);
static void WriteInfo()
{
    ILogger logger = Logger.GetInstance();
    logger.LogInfo("Thread Safe Singleton:- "+logger.GetHashCode());
}
static void WriteError()
{
    ILogger logger = Logger.GetInstance();
    logger.LogError("Thread Safe Singleton:- "+logger.GetHashCode());
}

static void WriteInfoEager()
{
    ILogger logger = LoggerEager.GetInstance();
    logger.LogInfo("Eager Singleton:- " + logger.GetHashCode());
}
static void WriteErrorEager()
{
    ILogger logger = LoggerEager.GetInstance();
    logger.LogError("Eager Singleton:- " + logger.GetHashCode());
}

static void WriteInfoLazy()
{
    ILogger logger = LoggerLazy.GetInstance();
    logger.LogInfo("Lazy Singleton:- " + logger.GetHashCode());
}
static void WriteErrorLazy()
{
    ILogger logger = LoggerLazy.GetInstance();
    logger.LogError("Lazy Singleton:- " + logger.GetHashCode());
}