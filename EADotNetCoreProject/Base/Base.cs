using EAAutoFramework.Base;
using EAAutoFramework.Base;
using System;

namespace EAAutoFramework.Base
{
    public class Base
    {

        public readonly ParallelConfig _parallelConfig;

        public Base(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            return (TPage)Activator.CreateInstance(typeof(TPage));
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
