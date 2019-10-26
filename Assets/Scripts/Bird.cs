using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{

	public float jumpForce = 5;
	Rigidbody r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
        	r.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
