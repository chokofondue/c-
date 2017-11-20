#define TEST_ENV
//#define PROD_ENV

using System;

namespace Preprocessor_Directive
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool verbose = false;
            //...
#if(TEST_ENV)
            Console.WriteLine("Test Environment: Verbose option is set.");
            verbose = true;
#else
            Console.WriteLine("production");
#endif
            if (verbose)
            {
                //...
            }
        }

        #region Public Methods
        public void Run() { }
        public void Create() { }
        #endregion

        #region Public Properties
        public int Id { get; set; }
        #endregion

        #region Privates
        private void Execute() { }
        #endregion
    }
}
