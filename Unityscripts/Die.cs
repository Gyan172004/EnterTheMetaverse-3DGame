using UnityEngine;

public class Die : MonoBehaviour {

    public Animator animator;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Body")) { // Check if the attacking object is the player
            animator.SetBool("Damage", true); // Play the attack animation on the hit character's animator component
        }
    }
}

