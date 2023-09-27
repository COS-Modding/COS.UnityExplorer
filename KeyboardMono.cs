using UnityEngine;

namespace UnityExplorer
{
    public class KeyboardMono : MonoBehaviour
    {
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.F7))
            {
                UnityExplorer.Instance.InitExplorer();
            }
        }
    }
}