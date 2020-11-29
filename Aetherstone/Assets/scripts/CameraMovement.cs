using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void LateUpdate()
    {
        if (transform.position != target.position) //says if transform.position is not equal to targrt.position
        {
            Vector3 targetPosition = new Vector3
                (target.position.x, target.position.y,transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(transform.position,targetPosition,smoothing);


            //make the funny camera muve 
            //make the funny canera move 
            //make thc funky camera move 
            //make the funny camera move 
            //did you find the mistakes :)
        }
    }
}
