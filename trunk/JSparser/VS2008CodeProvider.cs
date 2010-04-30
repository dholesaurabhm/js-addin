﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsParserCore.Code;
using EnvDTE80;
using EnvDTE;

namespace JSparser
{
	public class VS2008CodeProvider : ICodeProvider
	{
		private DTE2 _applicationObject;
		private Document _activeDocument;

		public VS2008CodeProvider(DTE2 applicationObject, Document activeDocument)
		{
			_applicationObject = applicationObject;
			_activeDocument = activeDocument ?? _applicationObject.ActiveDocument;
		}

		private Document Doc
		{
			get
			{
				return _activeDocument;
			}
		}

		#region ICodeProvider Members

		public string LoadCode()
		{
			if (Doc == null)
			{
				return "function Error_Loading_Document(){}";
			}

			var textDocument = (TextDocument)Doc.Object("TextDocument");
			var docContent = textDocument.CreateEditPoint(textDocument.StartPoint).GetText(textDocument.EndPoint);
			return docContent;
		}

		public string Path
		{
			get { return Doc != null ? Doc.Path : string.Empty; }
		}

		public string Name
		{
			get { return Doc != null ? Doc.Name : string.Empty; }
		}

		public void SelectionMoveToLineAndOffset(int StartLine, int StartColumn)
		{
			if (Doc == null)
			{
				return;
			}

			var textDocument = (TextDocument)Doc.Object("TextDocument");
			textDocument.Selection.MoveToLineAndOffset(StartLine, StartColumn, false);
		}

		public void SetFocus()
		{
			if (Doc == null)
			{
				return;
			}

			Doc.Activate();
			_applicationObject.ActiveWindow.SetFocus();
		}

		#endregion
	}
}
