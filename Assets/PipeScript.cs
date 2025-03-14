using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public GameObject MyBirdGameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyBirdGameObject = GameObject.Find("Bird");
    }

    // Update is called once per frame
    void Update()
    {
        if (MyBirdGameObject.transform.position.x - transform.position.x > 10)
        {
            transform.position = new Vector3(transform.position.x + 15, transform.position.y, transform.position.z);
        }
    }
}
