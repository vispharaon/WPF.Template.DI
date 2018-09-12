using WPF.Template.DI.Core.Base;
using WPF.Template.DI.Service.Repositories;

namespace WPF.Template.DI.Core.ViewModel.Test
{
    public class TestViewModel : BaseViewModel
    {
        #region Private Field

        private readonly ITestRepository _testRepository;

        #endregion

        #region Public Properties

        public string TestString { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructing the instance of test vm
        /// </summary>
        /// <param name="testRepository"></param>
        public TestViewModel(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Setting test string
        /// </summary>
        public void SetTestString()
        {
            TestString = _testRepository.GetTestValue();
        }

        #endregion
    }
}
