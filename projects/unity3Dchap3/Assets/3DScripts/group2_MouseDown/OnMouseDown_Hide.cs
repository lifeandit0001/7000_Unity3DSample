using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチしたら、消す
public class OnMouseDown_Hide : MonoBehaviour
{
	private void OnMouseDown() // タッチしたら、消す
	{
		this.gameObject.SetActive(false);
	}
}
