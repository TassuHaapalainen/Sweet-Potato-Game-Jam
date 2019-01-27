using UnityEngine;

public class juttele : MonoBehaviour
{

    public Dialogue dialogue;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //set a layer or tag for this
        {
            FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
        }
    }
}
