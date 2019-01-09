using UnityEngine;
using UnityEngine.UI;

namespace BroodStudios
{
	public class BuildVersion : MonoBehaviour
	{
		[SerializeField, HideInInspector]
		private Text _textBuilVersion = null;

		[SerializeField]
		private string _textVersion;

		[SerializeField]
		private Color _textColor = Color.yellow;

		[SerializeField, Range(8,64)]
		private int _fontSize = 14;

		[SerializeField]
		private AlignBuildVersion _screenPosition = AlignBuildVersion.TopLeft;



		private void Awake()
		{
			UpdateValues();
		}

		private void OnValidate()
		{
			UpdateValues();
		}

		private void UpdateValues()
		{
			if (_textBuilVersion)
			{
				_textBuilVersion.text = GetTextVersion();
				_textBuilVersion.color = _textColor;
				_textBuilVersion.fontSize = _fontSize;

			}
		}

		private string GetTextVersion()
		{
			if (_textVersion.Trim() != "")
				return _textVersion;
			else
				return "Void"; 
		}
	}
}
