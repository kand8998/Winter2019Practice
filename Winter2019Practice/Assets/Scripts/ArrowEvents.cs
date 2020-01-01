using UnityEngine;
using UnityEngine.Events;

public class ArrowEvents : MonoBehaviour
{
    public UnityEvent upArrowEvent, downArrowEvent, leftArrowEvent, rightArrowEvent, returnArrowEvent;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            upArrowEvent.Invoke();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downArrowEvent.Invoke();
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftArrowEvent.Invoke();
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightArrowEvent.Invoke();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            returnArrowEvent.Invoke();
        }
    }
}
