﻿using System;
using System.Xml.Serialization;
using JsParserCore.Helpers;

namespace JsParserCore.Code
{
	/// <summary>
	/// The code node.
	/// </summary>
	[Serializable]
	public class CodeNode : SerializedEntity
	{
		/// <summary>
		/// Gets or sets Alias.
		/// </summary>
		[XmlAttribute("Text")]
		public string Alias { get; set; }

		/// <summary>
		/// Gets or sets StartLine.
		/// </summary>
		[XmlAttribute("Line")]
		public int StartLine { get; set; }

		/// <summary>
		/// Gets or sets EndLine.
		/// </summary>
		[XmlAttribute("EndLine")]
		public int EndLine { get; set; }

		/// <summary>
		/// Gets or sets EndColumn.
		/// </summary>
		[XmlAttribute("EndColumn")]
		public int EndColumn { get; set; }

		/// <summary>
		/// Gets or sets StartPosition.
		/// </summary>
		[XmlAttribute("Pos")]
		public int StartColumn { get; set; }

		/// <summary>
		/// Gets or sets Opcode.
		/// </summary>
		[XmlAttribute("Opcode")]
		public string Opcode { get; set; }

		/// <summary>
		/// Gets or sets The Comment.
		/// </summary>
		[XmlAttribute("Comment")]
		public string Comment { get; set; }

		/// <summary>
		/// Equals custom implementation.
		/// </summary>
		/// <param name="obj">
		/// The obj parameter.
		/// </param>
		/// <returns>
		/// Bool result.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (!(obj is CodeNode))
			{
				return false;
			}

			var c = (CodeNode) obj;

			return Alias == c.Alias && StartLine == c.StartLine;
		}

		/// <summary>
		/// GetHashCode custom implementation.
		/// </summary>
		/// <returns>
		/// Int result.
		/// </returns>
		public override int GetHashCode()
		{
			return (Alias ?? string.Empty).GetHashCode() + StartLine.GetHashCode();
		}
	}
}