using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押したら、移動＆ジャンプする
public class OnKeyPress_MoveGravity : MonoBehaviour
{
	public float speed = 3;      // スピード：Inspectorで指定
	public float jumppower = 6;  // ジャンプ力：Inspectorで指定

	float vx = 0;
	float vz = 0;
	bool pushFlag = false;		// スペースキーを押しっぱなしかどうか
	bool jumpFlag = false;		// ジャンプ状態かどうか
	bool groundFlag = false;	// 足が何かに触れているかどうか
	Rigidbody rbody;

	void Start () // 最初に、衝突しても回転させなくしておく
	{ 
		rbody = this.GetComponent<Rigidbody>();
		rbody.constraints = RigidbodyConstraints.FreezeRotation;
	}

	void Update () // ずっと行う
	{
		vx = Input.GetAxisRaw("Horizontal") * speed;
		vz = Input.GetAxisRaw("Vertical") * speed;		

		// もし、スペースキーが押されたとき、足が何かに触れていたら
		if (Input.GetKey("space") && groundFlag)
		{
			if (pushFlag == false) // 押しっぱなしでなければ
			{
				pushFlag = true; // 押した状態に
				jumpFlag = true; // ジャンプの準備
			}
		} else
		{
			pushFlag = false; 	// 押した状態解除
		}
	}
	private void FixedUpdate() // ずっと、移動する
	{
		if ((vx != 0)||(vz !=0))
		{
			this.transform.Translate(vx / 50, 0,  vz / 50);
		}
		// もし、ジャンプするときならジャンプする
		if (jumpFlag)
		{
			jumpFlag = false;
			rbody.AddForce(new Vector3(0, jumppower, 0), ForceMode.Impulse);
		}
	}
	void OnTriggerStay(Collider collision) // 足が何かに触れたら
	{
		groundFlag = true;	//
	}
	void OnTriggerExit(Collider collision) // 足に何も触れなかったら
	{
		groundFlag = false;
	}
}
