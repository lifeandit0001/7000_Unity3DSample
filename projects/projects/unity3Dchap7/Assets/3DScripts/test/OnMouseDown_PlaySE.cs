using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチしたら、効果音を鳴らす
public class OnMouseDown_PlaySE : MonoBehaviour
{
	public AudioClip se;		// 効果音

	private void OnMouseDown() // タッチしたら
	{
		// 効果音を鳴らす
		gameObject.GetComponent<AudioSource>().PlayOneShot(se);
	}
}
