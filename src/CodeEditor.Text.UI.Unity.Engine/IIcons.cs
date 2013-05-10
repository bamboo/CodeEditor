using UnityEngine;

namespace CodeEditor.Text.UI.Unity.Engine
{
	public interface IIcons
	{
		Texture2D GetIcon(string iconNameWithExtension);
	}
}
