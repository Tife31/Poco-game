using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public float levelLength =200f;

    //to create a refrence from the plyer collision script to the player movement script.

    
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle" )
        {
            
            //FindObjectOfType<GameManager>().EndGame();
        }
    }
    void FixedUpdate()
    {
        if (this.transform.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        else if(this.transform.position.z > levelLength)
        {
            //FindObjectOfType<GameManager>().EndGame();
            //print level completed. call another function.
        }
    }

}
