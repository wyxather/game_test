using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	Vector3 to = new Vector3(Mathf.Clamp(target.position.x, 0.0f, 20.0f), transform.position.y, transform.position.z);
        transform.position = Vector3.Slerp(transform.position, to, 2.0f * Time.deltaTime);
    }
}
