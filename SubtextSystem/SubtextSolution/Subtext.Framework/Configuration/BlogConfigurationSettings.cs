#region Disclaimer/Info
///////////////////////////////////////////////////////////////////////////////////////////////////
// .Text WebLog
// 
// .Text is an open source weblog system started by Scott Watermasysk. 
// Blog: http://ScottWater.com/blog 
// RSS: http://scottwater.com/blog/rss.aspx
// Email: Dottext@ScottWater.com
//
// For updated news and information please visit http://scottwater.com/dottext and subscribe to 
// the Rss feed @ http://scottwater.com/dottext/rss.aspx
//
// On its release (on or about August 1, 2003) this application is licensed under the BSD. However, I reserve the 
// right to change or modify this at any time. The most recent and up to date license can always be fount at:
// http://ScottWater.com/License.txt
// 
// Please direct all code related questions to:
// GotDotNet Workspace: http://www.gotdotnet.com/Community/Workspaces/workspace.aspx?id=e99fccb3-1a8c-42b5-90ee-348f6b77c407
// Yahoo Group http://groups.yahoo.com/group/DotText/
// 
///////////////////////////////////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.Xml.Serialization;

namespace Subtext.Framework.Configuration
{
	/// <summary>
	/// Contains various configuration settings stored in the 
	/// web.config file.
	/// </summary>
	[Serializable]
	public class BlogConfigurationSettings 
	{
		private Tracking _tracking;
		public Tracking Tracking
		{
			get 
			{
				if(this._tracking == null)
				{
					this._tracking = new Tracking();
				}
				return this._tracking;
			}
			    set {this._tracking = value;}
		}

		private bool _useWWW;
		public bool UseWWW
		{
			get {return this._useWWW;}
			set {this._useWWW = value;}
		}

		private int _queuedThreads = 2;
		public int QueuedThreads
		{
			get {return this._queuedThreads;}
			set {this._queuedThreads = value;}
		}

		private bool _allowserviceaccess;
		public bool AllowServiceAccess
		{
			get{return _allowserviceaccess;}
			set{_allowserviceaccess = value;}
		}

		private bool _useHashedPasswords;
		public bool UseHashedPasswords
		{
			get {return this._useHashedPasswords;}
			set {this._useHashedPasswords = value;}
		}

		private bool _allowImages;
		/// <summary>
		/// Gets or sets a value indicating whether or not to allow images.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [allow images]; otherwise, <c>false</c>.
		/// </value>
		public bool AllowImages
		{
			get{return _allowImages;}
			set{_allowImages = value;}
		}

		/// <summary>
		/// Gets a value indicating whether or not to use XHTML.  This is 
		/// dependent on the DocTypeDeclaration chosen.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if using XHTML; otherwise, <c>false</c>.
		/// </value>
		[XmlIgnore]
		public bool UseXHTML
		{
			get
			{
				return this.DocTypeDeclaration != null 
					&& (this.DocTypeDeclaration.IndexOf("http://www.w3.org/TR/xhtml1/DTD/xhtml1-") > 0);
			}
		}

		private int feedItemCount = 15;
		/// <summary>
		/// Gets or sets the default number of items to display 
		/// for syndication feeds.
		/// </summary>
		/// <value></value>
		public int ItemCount
		{
			get{return feedItemCount;}
			set{feedItemCount = value;}
		}

		private int serverTimeZone = -5;
		/// <summary>
		/// Gets or sets the server time zone.
		/// </summary>
		/// <value></value>
		public int ServerTimeZone
		{
			get{return serverTimeZone;}
			set{serverTimeZone = value;}
		}

		/// <summary>
		/// Gets or sets the doc type declaration to use 
		/// at the top of each page.
		/// </summary>
		/// <value></value>
		public string DocTypeDeclaration
		{
			get { return _docTypeDeclaration; }
			set { _docTypeDeclaration = value; }
		}

		string _docTypeDeclaration;

	}
}

