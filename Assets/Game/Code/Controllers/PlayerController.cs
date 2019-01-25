using UnityEngine;

namespace Code.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private CharacterController _characterController;

        private void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * 100, 0);

            _characterController.Move(transform.TransformDirection(Vector3.forward) * Input.GetAxis("Vertical") * Time.deltaTime * 10);
        }
    }
}