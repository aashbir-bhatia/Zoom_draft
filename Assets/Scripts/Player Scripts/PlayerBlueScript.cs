using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlueScript : MonoBehaviour
{
    private float speed = 5.0f;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void FixedUpdate()
    {
        Vector3 direction = new Vector3(variableJoystick.Horizontal, variableJoystick.Vertical);
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
        
    }
}
