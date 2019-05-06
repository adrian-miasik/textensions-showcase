using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class ReplaceTextWithSceneName : MonoBehaviour
{
	[SerializeField] protected TMP_Text text;

	private void Reset()
	{
		text = GetComponent<TMP_Text>();
	}

	private void Update()
	{
		text.text = SceneManager.GetActiveScene().name;
	}
}
