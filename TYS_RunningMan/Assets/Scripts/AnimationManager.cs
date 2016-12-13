using UnityEngine;
using System.Collections;

public class AnimationManager : MonoBehaviour {

	[System.Serializable]//让自定义的类有拖拉的界面
	public class AnimationSet{
		public AnimationClip animation;
		public float  speedAnimation =1;
	}

	public AnimationSet run,jump;

	//委托
	public delegate void AnimationHandle();
	public AnimationHandle animationState;

	Animation anim;

	void Start () {
		anim = GetComponent<Animation> ();//缓存
		animationState = Run;

	}
	

	void Update () {
		if (animationState != null)
			animationState ();
	}
	public void Run(){
		anim.Play (run.animation.name);
		anim[run.animation.name].speed = run.speedAnimation;
	}
	public void Jump(){
		anim.Play (jump.animation.name);
		anim[jump.animation.name].speed = run.speedAnimation;
	}
}
