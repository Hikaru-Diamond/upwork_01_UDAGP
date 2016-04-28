using UnityEngine;
using System.Collections;

public class playSoundEffects : MonoBehaviour {

    public AudioSource jump, walk, land;
    //public CharacterPhysicsController player;
    
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Jump")) {
            jump.Play();
        }

        //if(grounded){
            if(Input.GetAxis("Horizontal") != 0f) {
                walk.Play();
            } else {
                walk.Stop();
            }
        //}
	}
}
