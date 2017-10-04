using UnityEngine;
using System.Collections;

public class SpriteInfo : MonoBehaviour {

	//attributes
	public Vector3 center;
	public Vector3 min;
	public Vector3 max;
	public SpriteRenderer spriteRenderer;
	
	// Use this for initialization
	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		center = spriteRenderer.bounds.center;
		min = spriteRenderer.bounds.min;
		max = spriteRenderer.bounds.max;	
	}
	
	// Update is called once per frame
	void Update () {
		center = spriteRenderer.bounds.center;
		min = spriteRenderer.bounds.min;
		max = spriteRenderer.bounds.max;
	}
}