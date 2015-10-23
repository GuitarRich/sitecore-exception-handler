namespace Sitecore.Exception.Handler.Exceptions
{
	using System;

	[Serializable]
    public class RenderingParametersException : Exception
    {
        private const string ExceptionMessageFormat = "'{0}' rendering parameter should not be empty. Select 'More' -> 'Edit the Component Properties' and make sure this property is set to relevant value.";

        public RenderingParametersException(string parameterName)
            : base(string.Format(ExceptionMessageFormat, parameterName))
        {
        }

        public RenderingParametersException(string parameterName, Exception innerException)
            : base(string.Format(ExceptionMessageFormat, parameterName), innerException)
        {
        }
    }
}
