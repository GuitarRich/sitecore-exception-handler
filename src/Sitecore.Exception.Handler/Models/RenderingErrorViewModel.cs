namespace Sitecore.Exception.Handler.Models
{
	using System;

	public class RenderingErrorModel
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="RenderingErrorModel"/> class.
		/// </summary>
		/// <param name="renderingName">Name of the rendering.</param>
		/// <param name="exception">The exception.</param>
		public RenderingErrorModel(string renderingName, Exception exception)
        {
            this.Exception = exception;
            this.RenderingName = renderingName;
        }

		/// <summary>
		/// Gets the name of the rendering.
		/// </summary>
		/// <value>
		/// The name of the rendering.
		/// </value>
		public string RenderingName { get; private set; }

		/// <summary>
		/// Gets the exception.
		/// </summary>
		/// <value>
		/// The exception.
		/// </value>
		public Exception Exception { get; private set; }
    }
}
