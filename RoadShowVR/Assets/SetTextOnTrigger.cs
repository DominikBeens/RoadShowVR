using UnityEngine;
using UnityEngine.UI;

public class SetTextOnTrigger : MonoBehaviour 
{

    [SerializeField]
    private string roomDescription;
    [SerializeField]
    private Text textToChange;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            textToChange.text = roomDescription;
        }
    }
}
