using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    //transform to get a reference to the player
    //transform and vector are both data types.
    public Transform player;
    public Vector3 offset; //just taking the position of the player and addding offsets to the x , y and z coordinates.

	// Update is called once per frame
	void Update () {
        //update is what this should do as a frame is changing

        //when you write transfrom with a none captial T, it refers to the current object you are working with.
        transform.position = player.position + offset;
    }
}
