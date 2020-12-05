using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、効果音を鳴らす
public class OnCollision_PlaySE : MonoBehaviour
{
	public AudioClip se;		// 効果音

	private void OnCollisionEnter(Collision collision) // 衝突したら
	{
		// 効果音を鳴らす
		gameObject.GetComponent<AudioSource>().PlayOneShot(se);
	}
}
