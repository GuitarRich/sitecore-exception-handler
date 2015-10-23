namespace Sitecore.Exception.Handler.Exceptions
{
	using System;

	[Serializable]
    public class DatasourceNotSetException : Exception
    {
        private const string ExceptionMessageFormat = "The Datasource has not been set for this component. Select 'More' -> 'Edit the Component Properties' and make sure this property is set to relevant value. [{0}]";

        public DatasourceNotSetException(string message)
            : base(string.Format(ExceptionMessageFormat, message))
        {
        }

        public DatasourceNotSetException(string parameterName, Exception innerException)
            : base(string.Format(ExceptionMessageFormat, parameterName), innerException)
        {
        }
    }
}
