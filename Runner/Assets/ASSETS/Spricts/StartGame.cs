using UnityEngine;
using System.Collections;


public class StartGame : MonoBehaviour {

	public Texture2D normal;//普通

	public Texture2D active;//高亮

	public string levelname;

	void OnMouseDown(){
		GetComponent<GUITexture>().texture = active;
	}
	void Start(){
	
	
	}
	void Update(){
	
	
	}

}
