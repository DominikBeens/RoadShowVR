using UnityEngine;

public class LookAtTarget : MonoBehaviour 
{

    [SerializeField]
    private Transform target;

    private void Awake()
    {
        if (target == null)
        {
            target = Camera.main.transform;
        }
    }

    private void Update()
    {
        transform.LookAt(target);
    }
}
