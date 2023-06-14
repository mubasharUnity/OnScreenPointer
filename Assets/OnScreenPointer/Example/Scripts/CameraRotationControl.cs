using UnityEngine;

namespace OnScreenPointerPluginExample
{

    public class CameraRotationControl : MonoBehaviour
    {
        public float speed = 1;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            transform.rotation *= Quaternion.Euler(y, x, 0);

        }
    }
}