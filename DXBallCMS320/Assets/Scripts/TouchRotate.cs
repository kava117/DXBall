using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControl.youWin)
        {
            transform.Rotate(0, 0, 90);
        }
    }
}
