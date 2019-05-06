using Textensions.Reveals.Base;
using TMPro;
using UnityEngine;

// A script used to quickly change between the text reveals without having to always change the references in the scene.
// You can ignore this script.
public class CurrentTextReveal : MonoBehaviour
{
	public TextReveal textReveal;

	public void ReplaceStringWithSources(TMP_InputField source)
	{
		textReveal.ReplaceStringWithSources(source);
	}

	public void Reveal()
	{
		textReveal.Reveal();
	}
}
