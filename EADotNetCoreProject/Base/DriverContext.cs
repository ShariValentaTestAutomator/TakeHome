using EAAutoFramework.Base;

namespace EAAutoFramework.Base
{
    public class DriverContext
    {

        public readonly ParallelConfig _parallelConfig;

        public DriverContext(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }


        public void GoToUrl(string url)
        {
            _parallelConfig.Driver.Url = url;
        }


        public static Browser Browser { get; set; }

    }
}

