using System;
using System.Xml;


namespace Anycmd.Xacml.Policy.TargetItems
{
	/// <summary>
	/// Represents a read-only Environments node defined in the policy document. This class extends the 
	/// abstract base class TargetItems which defines the elements of the Resources, Actions,
	/// Subjets and Environments nodes.
	/// </summary>
	public class EnvironmentsElement : EnvironmentsElementReadWrite
	{
		#region Constructors

		/// <summary>
		/// Creates a new Environments with the specified aguments.
		/// </summary>
		/// <param name="anyItem">Whether the target item is defined for any item.</param>
		/// <param name="items">The taregt items.</param>
		/// <param name="version">The version of the schema that was used to validate.</param>
		public EnvironmentsElement( bool anyItem, TargetItemReadWriteCollection items, XacmlVersion version )
			: base( anyItem, items, version )
		{
		}

		/// <summary>
		/// Creates an instance of the Environments class using the XmlReader instance provided.
		/// </summary>
		/// <remarks>
		/// This constructor is also calling the base class constructor specifying the XmlReader
		/// and the node names that defines this TargetItmes extended class.
		/// </remarks>
		/// <param name="reader">The XmlReader positioned at the Environments node.</param>
		/// <param name="version">The version of the schema that was used to validate.</param>
		public EnvironmentsElement( XmlReader reader, XacmlVersion version ) 
			: base( reader, version )
		{
		}

		#endregion

		#region Protected methods

		/// <summary>
		/// Creates an instance of the containing element of the Environment class. This method is 
		/// called by the TargetItems base class when an element that identifies a Environment is 
		/// found.
		/// </summary>
		/// <param name="reader">The XmlReader positioned at the Environment node.</param>
		/// <returns>A new instance of the Environment class.</returns>
		protected override TargetItemBaseReadWrite CreateTargetItem( XmlReader reader )
		{
			return new EnvironmentElement( reader, SchemaVersion );
		}

		#endregion

		#region Public properties
		/// <summary>
		/// Gets the items
		/// </summary>
		public override TargetItemReadWriteCollection ItemsList
		{
			get{ return new TargetItemCollection(base.ItemsList) ;}
			set{ throw new NotSupportedException(); }
		}
		#endregion
	}
}
