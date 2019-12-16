using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent startEvent, updateEvent;
    private void Start()
    {
        startEvent.Invoke();
    }


   private void Update()
    {
        updateEvent.Invoke();
    }
}
