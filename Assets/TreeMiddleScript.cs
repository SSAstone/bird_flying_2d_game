using UnityEngine;

public class TreeMiddleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public LogicScript logicScript;

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicScript.AddScore();
    }
}
