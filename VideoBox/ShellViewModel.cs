using Prism.Mvvm;

namespace VideoBox
{
    /// <summary>
    /// A Shell viewmodel.
    /// </summary>
    public class ShellViewModel : BindableBase
    {
        #region Private fields

        private string _title;

        #endregion

        #region Конструктор

        /// <summary>
        /// Creates a new instance of the shell viewmodel.
        /// </summary>
        public ShellViewModel()
        {
            Title = "Movie library";
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a window title.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        #endregion
    }
}
