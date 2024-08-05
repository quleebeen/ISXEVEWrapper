using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EVEUIButton : LavishScriptObject
    {
        #region Constructors
        public EVEUIButton(LavishScriptObject obj) : base(obj)  {}
        #endregion

        #region Members
        private string _Text;
        public string Text
        {
            get { return _Text ?? (_Text = this.GetString("Text")); }
        }
        #endregion

        #region Methods
        public bool Press()
        {
            Tracing.SendCallback("EVEUIButton.Press");
            return ExecuteMethod("Press");
        }
        #endregion
    }
}