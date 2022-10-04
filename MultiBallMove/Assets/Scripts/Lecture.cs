using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lecture : MonoBehaviour {

    public Rigidbody rb;
    //public float moveSpeed = 10f;
    public int moveSpeed = 5;
    private float xInput;
    private float zInput;
    private Vector3 StartPoint;
    private Vector3 StartPointRotation;


   /*[SerializeField] 
   private Transform[] items;

   private List<Transform> itemList; 

   //private Dictionary<string, Transform> itemDict;

   [SerializeField]
   private bool testFunction;

   Vector3 originalPos;*/

   void Awake() {

        rb = GetComponent<Rigidbody>();
        StartPoint = this.transform.position;

        moveSpeed = Random.Range(5,15);

   }

        /*items = new Transform[10];

        itemList = new List<Transform>();
        
        itemDict = new Dictionary<string, Transform>();

        for (int i = 0; i < items.Length; i++) {
            itemDict.Add(items[i].name, items[i]);
        }

        itemDict["Transform"].position = new Vector3(1, 2, 3);


        originalPos = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y);

   } 

   void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "End") {
            gameObject.transform.position = originalPos;
        }
   }

   private int speed = 10;
     
     public void Move()
     {
     
     Vector3 Movement = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
     
    player.transform.position += Movement * speed * Time.DeltaTime;
     
     }
     
    Make sure the Project settings -> Input has Horizontal and vertical assigned to WASD/ Arrow keys.*/


    void Update() {

        ProcessInputs();

        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.position = Vector3.zero;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            transform.position = StartPoint;
            //moveSpeed = Random.Range(5,15);
            //rb.velocity = new Vector3(0, 0, 0);

        }

    }


    private void FixedUpdate() {

        // Movement
        Move();

    }

    private void ProcessInputs() {

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

    }

    private void Move() {

        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
        
    }
}

/*private void Update() {

    if (testFunction) {
        testFunction = false;
        doTestFunction();
    }
}

//missing
doTestFunction() {
    Debug.Log("Hello, world!");
} */



/* THIS IS FOR 9/29 CLASS NOTES

protected void Update() {

    if (Input.OnMouseButtonDown(0)) {

        Vector2 mousePos = Input.mousePosition;
        Ray ray = cam.ScreenPointToRay(mousePos);

        RaycastHit rch;

        if (Physics.Raycast(ray, out rch)) {

        }

    }

} woof
*/