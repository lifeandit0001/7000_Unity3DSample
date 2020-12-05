using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押したら、移動＆ジャンプする（テスト版）
public class OnKeyPress_TestMoveGravity : MonoBehaviour
{
	public float speed = 3;      // スピード：Inspectorで指定
	public float jumppower = 6;  // ジャンプ力：Inspectorで指定

	float vx = 0;
	float vz = 0;
	bool pushFlag = false; // スペースキーを押しっぱなしかどうか
	bool jumpFlag = false; // ジャンプ状態かどうか
	Rigidbody rbody;

	void Start () // 最初に、衝突しても回転させなくしておく
	{
		rbody = this.GetComponent<Rigidbody>();
		rbody.constraints = RigidbodyConstraints.FreezeRotation;
	}

	void Update () // ずっと行う
	{
		vx = 0;
		vx = 0;
		vz = 0;
		if (Input.GetKey("right")) // もし、右キーが押されたら
		{
			vx = speed; // 右に進む移動量を入れる
		}
		if (Input.GetKey("left")) // もし、左キーが押されたら
		{
			vx = -speed; // 左に進む移動量を入れる
		}
		if (Input.GetKey("up")) // もし、上キー顔されたら
		{
			vz = speed; // 上に進む移動量を入れる
		}
		if (Input.GetKey("down")) // もし、下キーが押されたら
		{
			vz = -speed; // 下に進む移動量を入れる
		}
		// もし、スペースキーが押されたら
		if (Input.GetKey("space"))
		{
			if (pushFlag == false) // 押しっぱなしでなければ
			{
				pushFlag = true; // 押した状態に
				jumpFlag = true; // ジャンプの準備
			}
		} else {
			pushFlag = false; // 押した状態解除
		}
	}
	private void FixedUpdate() // ずっと、移動する
	{
		if ((vx != 0)||(vz !=0))
		{
			this.transform.Translate(vx/50, 0,  vz/50);
		}
		// もし、ジャンプするときならジャンプする
		if (jumpFlag)
		{
			jumpFlag = false;
			rbody.AddForce(new Vector3(0, jumppower, 0), ForceMode.Impulse);
		}
	}
}
