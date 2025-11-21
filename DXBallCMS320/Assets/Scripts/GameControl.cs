using UnityEngine;
public class GameControl : MonoBehaviour
{
[SerializeField]
private Transform[] pictures;
[SerializeField]
private GameObject wintText;
public static bool youWin;
void Start()
{
wintText.SetActive(false);
youWin = false;
}
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= 15; i++)
        {
            if (!(pictures[i].rotation.z == 0))
            {
                return;
            }
        }
        youWin = true;
        wintText.SetActive(true);
    }
}
