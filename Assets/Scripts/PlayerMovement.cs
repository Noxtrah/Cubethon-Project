using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime,0,0);
        if( Input.GetKey("d")){
            rb.AddForce(0,0,-sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if( Input.GetKey("a")){
            rb.AddForce(0,0,sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
         if( Input.GetKey("c")){
            player = GameObject.Find("Player");
            player.transform.position = new Vector3(450,1,1);
        }
    }
}