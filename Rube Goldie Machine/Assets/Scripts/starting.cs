using UnityEngine;
using System.Collections;

public class starting : MonoBehaviour {
    private Transform myTransform;

    public float moveSpeed;


    // Use this for initialization
    void Start () {
        myTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            myTransform.position += transform.right * Time.deltaTime * moveSpeed;
        }

    }
}
