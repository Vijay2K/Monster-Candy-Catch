using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool CanMove = true;
    [SerializeField]
    float MovingSpeed;
    [SerializeField]
    float MaxPos;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove == true)
        {
            Move();
        }
    }
    public void Move()
    {
       float x =  Input.GetAxis("Horizontal");
        
       
       
        transform.position +=  Vector3.right* x*MovingSpeed*Time.deltaTime;

        float Posx = Mathf.Clamp(transform.position.x, -MaxPos, MaxPos);

        transform.position = new Vector3(Posx, transform.position.y, transform.position.z);
       
       
    }

    
}
