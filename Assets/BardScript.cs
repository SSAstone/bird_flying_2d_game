using UnityEngine;
using UnityEngine.InputSystem;


public class BardScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D BardRigidbody2D;
    public float moveSpeed = 10;
    public LogicScript logicScript; 

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            BardRigidbody2D.linearVelocity = Vector2.up * moveSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.GameOver();
    }
}