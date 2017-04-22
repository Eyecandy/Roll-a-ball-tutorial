using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	private int count;
	public Text countText;
	public Text winText;

	// Use this for initialization
	void Start () {
		
		count = 0;
		countText.text = "Count: "+count.ToString();
		rb = GetComponent<Rigidbody> ();
		winText.text = "";
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * 10);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("pickup")) {
			other.gameObject.SetActive (false);
			count++;
			countText.text = "Count: " + count.ToString ();
			if (count == 8) {
				winText.text = "you win";
			}
		}
			
	}
}
