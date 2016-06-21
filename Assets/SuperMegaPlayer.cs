using UnityEngine;
using System.Collections;

[SerializePrivateVariables]
public class SuperMegaPlayer : MonoBehaviour {
    
    private float speed = 10f;
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
    }
}
