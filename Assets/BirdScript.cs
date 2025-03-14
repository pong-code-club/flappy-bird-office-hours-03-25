using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public int MyInt;
    public float MyFloat;
    public string MyString;
    public bool MyBool;

    public Vector3 MyVector3;

    public Rigidbody MyRigidbody;

    public Transform BirdTransform;

    public float MyBirdSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BirdTransform = GetComponent<Transform>();

        MyInt = 10;

        //have to use the "new" keyword to assign a value to the vector3 struct
        MyVector3 = new Vector3(1, 2, 3);

        MyRigidbody = GetComponent<Rigidbody>();

        MyBirdSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //MyRigidbody.MovePosition(new Vector3(1,0,0));

        //MyRigidbody.MovePosition(BirdTransform.position + new Vector3(1, 0, 0));
        //MyRigidbody.MovePosition(BirdTransform.position + Vector3.right * Time.deltaTime * MyBirdSpeed);

        MyRigidbody.MovePosition(transform.position + Vector3.right * Time.deltaTime * MyBirdSpeed);
    }
}
