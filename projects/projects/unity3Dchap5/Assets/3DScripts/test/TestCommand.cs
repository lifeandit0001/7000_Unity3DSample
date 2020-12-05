using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

// A behaviour that is attached to a playable
public class TestCommand : PlayableBehaviour {
	// Called when the owning graph starts playing
	public override void OnGraphStart(Playable playable) {
		
	}

	// Called when the owning graph stops playing
	public override void OnGraphStop(Playable playable) {
		
	}

	public string msg; 	// Assetから受け取る変数
	// Called when the state of the playable is set to Play
	public override void OnBehaviourPlay(Playable playable, FrameData info) {
		Debug.Log(msg);
	}

	// Called when the state of the playable is set to Paused
	public override void OnBehaviourPause(Playable playable, FrameData info) {
		
	}

	// Called each frame while the state is set to Play
	public override void PrepareFrame(Playable playable, FrameData info) {
		
	}
}
